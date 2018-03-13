﻿using System;
using System.IO;
using System.Windows.Forms;
using ThuVienWinform.UI;
using WWE.Lib.Security;

namespace WWE
{
    public partial class frmVerify : Form
    {
        public frmVerify()
        {
            InitializeComponent();

            ControlPlus.MovieFormWhenMouseDownControl(controlBoxFlat1, this.Handle);
            ControlPlus.MovieFormWhenMouseDownControl(controlBoxFlat1.lblFormText, this.Handle);
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime? hanSuDung = Crypto.VerifySignature(txtMaSuDung.Text);
                if (hanSuDung != null)
                {
                    if (hanSuDung >= DataUseForSecurity.GetReadDate())
                    {
                        MessageBox.Show(string.Format("Đã xác thực hạn sử dụng đến ngày {0:dd/MM/yyyy}", hanSuDung.Value.ToShortDateString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information));
                        File.AppendAllText(ConstFilePath.FILE_KEY, txtMaSuDung.Text + "\n");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Mã hết hạn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                    MessageBox.Show("Sai mã", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi xác thực", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmVerify_Load(object sender, EventArgs e)
        {
            textBoxFlat1.Text = DataUseForSecurity.GenKeySendToAdmin();
            lblWebChinhThuc.Text = Properties.Settings.Default.WebChinhThuc;
        }
    }
}
