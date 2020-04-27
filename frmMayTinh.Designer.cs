namespace QuanLyPhongMay
{
    partial class frmMayTinh
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvMT = new System.Windows.Forms.DataGridView();
            this.gbMayTinh = new System.Windows.Forms.GroupBox();
            this.cboMOD = new System.Windows.Forms.ComboBox();
            this.cboMBP = new System.Windows.Forms.ComboBox();
            this.cboMaChuot = new System.Windows.Forms.ComboBox();
            this.cboMCMH = new System.Windows.Forms.ComboBox();
            this.cboMMH = new System.Windows.Forms.ComboBox();
            this.cboMTD = new System.Windows.Forms.ComboBox();
            this.cboMaRAM = new System.Windows.Forms.ComboBox();
            this.cboMaChip = new System.Windows.Forms.ComboBox();
            this.cboMDL = new System.Windows.Forms.ComboBox();
            this.cboMOC = new System.Windows.Forms.ComboBox();
            this.cboMPM = new System.Windows.Forms.ComboBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtTenMay = new System.Windows.Forms.TextBox();
            this.txtMaMay = new System.Windows.Forms.TextBox();
            this.lbGC = new System.Windows.Forms.Label();
            this.lbMaODia = new System.Windows.Forms.Label();
            this.lbMBP = new System.Windows.Forms.Label();
            this.lbMaChuot = new System.Windows.Forms.Label();
            this.lbMCMH = new System.Windows.Forms.Label();
            this.lbMMH = new System.Windows.Forms.Label();
            this.lbMTD = new System.Windows.Forms.Label();
            this.lbMRAM = new System.Windows.Forms.Label();
            this.lbMaChip = new System.Windows.Forms.Label();
            this.lbMDL = new System.Windows.Forms.Label();
            this.lbMaOCung = new System.Windows.Forms.Label();
            this.lbMPM = new System.Windows.Forms.Label();
            this.lbTenMay = new System.Windows.Forms.Label();
            this.lbMaMay = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMT)).BeginInit();
            this.gbMayTinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 405);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1228, 109);
            this.panel1.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(526, 26);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(97, 54);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(423, 26);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(97, 54);
            this.btnHuy.TabIndex = 0;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(320, 26);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(97, 54);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(217, 26);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(97, 54);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(114, 26);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(97, 54);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(11, 26);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(97, 54);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvMT
            // 
            this.dgvMT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMT.Location = new System.Drawing.Point(0, 210);
            this.dgvMT.Name = "dgvMT";
            this.dgvMT.RowHeadersWidth = 51;
            this.dgvMT.RowTemplate.Height = 24;
            this.dgvMT.Size = new System.Drawing.Size(1225, 198);
            this.dgvMT.TabIndex = 1;
            this.dgvMT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMT_CellContentClick);
            // 
            // gbMayTinh
            // 
            this.gbMayTinh.Controls.Add(this.cboMOD);
            this.gbMayTinh.Controls.Add(this.cboMBP);
            this.gbMayTinh.Controls.Add(this.cboMaChuot);
            this.gbMayTinh.Controls.Add(this.cboMCMH);
            this.gbMayTinh.Controls.Add(this.cboMMH);
            this.gbMayTinh.Controls.Add(this.cboMTD);
            this.gbMayTinh.Controls.Add(this.cboMaRAM);
            this.gbMayTinh.Controls.Add(this.cboMaChip);
            this.gbMayTinh.Controls.Add(this.cboMDL);
            this.gbMayTinh.Controls.Add(this.cboMOC);
            this.gbMayTinh.Controls.Add(this.cboMPM);
            this.gbMayTinh.Controls.Add(this.txtNote);
            this.gbMayTinh.Controls.Add(this.txtTenMay);
            this.gbMayTinh.Controls.Add(this.txtMaMay);
            this.gbMayTinh.Controls.Add(this.lbGC);
            this.gbMayTinh.Controls.Add(this.lbMaODia);
            this.gbMayTinh.Controls.Add(this.lbMBP);
            this.gbMayTinh.Controls.Add(this.lbMaChuot);
            this.gbMayTinh.Controls.Add(this.lbMCMH);
            this.gbMayTinh.Controls.Add(this.lbMMH);
            this.gbMayTinh.Controls.Add(this.lbMTD);
            this.gbMayTinh.Controls.Add(this.lbMRAM);
            this.gbMayTinh.Controls.Add(this.lbMaChip);
            this.gbMayTinh.Controls.Add(this.lbMDL);
            this.gbMayTinh.Controls.Add(this.lbMaOCung);
            this.gbMayTinh.Controls.Add(this.lbMPM);
            this.gbMayTinh.Controls.Add(this.lbTenMay);
            this.gbMayTinh.Controls.Add(this.lbMaMay);
            this.gbMayTinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbMayTinh.Location = new System.Drawing.Point(0, 0);
            this.gbMayTinh.Name = "gbMayTinh";
            this.gbMayTinh.Size = new System.Drawing.Size(1228, 204);
            this.gbMayTinh.TabIndex = 2;
            this.gbMayTinh.TabStop = false;
            this.gbMayTinh.Text = "Thông tin Máy tính";
            // 
            // cboMOD
            // 
            this.cboMOD.FormattingEnabled = true;
            this.cboMOD.Location = new System.Drawing.Point(1052, 21);
            this.cboMOD.Name = "cboMOD";
            this.cboMOD.Size = new System.Drawing.Size(153, 24);
            this.cboMOD.TabIndex = 36;
            // 
            // cboMBP
            // 
            this.cboMBP.FormattingEnabled = true;
            this.cboMBP.Location = new System.Drawing.Point(750, 158);
            this.cboMBP.Name = "cboMBP";
            this.cboMBP.Size = new System.Drawing.Size(153, 24);
            this.cboMBP.TabIndex = 35;
            // 
            // cboMaChuot
            // 
            this.cboMaChuot.FormattingEnabled = true;
            this.cboMaChuot.Location = new System.Drawing.Point(750, 108);
            this.cboMaChuot.Name = "cboMaChuot";
            this.cboMaChuot.Size = new System.Drawing.Size(153, 24);
            this.cboMaChuot.TabIndex = 34;
            // 
            // cboMCMH
            // 
            this.cboMCMH.FormattingEnabled = true;
            this.cboMCMH.Location = new System.Drawing.Point(750, 67);
            this.cboMCMH.Name = "cboMCMH";
            this.cboMCMH.Size = new System.Drawing.Size(153, 24);
            this.cboMCMH.TabIndex = 33;
            // 
            // cboMMH
            // 
            this.cboMMH.FormattingEnabled = true;
            this.cboMMH.Location = new System.Drawing.Point(750, 21);
            this.cboMMH.Name = "cboMMH";
            this.cboMMH.Size = new System.Drawing.Size(153, 24);
            this.cboMMH.TabIndex = 32;
            // 
            // cboMTD
            // 
            this.cboMTD.FormattingEnabled = true;
            this.cboMTD.Location = new System.Drawing.Point(445, 158);
            this.cboMTD.Name = "cboMTD";
            this.cboMTD.Size = new System.Drawing.Size(153, 24);
            this.cboMTD.TabIndex = 31;
            // 
            // cboMaRAM
            // 
            this.cboMaRAM.FormattingEnabled = true;
            this.cboMaRAM.Location = new System.Drawing.Point(445, 110);
            this.cboMaRAM.Name = "cboMaRAM";
            this.cboMaRAM.Size = new System.Drawing.Size(153, 24);
            this.cboMaRAM.TabIndex = 30;
            // 
            // cboMaChip
            // 
            this.cboMaChip.FormattingEnabled = true;
            this.cboMaChip.Location = new System.Drawing.Point(445, 69);
            this.cboMaChip.Name = "cboMaChip";
            this.cboMaChip.Size = new System.Drawing.Size(153, 24);
            this.cboMaChip.TabIndex = 29;
            // 
            // cboMDL
            // 
            this.cboMDL.FormattingEnabled = true;
            this.cboMDL.Location = new System.Drawing.Point(445, 21);
            this.cboMDL.Name = "cboMDL";
            this.cboMDL.Size = new System.Drawing.Size(153, 24);
            this.cboMDL.TabIndex = 28;
            // 
            // cboMOC
            // 
            this.cboMOC.FormattingEnabled = true;
            this.cboMOC.Location = new System.Drawing.Point(114, 154);
            this.cboMOC.Name = "cboMOC";
            this.cboMOC.Size = new System.Drawing.Size(153, 24);
            this.cboMOC.TabIndex = 27;
            // 
            // cboMPM
            // 
            this.cboMPM.FormattingEnabled = true;
            this.cboMPM.Location = new System.Drawing.Point(114, 110);
            this.cboMPM.Name = "cboMPM";
            this.cboMPM.Size = new System.Drawing.Size(153, 24);
            this.cboMPM.TabIndex = 26;
            this.cboMPM.SelectedIndexChanged += new System.EventHandler(this.cboMPM_SelectedIndexChanged_1);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(1052, 69);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(153, 22);
            this.txtNote.TabIndex = 23;
            // 
            // txtTenMay
            // 
            this.txtTenMay.Location = new System.Drawing.Point(114, 67);
            this.txtTenMay.Name = "txtTenMay";
            this.txtTenMay.Size = new System.Drawing.Size(153, 22);
            this.txtTenMay.TabIndex = 15;
            // 
            // txtMaMay
            // 
            this.txtMaMay.Location = new System.Drawing.Point(114, 19);
            this.txtMaMay.Name = "txtMaMay";
            this.txtMaMay.Size = new System.Drawing.Size(153, 22);
            this.txtMaMay.TabIndex = 14;
            // 
            // lbGC
            // 
            this.lbGC.AutoSize = true;
            this.lbGC.Font = new System.Drawing.Font("iCiel Altus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGC.Location = new System.Drawing.Point(973, 63);
            this.lbGC.Name = "lbGC";
            this.lbGC.Size = new System.Drawing.Size(55, 24);
            this.lbGC.TabIndex = 13;
            this.lbGC.Text = "Ghi chú";
            // 
            // lbMaODia
            // 
            this.lbMaODia.AutoSize = true;
            this.lbMaODia.Font = new System.Drawing.Font("iCiel Altus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaODia.Location = new System.Drawing.Point(973, 17);
            this.lbMaODia.Name = "lbMaODia";
            this.lbMaODia.Size = new System.Drawing.Size(66, 24);
            this.lbMaODia.TabIndex = 12;
            this.lbMaODia.Text = "Mã ổ đĩa";
            // 
            // lbMBP
            // 
            this.lbMBP.AutoSize = true;
            this.lbMBP.Font = new System.Drawing.Font("iCiel Altus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMBP.Location = new System.Drawing.Point(622, 150);
            this.lbMBP.Name = "lbMBP";
            this.lbMBP.Size = new System.Drawing.Size(91, 24);
            this.lbMBP.TabIndex = 11;
            this.lbMBP.Text = "Mã bàn phím";
            // 
            // lbMaChuot
            // 
            this.lbMaChuot.AutoSize = true;
            this.lbMaChuot.Font = new System.Drawing.Font("iCiel Altus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaChuot.Location = new System.Drawing.Point(622, 104);
            this.lbMaChuot.Name = "lbMaChuot";
            this.lbMaChuot.Size = new System.Drawing.Size(68, 24);
            this.lbMaChuot.TabIndex = 10;
            this.lbMaChuot.Text = "Mã chuột";
            // 
            // lbMCMH
            // 
            this.lbMCMH.AutoSize = true;
            this.lbMCMH.Font = new System.Drawing.Font("iCiel Altus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMCMH.Location = new System.Drawing.Point(622, 63);
            this.lbMCMH.Name = "lbMCMH";
            this.lbMCMH.Size = new System.Drawing.Size(112, 24);
            this.lbMCMH.TabIndex = 9;
            this.lbMCMH.Text = "Mã cỡ màn hình";
            // 
            // lbMMH
            // 
            this.lbMMH.AutoSize = true;
            this.lbMMH.Font = new System.Drawing.Font("iCiel Altus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMMH.Location = new System.Drawing.Point(622, 17);
            this.lbMMH.Name = "lbMMH";
            this.lbMMH.Size = new System.Drawing.Size(91, 24);
            this.lbMMH.TabIndex = 8;
            this.lbMMH.Text = "Mã màn hình";
            // 
            // lbMTD
            // 
            this.lbMTD.AutoSize = true;
            this.lbMTD.Font = new System.Drawing.Font("iCiel Altus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMTD.Location = new System.Drawing.Point(315, 150);
            this.lbMTD.Name = "lbMTD";
            this.lbMTD.Size = new System.Drawing.Size(75, 24);
            this.lbMTD.TabIndex = 7;
            this.lbMTD.Text = "Mã tốc độ";
            // 
            // lbMRAM
            // 
            this.lbMRAM.AutoSize = true;
            this.lbMRAM.Font = new System.Drawing.Font("iCiel Altus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMRAM.Location = new System.Drawing.Point(315, 104);
            this.lbMRAM.Name = "lbMRAM";
            this.lbMRAM.Size = new System.Drawing.Size(60, 24);
            this.lbMRAM.TabIndex = 6;
            this.lbMRAM.Text = "Mã RAM";
            // 
            // lbMaChip
            // 
            this.lbMaChip.AutoSize = true;
            this.lbMaChip.Font = new System.Drawing.Font("iCiel Altus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaChip.Location = new System.Drawing.Point(316, 63);
            this.lbMaChip.Name = "lbMaChip";
            this.lbMaChip.Size = new System.Drawing.Size(59, 24);
            this.lbMaChip.TabIndex = 5;
            this.lbMaChip.Text = "Mã chíp";
            // 
            // lbMDL
            // 
            this.lbMDL.AutoSize = true;
            this.lbMDL.Font = new System.Drawing.Font("iCiel Altus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMDL.Location = new System.Drawing.Point(316, 17);
            this.lbMDL.Name = "lbMDL";
            this.lbMDL.Size = new System.Drawing.Size(101, 24);
            this.lbMDL.TabIndex = 4;
            this.lbMDL.Text = "Mã dung lượng";
            // 
            // lbMaOCung
            // 
            this.lbMaOCung.AutoSize = true;
            this.lbMaOCung.Font = new System.Drawing.Font("iCiel Altus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaOCung.Location = new System.Drawing.Point(1, 150);
            this.lbMaOCung.Name = "lbMaOCung";
            this.lbMaOCung.Size = new System.Drawing.Size(77, 24);
            this.lbMaOCung.TabIndex = 3;
            this.lbMaOCung.Text = "Mã ổ cứng";
            // 
            // lbMPM
            // 
            this.lbMPM.AutoSize = true;
            this.lbMPM.Font = new System.Drawing.Font("iCiel Altus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMPM.Location = new System.Drawing.Point(1, 104);
            this.lbMPM.Name = "lbMPM";
            this.lbMPM.Size = new System.Drawing.Size(102, 24);
            this.lbMPM.TabIndex = 2;
            this.lbMPM.Text = "Mã phòng máy";
            // 
            // lbTenMay
            // 
            this.lbTenMay.AutoSize = true;
            this.lbTenMay.Font = new System.Drawing.Font("iCiel Altus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenMay.Location = new System.Drawing.Point(1, 63);
            this.lbTenMay.Name = "lbTenMay";
            this.lbTenMay.Size = new System.Drawing.Size(63, 24);
            this.lbTenMay.TabIndex = 1;
            this.lbTenMay.Text = "Tên máy";
            // 
            // lbMaMay
            // 
            this.lbMaMay.AutoSize = true;
            this.lbMaMay.Font = new System.Drawing.Font("iCiel Altus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaMay.Location = new System.Drawing.Point(1, 17);
            this.lbMaMay.Name = "lbMaMay";
            this.lbMaMay.Size = new System.Drawing.Size(60, 24);
            this.lbMaMay.TabIndex = 0;
            this.lbMaMay.Text = "Mã máy";
            // 
            // frmMayTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 514);
            this.Controls.Add(this.gbMayTinh);
            this.Controls.Add(this.dgvMT);
            this.Controls.Add(this.panel1);
            this.Name = "frmMayTinh";
            this.Text = "frmMayTinh";
            this.Load += new System.EventHandler(this.frmMayTinh_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMT)).EndInit();
            this.gbMayTinh.ResumeLayout(false);
            this.gbMayTinh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvMT;
        private System.Windows.Forms.GroupBox gbMayTinh;
        private System.Windows.Forms.Label lbGC;
        private System.Windows.Forms.Label lbMaODia;
        private System.Windows.Forms.Label lbMBP;
        private System.Windows.Forms.Label lbMaChuot;
        private System.Windows.Forms.Label lbMCMH;
        private System.Windows.Forms.Label lbMMH;
        private System.Windows.Forms.Label lbMTD;
        private System.Windows.Forms.Label lbMRAM;
        private System.Windows.Forms.Label lbMaChip;
        private System.Windows.Forms.Label lbMDL;
        private System.Windows.Forms.Label lbMaOCung;
        private System.Windows.Forms.Label lbMPM;
        private System.Windows.Forms.Label lbTenMay;
        private System.Windows.Forms.Label lbMaMay;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtTenMay;
        private System.Windows.Forms.TextBox txtMaMay;
        private System.Windows.Forms.ComboBox cboMOD;
        private System.Windows.Forms.ComboBox cboMBP;
        private System.Windows.Forms.ComboBox cboMaChuot;
        private System.Windows.Forms.ComboBox cboMCMH;
        private System.Windows.Forms.ComboBox cboMMH;
        private System.Windows.Forms.ComboBox cboMTD;
        private System.Windows.Forms.ComboBox cboMaRAM;
        private System.Windows.Forms.ComboBox cboMaChip;
        private System.Windows.Forms.ComboBox cboMDL;
        private System.Windows.Forms.ComboBox cboMOC;
        private System.Windows.Forms.ComboBox cboMPM;
    }
}