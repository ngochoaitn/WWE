﻿namespace WWE.UserControls
{
    partial class uXuLyEmail
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnChonFileCanKiemTra = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChonFileCanXoa = new System.Windows.Forms.Button();
            this.txtEmailCanXoa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtChiaDanhSach = new System.Windows.Forms.TextBox();
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panBot = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblTrangThai = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnXuLy = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panMid = new System.Windows.Forms.Panel();
            this.panTop = new System.Windows.Forms.Panel();
            this.lblDuongDanTepNguon = new System.Windows.Forms.Label();
            this.panBot.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panMid.SuspendLayout();
            this.panTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập danh sách email cần kiểm tra";
            // 
            // btnChonFileCanKiemTra
            // 
            this.btnChonFileCanKiemTra.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnChonFileCanKiemTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonFileCanKiemTra.Location = new System.Drawing.Point(249, 5);
            this.btnChonFileCanKiemTra.Name = "btnChonFileCanKiemTra";
            this.btnChonFileCanKiemTra.Size = new System.Drawing.Size(75, 23);
            this.btnChonFileCanKiemTra.TabIndex = 1;
            this.btnChonFileCanKiemTra.Text = "Browser...";
            this.btnChonFileCanKiemTra.UseVisualStyleBackColor = false;
            this.btnChonFileCanKiemTra.Click += new System.EventHandler(this.btnChonFileCanKiemTra_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập danh sách email cần xóa";
            // 
            // btnChonFileCanXoa
            // 
            this.btnChonFileCanXoa.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnChonFileCanXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonFileCanXoa.Location = new System.Drawing.Point(249, 5);
            this.btnChonFileCanXoa.Name = "btnChonFileCanXoa";
            this.btnChonFileCanXoa.Size = new System.Drawing.Size(75, 23);
            this.btnChonFileCanXoa.TabIndex = 1;
            this.btnChonFileCanXoa.Text = "Browser...";
            this.btnChonFileCanXoa.UseVisualStyleBackColor = false;
            this.btnChonFileCanXoa.Click += new System.EventHandler(this.btnChonFileCanXoa_Click);
            // 
            // txtEmailCanXoa
            // 
            this.txtEmailCanXoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmailCanXoa.Location = new System.Drawing.Point(0, 32);
            this.txtEmailCanXoa.MaxLength = 90000000;
            this.txtEmailCanXoa.Multiline = true;
            this.txtEmailCanXoa.Name = "txtEmailCanXoa";
            this.txtEmailCanXoa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEmailCanXoa.Size = new System.Drawing.Size(688, 302);
            this.txtEmailCanXoa.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chia danh sách đã kiểm tra thành";
            // 
            // txtChiaDanhSach
            // 
            this.txtChiaDanhSach.Location = new System.Drawing.Point(172, 3);
            this.txtChiaDanhSach.Name = "txtChiaDanhSach";
            this.txtChiaDanhSach.Size = new System.Drawing.Size(36, 20);
            this.txtChiaDanhSach.TabIndex = 3;
            this.txtChiaDanhSach.Text = "5";
            this.txtChiaDanhSach.WordWrap = false;
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.BackColor = System.Drawing.Color.Turquoise;
            this.btnXuatFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatFile.Location = new System.Drawing.Point(249, 2);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(75, 23);
            this.btnXuatFile.TabIndex = 1;
            this.btnXuatFile.Text = "Xuất file";
            this.btnXuatFile.UseVisualStyleBackColor = false;
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "phần";
            // 
            // panBot
            // 
            this.panBot.Controls.Add(this.statusStrip1);
            this.panBot.Controls.Add(this.label3);
            this.panBot.Controls.Add(this.label4);
            this.panBot.Controls.Add(this.txtChiaDanhSach);
            this.panBot.Controls.Add(this.btnXuLy);
            this.panBot.Controls.Add(this.btnXuatFile);
            this.panBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBot.Location = new System.Drawing.Point(0, 389);
            this.panBot.Name = "panBot";
            this.panBot.Size = new System.Drawing.Size(688, 48);
            this.panBot.TabIndex = 5;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTrangThai});
            this.statusStrip1.Location = new System.Drawing.Point(0, 26);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(688, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(54, 17);
            this.lblTrangThai.Text = "Sẵn sàng";
            // 
            // btnXuLy
            // 
            this.btnXuLy.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnXuLy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuLy.Location = new System.Drawing.Point(330, 1);
            this.btnXuLy.Name = "btnXuLy";
            this.btnXuLy.Size = new System.Drawing.Size(75, 23);
            this.btnXuLy.TabIndex = 1;
            this.btnXuLy.Text = "Xử lý dữ liệu";
            this.btnXuLy.UseVisualStyleBackColor = false;
            this.btnXuLy.Click += new System.EventHandler(this.btnXuLy_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnChonFileCanXoa);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(688, 32);
            this.panel3.TabIndex = 6;
            // 
            // panMid
            // 
            this.panMid.Controls.Add(this.txtEmailCanXoa);
            this.panMid.Controls.Add(this.panel3);
            this.panMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMid.Location = new System.Drawing.Point(0, 55);
            this.panMid.Name = "panMid";
            this.panMid.Size = new System.Drawing.Size(688, 334);
            this.panMid.TabIndex = 7;
            // 
            // panTop
            // 
            this.panTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panTop.Controls.Add(this.lblDuongDanTepNguon);
            this.panTop.Controls.Add(this.label1);
            this.panTop.Controls.Add(this.btnChonFileCanKiemTra);
            this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTop.Location = new System.Drawing.Point(0, 0);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(688, 55);
            this.panTop.TabIndex = 8;
            // 
            // lblDuongDanTepNguon
            // 
            this.lblDuongDanTepNguon.AutoEllipsis = true;
            this.lblDuongDanTepNguon.AutoSize = true;
            this.lblDuongDanTepNguon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblDuongDanTepNguon.Location = new System.Drawing.Point(0, 36);
            this.lblDuongDanTepNguon.Name = "lblDuongDanTepNguon";
            this.lblDuongDanTepNguon.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblDuongDanTepNguon.Size = new System.Drawing.Size(0, 17);
            this.lblDuongDanTepNguon.TabIndex = 3;
            // 
            // uXuLyEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panMid);
            this.Controls.Add(this.panBot);
            this.Controls.Add(this.panTop);
            this.Name = "uXuLyEmail";
            this.Size = new System.Drawing.Size(688, 437);
            this.panBot.ResumeLayout(false);
            this.panBot.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panMid.ResumeLayout(false);
            this.panMid.PerformLayout();
            this.panTop.ResumeLayout(false);
            this.panTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChonFileCanKiemTra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChonFileCanXoa;
        private System.Windows.Forms.TextBox txtEmailCanXoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtChiaDanhSach;
        private System.Windows.Forms.Button btnXuatFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panBot;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panMid;
        private System.Windows.Forms.Panel panTop;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblTrangThai;
        private System.Windows.Forms.Button btnXuLy;
        private System.Windows.Forms.Label lblDuongDanTepNguon;
    }
}
