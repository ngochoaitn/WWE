namespace WWE.UserControls
{
    partial class uQuetEmail
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLuuPhien = new System.Windows.Forms.Button();
            this.btnQuetDuLieu = new System.Windows.Forms.Button();
            this.txtWebsite = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.grbThietLap = new System.Windows.Forms.GroupBox();
            this.txtSoLuong = new System.Windows.Forms.NumericUpDown();
            this.txtQuetTenMien = new System.Windows.Forms.TextBox();
            this.radTatCa = new System.Windows.Forms.RadioButton();
            this.radTheoTenMien = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSoEmail = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSoLienKet = new System.Windows.Forms.ToolStripStatusLabel();
            this.emailDataGridView = new System.Windows.Forms.DataGridView();
            this.cmnsQetDuLieu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.phiênMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mởPhiênĐãLưuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTamDungVaXuat = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.emailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grbThietLap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emailDataGridView)).BeginInit();
            this.cmnsQetDuLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTamDungVaXuat);
            this.groupBox1.Controls.Add(this.btnLuuPhien);
            this.groupBox1.Controls.Add(this.btnQuetDuLieu);
            this.groupBox1.Controls.Add(this.txtWebsite);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thiết lập cấu hình";
            // 
            // btnLuuPhien
            // 
            this.btnLuuPhien.Enabled = false;
            this.btnLuuPhien.Location = new System.Drawing.Point(216, 57);
            this.btnLuuPhien.Name = "btnLuuPhien";
            this.btnLuuPhien.Size = new System.Drawing.Size(75, 23);
            this.btnLuuPhien.TabIndex = 4;
            this.btnLuuPhien.Text = "Lưu phiên";
            this.btnLuuPhien.UseVisualStyleBackColor = true;
            this.btnLuuPhien.Click += new System.EventHandler(this.btnLuuPhien_Click);
            // 
            // btnQuetDuLieu
            // 
            this.btnQuetDuLieu.Location = new System.Drawing.Point(23, 56);
            this.btnQuetDuLieu.Name = "btnQuetDuLieu";
            this.btnQuetDuLieu.Size = new System.Drawing.Size(75, 23);
            this.btnQuetDuLieu.TabIndex = 2;
            this.btnQuetDuLieu.Text = "Bắt đầu";
            this.btnQuetDuLieu.UseVisualStyleBackColor = true;
            this.btnQuetDuLieu.Click += new System.EventHandler(this.btnQuetDuLieu_Click);
            // 
            // txtWebsite
            // 
            this.txtWebsite.Location = new System.Drawing.Point(23, 30);
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtWebsite.Size = new System.Drawing.Size(268, 20);
            this.txtWebsite.TabIndex = 1;
            this.txtWebsite.Text = "https://muaban.net/";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Domain quét:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Số luồng chạy:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.grbThietLap);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 86);
            this.panel1.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(583, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 86);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // grbThietLap
            // 
            this.grbThietLap.Controls.Add(this.txtSoLuong);
            this.grbThietLap.Controls.Add(this.txtQuetTenMien);
            this.grbThietLap.Controls.Add(this.radTatCa);
            this.grbThietLap.Controls.Add(this.radTheoTenMien);
            this.grbThietLap.Controls.Add(this.label2);
            this.grbThietLap.Dock = System.Windows.Forms.DockStyle.Right;
            this.grbThietLap.Location = new System.Drawing.Point(586, 0);
            this.grbThietLap.Name = "grbThietLap";
            this.grbThietLap.Size = new System.Drawing.Size(304, 86);
            this.grbThietLap.TabIndex = 1;
            this.grbThietLap.TabStop = false;
            this.grbThietLap.Text = "Thiết lập điều kiện lọc email";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(90, 55);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(45, 20);
            this.txtSoLuong.TabIndex = 9;
            this.txtSoLuong.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // txtQuetTenMien
            // 
            this.txtQuetTenMien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuetTenMien.Location = new System.Drawing.Point(189, 23);
            this.txtQuetTenMien.Name = "txtQuetTenMien";
            this.txtQuetTenMien.Size = new System.Drawing.Size(109, 20);
            this.txtQuetTenMien.TabIndex = 8;
            this.txtQuetTenMien.Text = "yahoo.com, gmail.com";
            // 
            // radTatCa
            // 
            this.radTatCa.AutoSize = true;
            this.radTatCa.Checked = true;
            this.radTatCa.Location = new System.Drawing.Point(6, 26);
            this.radTatCa.Name = "radTatCa";
            this.radTatCa.Size = new System.Drawing.Size(56, 17);
            this.radTatCa.TabIndex = 7;
            this.radTatCa.TabStop = true;
            this.radTatCa.Text = "Tất cả";
            this.radTatCa.UseVisualStyleBackColor = true;
            // 
            // radTheoTenMien
            // 
            this.radTheoTenMien.AutoSize = true;
            this.radTheoTenMien.Location = new System.Drawing.Point(90, 26);
            this.radTheoTenMien.Name = "radTheoTenMien";
            this.radTheoTenMien.Size = new System.Drawing.Size(93, 17);
            this.radTheoTenMien.TabIndex = 6;
            this.radTheoTenMien.Text = "Theo tên miền";
            this.radTheoTenMien.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblSoEmail,
            this.toolStripStatusLabel3,
            this.lblSoLienKet});
            this.statusStrip1.Location = new System.Drawing.Point(0, 420);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(890, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Email:";
            // 
            // lblSoEmail
            // 
            this.lblSoEmail.Name = "lblSoEmail";
            this.lblSoEmail.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblSoEmail.Size = new System.Drawing.Size(23, 17);
            this.lblSoEmail.Text = "0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(65, 17);
            this.toolStripStatusLabel3.Text = "Đã xử lý:";
            // 
            // lblSoLienKet
            // 
            this.lblSoLienKet.Name = "lblSoLienKet";
            this.lblSoLienKet.Size = new System.Drawing.Size(54, 17);
            this.lblSoLienKet.Text = "0 liên kết";
            // 
            // emailDataGridView
            // 
            this.emailDataGridView.AllowUserToAddRows = false;
            this.emailDataGridView.AllowUserToDeleteRows = false;
            this.emailDataGridView.AutoGenerateColumns = false;
            this.emailDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.emailDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.emailDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.emailDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.emailDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.emailDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.emailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.emailDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.emailDataGridView.DataSource = this.emailBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.emailDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.emailDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailDataGridView.GridColor = System.Drawing.Color.White;
            this.emailDataGridView.Location = new System.Drawing.Point(0, 86);
            this.emailDataGridView.MultiSelect = false;
            this.emailDataGridView.Name = "emailDataGridView";
            this.emailDataGridView.ReadOnly = true;
            this.emailDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.emailDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.emailDataGridView.RowHeadersWidth = 25;
            this.emailDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.emailDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.emailDataGridView.Size = new System.Drawing.Size(890, 334);
            this.emailDataGridView.TabIndex = 2;
            this.emailDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.emailDataGridView_CellClick);
            // 
            // cmnsQetDuLieu
            // 
            this.cmnsQetDuLieu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phiênMớiToolStripMenuItem,
            this.mởPhiênĐãLưuToolStripMenuItem});
            this.cmnsQetDuLieu.Name = "cmnsQetDuLieu";
            this.cmnsQetDuLieu.Size = new System.Drawing.Size(162, 48);
            // 
            // phiênMớiToolStripMenuItem
            // 
            this.phiênMớiToolStripMenuItem.Name = "phiênMớiToolStripMenuItem";
            this.phiênMớiToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.phiênMớiToolStripMenuItem.Text = "Phiên mới";
            this.phiênMớiToolStripMenuItem.Click += new System.EventHandler(this.phiênMớiToolStripMenuItem_Click);
            // 
            // mởPhiênĐãLưuToolStripMenuItem
            // 
            this.mởPhiênĐãLưuToolStripMenuItem.Name = "mởPhiênĐãLưuToolStripMenuItem";
            this.mởPhiênĐãLưuToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.mởPhiênĐãLưuToolStripMenuItem.Text = "Mở phiên đã lưu";
            this.mởPhiênĐãLưuToolStripMenuItem.Click += new System.EventHandler(this.mởPhiênĐãLưuToolStripMenuItem_Click);
            // 
            // btnTamDungVaXuat
            // 
            this.btnTamDungVaXuat.Enabled = false;
            this.btnTamDungVaXuat.Location = new System.Drawing.Point(104, 57);
            this.btnTamDungVaXuat.Name = "btnTamDungVaXuat";
            this.btnTamDungVaXuat.Size = new System.Drawing.Size(106, 23);
            this.btnTamDungVaXuat.TabIndex = 6;
            this.btnTamDungVaXuat.Text = "Tạm dừng và xuất";
            this.btnTamDungVaXuat.UseVisualStyleBackColor = true;
            this.btnTamDungVaXuat.Click += new System.EventHandler(this.btnTamDungVaXuat_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "STT";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn1.FillWeight = 35F;
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "STT";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 35;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DiaChiEmail";
            this.dataGridViewTextBoxColumn2.HeaderText = "Địa chỉ email";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.ActiveLinkColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LienKet";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nguồn liên kết";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.TrackVisitedState = false;
            this.dataGridViewTextBoxColumn3.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // emailBindingSource
            // 
            this.emailBindingSource.DataSource = typeof(WWE.Lib.Email);
            // 
            // uQuetEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.emailDataGridView);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "uQuetEmail";
            this.Size = new System.Drawing.Size(890, 442);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.grbThietLap.ResumeLayout(false);
            this.grbThietLap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emailDataGridView)).EndInit();
            this.cmnsQetDuLieu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.emailBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtWebsite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLuuPhien;
        private System.Windows.Forms.Button btnQuetDuLieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grbThietLap;
        private System.Windows.Forms.RadioButton radTatCa;
        private System.Windows.Forms.RadioButton radTheoTenMien;
        private System.Windows.Forms.TextBox txtQuetTenMien;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.NumericUpDown txtSoLuong;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblSoEmail;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lblSoLienKet;
        private System.Windows.Forms.BindingSource emailBindingSource;
        private System.Windows.Forms.DataGridView emailDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ContextMenuStrip cmnsQetDuLieu;
        private System.Windows.Forms.ToolStripMenuItem phiênMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mởPhiênĐãLưuToolStripMenuItem;
        private System.Windows.Forms.Button btnTamDungVaXuat;
    }
}
