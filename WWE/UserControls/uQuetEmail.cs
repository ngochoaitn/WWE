using Aspose.Cells;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using WWE.Lib;
using WWE.Supports;

namespace WWE.UserControls
{
    public partial class uQuetEmail : UserControl
    {
        SessionQuetEmail _session;
        public uQuetEmail()
        {
            InitializeComponent();
            txtQuetTenMien.DataBindings.Add("Enabled", radTheoTenMien, "Checked");
            CheckForIllegalCrossThreadCalls = false;
        }

        private void EnableControl(bool b)
        {
            btnQuetDuLieu.Enabled = b;
            btnLuuPhien.Enabled = b;
            grbThietLap.Enabled = b;
            txtWebsite.Enabled = b;
            btnTamDungVaXuat.Enabled = true;
        }

        private void btnQuetDuLieu_Click(object sender, EventArgs e)
        {
            cmnsQetDuLieu.Show(Cursor.Position);
        }

        private void _session_QuetLinkMoi()
        {
            XuLyDaLuong.ChangeText(lblSoLienKet, statusStrip1, $"{_session.SoLienKetDaQuet} liên kết", Color.Black);
        }

        private void _session_CoEmailMoi(Email em)
        {
            if(!emailDataGridView.InvokeRequired)
            {
                //emailDataGridView.Rows.Add(new[] { em });
                emailBindingSource.Add(em);
            }
            else
            {
                emailDataGridView.BeginInvoke(new Action(() =>
                {
                    try
                    {
                        emailBindingSource.Add(em);
                    }
                    catch
                    {
                        Debug.WriteLine("Lỗi hiển thị email");
                    }
                    //emailDataGridView.DataSource = _session.DanhSachEmail();
                }));
            }
            XuLyDaLuong.ChangeText(lblSoEmail, statusStrip1, (emailBindingSource.Count+1).ToString(), Color.Black);
        }

        private void emailDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > 0 && emailDataGridView.Columns[e.ColumnIndex] == dataGridViewTextBoxColumn3)
            {
                var em = emailBindingSource.Current as Email;
                if (em != null && em.LienKet != null)
                    Process.Start(em.LienKet);
            }
        }

        private void btnLuuPhien_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Tệp WWE|*.wwe";
            var n = DateTime.Now;
            save.FileName = $"Lưu phiên {n.ToString("HH-mm")}_{n.ToString("dd-MM-yyyy")}.wwe";
            save.Title = "Lưu phiên";
            if (save.ShowDialog() != DialogResult.Cancel)
            {
                _session.CoEmailMoi -= _session_CoEmailMoi;
                _session.QuetLinkMoi -= _session_QuetLinkMoi;

                _session.LuuSession(save.FileName);
            }
        }

        private void phiênMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int threadToiDa = Convert.ToInt32(txtSoLuong.Text);

            ThreadPool.SetMaxThreads(threadToiDa, threadToiDa);

            txtWebsite.Text = txtWebsite.Text.ToLower();

            EnableControl(false);
            btnLuuPhien.Enabled = false;
            _session = new SessionQuetEmail();
            emailBindingSource.Clear();
            _session.SoLuong = threadToiDa;
            _session.CoEmailMoi += _session_CoEmailMoi;
            _session.QuetLinkMoi += _session_QuetLinkMoi;
            _session.BoLoc = radTheoTenMien.Checked ? txtQuetTenMien.Text : null;

            _session.QuetLink(txtWebsite.Text);
        }

        private void mởPhiênĐãLưuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Tệp WWE|*.wwe";
            open.Title = "Mở phiên";
            open.Multiselect = false;
            if (open.ShowDialog() != DialogResult.Cancel)
            {
                _session = SessionQuetEmail.Load(open.FileName);
                ThreadPool.SetMaxThreads(_session.SoLuong, _session.SoLuong);
                emailBindingSource.DataSource = _session.DanhSachEmail();

                _session.CoEmailMoi += _session_CoEmailMoi;
                _session.QuetLinkMoi += _session_QuetLinkMoi;

                txtSoLuong.Text = _session.SoLuong.ToString();

                if(_session.BoLoc != null)
                {
                    radTheoTenMien.Checked = true;
                    txtQuetTenMien.Text = _session.BoLoc;
                }
                EnableControl(false);
                _session.TiepTuc();

                XuLyDaLuong.ChangeText(lblSoEmail, statusStrip1, (emailBindingSource.Count + 1).ToString(), Color.Black);
                XuLyDaLuong.ChangeText(lblSoLienKet, statusStrip1, $"{_session.SoLienKetDaQuet} liên kết", Color.Black);
            }
        }

        private void btnTamDungVaXuat_Click(object sender, EventArgs e)
        {
            if (btnTamDungVaXuat.Text == "Tạm dừng và xuất")
            {
                _session.DungSession();
                EnableControl(true);
                btnLuuPhien.Enabled = true;
                btnTamDungVaXuat.Text = "Tiếp tục";
                XuatDanhSach();
            }
            else
            {
                EnableControl(false);
                _session.SoLuong = Convert.ToInt32(txtSoLuong.Text);
                ThreadPool.SetMaxThreads(_session.SoLuong, _session.SoLuong);
                _session.CoEmailMoi += _session_CoEmailMoi;
                _session.QuetLinkMoi += _session_QuetLinkMoi;
                _session.TiepTuc();
                btnTamDungVaXuat.Text = "Tạm dừng và xuất";
            }
        }

        private void XuatDanhSach()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Lưu tệp xuất dữ liệu";
            save.Filter = "Tệp CSV|*.csv";
            save.FileName = "Danh sách email.csv";
            
            if (save.ShowDialog() != DialogResult.Cancel)
            {
                Workbook wb = new Workbook();
                Worksheet ws = wb.Worksheets[0];
                for(int i = 0; i < emailBindingSource.Count; i++)
                {
                    var em = emailBindingSource[i] as Email;
                    ws.Cells[$"A{i + 1}"].Value = em.DiaChiEmail;
                }

                wb.Save(save.FileName, SaveFormat.CSV);
                Process.Start(save.FileName);

            }
        }
    }
}
