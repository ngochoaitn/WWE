using Aspose.Cells;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using WWE.Supports;

namespace WWE.UserControls
{
    public partial class uXuLyEmail : UserControl
    {
        string _duLieu = "";
        public uXuLyEmail()
        {
            InitializeComponent();
        }

        private void btnChonFileCanKiemTra_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Tệp văn bản, bảng tính|*.txt;*.xlsx;*.xls;*.csv";
            open.Title = "Chọn tệp chứa dữ liệu";
            open.Multiselect = false;
            if (open.ShowDialog() != DialogResult.Cancel)
            {
                ThreadPool.QueueUserWorkItem((WaitCallback) =>
                {
                    _duLieu = LayDuLieuTuFile(open.FileName);
                });
            }
        }

        private void btnChonFileCanXoa_Click(object sender, EventArgs e)
        {
            txtEmailCanXoa.Text = LayDuLieuTuFile();
        }

        private string LayDuLieuTuFile()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Tệp văn bản, bảng tính|*.txt";
            open.Title = "Chọn tệp chứa dữ liệu";
            open.Multiselect = false;
            if (open.ShowDialog() != DialogResult.Cancel)
            {
                return LayDuLieuTuFile(open.FileName);
            }
            return null;
        }

        private string LayDuLieuTuFile(string file)
        {
            lblDuongDanTepNguon.Text = file;
            XuLyDaLuong.ChangeText(lblTrangThai, statusStrip1, $"Đang đọc {file}...", Color.Red);
            FileInfo f = new FileInfo(file);
            if (f.Extension == ".txt")
            {
                XuLyDaLuong.ChangeText(lblTrangThai, statusStrip1, $"Đã đọc {file}", Color.Blue);
                return File.ReadAllText(file);
            }
            else
            {
                Workbook wb = new Workbook(file);
                string res = "";
                foreach (Worksheet ws in wb.Worksheets)
                {
                    //var th = new Thread((ThreadStart) =>
                    //{
                    //    LayDuLieuTuFile(ws);
                    //});
                    //th.Start();

                    int hangHienTai = 1;
                    while (true)
                    {
                        string tmp = Convert.ToString(ws.Cells[$"A{hangHienTai++}"].Value);
                        if (string.IsNullOrEmpty(tmp))
                            break;
                        res += (tmp + "\r\n");
                        XuLyDaLuong.ChangeText(lblTrangThai, statusStrip1, $"Đang đọc {file}...hàng {hangHienTai}", Color.Red);
                    }
                }
                XuLyDaLuong.ChangeText(lblTrangThai, statusStrip1, $"Đã đọc {file}", Color.Blue);
                return res;
            }
        }

        private void LayDuLieuTuFile(Worksheet ws)
        {
            for(int i = 1; i <= 500000; i += 20000)
            {
                ThreadPool.QueueUserWorkItem((WaitCallback) =>
                {
                    LayDuLieuTuFile(ws, i, i + 20000 - 1);
                });
                Thread.Sleep(500);
            }
        }

        private void LayDuLieuTuFile(Worksheet ws, int row_from, int row_to)
        {
            Debug.WriteLine($"Đọc file excel từ hàng: {row_from} -> {row_to}");
            for(int i = row_from; i <= row_to; i++)
            {
                string tmp = Convert.ToString(ws.Cells[$"A{i}"].Value);
                if (string.IsNullOrEmpty(tmp))
                    break;
                _duLieu += (tmp + "\r\n");
            }
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

            var danhSachCanKiemTra = validationExpression.Matches(_duLieu).Cast<Match>().Select(p => p.Value).ToList().Distinct();
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
                    string tenFile = $@"{save.SelectedPath}\{DateTime.Now.ToFileTime()}.txt";
                    int batDau = emailTrong1File*i;
                    int soCanLay = emailTrong1File;
                    if (i == soFileCanChia - 1)
                        soCanLay = danhSachCanXuat.Count - batDau;
                    Debug.WriteLine($"từ {batDau} lấy {soCanLay}: {tenFile}");
                    File.WriteAllLines(tenFile, danhSachCanXuat.GetRange(batDau, soCanLay));
                }
                XuLyDaLuong.ChangeText(lblTrangThai, statusStrip1, $"Hoàn tất xuất ra thư mục {save.SelectedPath}", Color.Blue);
                Process.Start(save.SelectedPath);
                #endregion
            }
        }

        private void btnXuLy_Click(object sender, EventArgs e)
        {
            Regex validationExpression = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
            
            var danhSachCanKiemTra = validationExpression.Matches(_duLieu).Cast<Match>().Select(p => p.Value).ToList().Distinct();
            var danhSachCanXoa = validationExpression.Matches(txtEmailCanXoa.Text).Cast<Match>().Select(p => p.Value).ToList().Distinct();

            _duLieu = string.Join("\r\n", danhSachCanKiemTra);
            txtEmailCanXoa.Text = string.Join("\r\n", danhSachCanXoa);
            XuLyDaLuong.ChangeText(lblTrangThai, statusStrip1, $"{danhSachCanKiemTra.Count()} email cần kiểm tra | {danhSachCanXoa.Count()} email cần xóa", Color.Blue);
        }
    }
}
