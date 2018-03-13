using Aspose.Cells;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WWE.Supports;

namespace WWE.UserControls
{
    public partial class uXuLyEmail : UserControl
    {
        public uXuLyEmail()
        {
            InitializeComponent();
        }

        private void btnChonFileCanKiemTra_Click(object sender, EventArgs e)
        {
            txtEmailCanKiemTra.Text = LayDuLieuTuFileAsync();
        }

        private void btnChonFileCanXoa_Click(object sender, EventArgs e)
        {
            txtEmailCanXoa.Text = LayDuLieuTuFileAsync();
        }

        private string LayDuLieuTuFileAsync()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Tệp văn bản, bảng tính|*.txt;*.xlsx;*.xls;*.csv";
            open.Title = "Chọn tệp chứa dữ liệu";
            open.Multiselect = false;
            if (open.ShowDialog() != DialogResult.Cancel)
            {
                XuLyDaLuong.ChangeText(lblTrangThai, statusStrip1, $"Đang đọc...", Color.Blue);
                FileInfo f = new FileInfo(open.FileName);
                if (f.Extension == ".txt")
                {
                    XuLyDaLuong.ChangeText(lblTrangThai, statusStrip1, $"Đã đọc {open.FileName}", Color.Blue);
                    return File.ReadAllText(open.FileName);
                }
                else
                {
                    Workbook wb = new Workbook(open.FileName);
                    string res = "";
                    foreach (Worksheet ws in wb.Worksheets)
                    {
                        int hangHienTai = 1;
                        while (true)
                        {
                            string tmp = Convert.ToString(ws.Cells[$"A{hangHienTai++}"].Value);
                            if (string.IsNullOrEmpty(tmp))
                                break;
                            res += (tmp + "\r\n");
                        }
                    }
                    XuLyDaLuong.ChangeText(lblTrangThai, statusStrip1, $"Đã đọc {open.FileName}", Color.Blue);
                    return res;
                }
            }
            return null;
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            #region Kiểm tra điều kiện
            int soFileCanChia = 0;
            try
            {
                soFileCanChia = Convert.ToInt32(txtChiaDanhSach.Text);
            }
            catch
            {
                XuLyDaLuong.ChangeText(lblTrangThai, statusStrip1, "Chưa nhập số file cần chia", Color.Red);
                return;
            }
            #endregion

            XuLyDaLuong.ChangeText(lblTrangThai, statusStrip1, "Xử lý dữ liệu...", Color.Blue);
            #region Xử lý dữ liệu
            Regex validationExpression = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");

            var danhSachCanKiemTra = validationExpression.Matches(txtEmailCanKiemTra.Text).Cast<Match>().Select(p => p.Value).ToList().Distinct();
            var danhSachCanXoa = validationExpression.Matches(txtEmailCanXoa.Text).Cast<Match>().Select(p => p.Value).ToList().Distinct();

            var danhSachCanXuat = danhSachCanKiemTra.Except(danhSachCanXoa).ToList();
            #endregion

            #region Xuất danh sách
            FolderBrowserDialog save = new FolderBrowserDialog();
            save.Description = "Lưu tệp xuất dữ liệu";
            save.ShowNewFolderButton = true;

            if (save.ShowDialog() != DialogResult.Cancel)
            {
                XuLyDaLuong.ChangeText(lblTrangThai, statusStrip1, "Xuất danh sách...", Color.Blue);
                int emailTrong1File = danhSachCanXuat.Count / soFileCanChia;
                Workbook wb = new Workbook(FileFormatType.CSV);
                for (int i = 0; i < soFileCanChia; i++)
                {
                    Debug.WriteLine($"{i}");
                    string tenFile = $@"{save.SelectedPath}\{DateTime.Now.ToFileTime()}.csv";
                    Worksheet ws = wb.Worksheets[0];
                    int batDau = emailTrong1File*i;
                    int ketThuc = emailTrong1File*(i+1);
                    if (i == soFileCanChia)
                        ketThuc = danhSachCanXuat.Count;
                    Debug.WriteLine($"{batDau} => {ketThuc}: {tenFile}");
                    int hangHienTai = 1;
                    for (int j = batDau; j < ketThuc; j++)
                        ws.Cells[$"A{hangHienTai++}"].Value = danhSachCanXuat[j];
                    wb.Save(tenFile, SaveFormat.CSV);

                }
                XuLyDaLuong.ChangeText(lblTrangThai, statusStrip1, $"Hoàn tất xuất ra thư mục {save.SelectedPath}", Color.Blue);
                Process.Start(save.SelectedPath);
                #endregion
            }
        }

        private void btnXuLy_Click(object sender, EventArgs e)
        {
            Regex validationExpression = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");

            var danhSachCanKiemTra = validationExpression.Matches(txtEmailCanKiemTra.Text).Cast<Match>().Select(p => p.Value).ToList().Distinct();
            var danhSachCanXoa = validationExpression.Matches(txtEmailCanXoa.Text).Cast<Match>().Select(p => p.Value).ToList().Distinct();

            txtEmailCanKiemTra.Text = string.Join("\r\n", danhSachCanKiemTra);
            txtEmailCanXoa.Text = string.Join("\r\n", danhSachCanXoa);
            XuLyDaLuong.ChangeText(lblTrangThai, statusStrip1, $"{danhSachCanKiemTra.Count()} email cần kiểm tra | {danhSachCanXoa.Count()} email cần xóa", Color.Blue);
        }
    }
}
