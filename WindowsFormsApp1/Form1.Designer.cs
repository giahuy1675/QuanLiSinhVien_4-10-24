namespace WindowsFormsApp1
{
    partial class Form1
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
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.cbb_Nganh = new System.Windows.Forms.ComboBox();
            this.txb_Diem = new System.Windows.Forms.TextBox();
            this.txb_HoTen = new System.Windows.Forms.TextBox();
            this.txb_MSSV = new System.Windows.Forms.TextBox();
            this.dtgv_ThongTin = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_TimKiem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ThongTin)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(690, 147);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(98, 43);
            this.btn_Xoa.TabIndex = 32;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(586, 147);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(98, 43);
            this.btn_Sua.TabIndex = 31;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(482, 147);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(98, 43);
            this.btn_Them.TabIndex = 30;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // cbb_Nganh
            // 
            this.cbb_Nganh.FormattingEnabled = true;
            this.cbb_Nganh.Location = new System.Drawing.Point(325, 68);
            this.cbb_Nganh.Name = "cbb_Nganh";
            this.cbb_Nganh.Size = new System.Drawing.Size(197, 24);
            this.cbb_Nganh.TabIndex = 29;
            // 
            // txb_Diem
            // 
            this.txb_Diem.Location = new System.Drawing.Point(68, 156);
            this.txb_Diem.Name = "txb_Diem";
            this.txb_Diem.Size = new System.Drawing.Size(159, 22);
            this.txb_Diem.TabIndex = 28;
            // 
            // txb_HoTen
            // 
            this.txb_HoTen.Location = new System.Drawing.Point(68, 108);
            this.txb_HoTen.Name = "txb_HoTen";
            this.txb_HoTen.Size = new System.Drawing.Size(159, 22);
            this.txb_HoTen.TabIndex = 27;
            // 
            // txb_MSSV
            // 
            this.txb_MSSV.Location = new System.Drawing.Point(68, 65);
            this.txb_MSSV.Name = "txb_MSSV";
            this.txb_MSSV.Size = new System.Drawing.Size(159, 22);
            this.txb_MSSV.TabIndex = 26;
            // 
            // dtgv_ThongTin
            // 
            this.dtgv_ThongTin.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgv_ThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_ThongTin.Location = new System.Drawing.Point(12, 196);
            this.dtgv_ThongTin.Name = "dtgv_ThongTin";
            this.dtgv_ThongTin.RowHeadersWidth = 51;
            this.dtgv_ThongTin.RowTemplate.Height = 24;
            this.dtgv_ThongTin.Size = new System.Drawing.Size(776, 233);
            this.dtgv_ThongTin.TabIndex = 25;
            this.dtgv_ThongTin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_ThongTin_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "MSSV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Điểm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "Khoa";
            // 
            // txb_TimKiem
            // 
            this.txb_TimKiem.Location = new System.Drawing.Point(325, 98);
            this.txb_TimKiem.Name = "txb_TimKiem";
            this.txb_TimKiem.Size = new System.Drawing.Size(197, 22);
            this.txb_TimKiem.TabIndex = 37;
            this.txb_TimKiem.TextChanged += new System.EventHandler(this.txb_TimKiem_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 38;
            this.label5.Text = "Tìm kiếm";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(378, 147);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(98, 43);
            this.btn_TimKiem.TabIndex = 39;
            this.btn_TimKiem.Text = "Tìm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(279, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 29);
            this.label6.TabIndex = 40;
            this.label6.Text = "Quản lí sinh viên";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txb_TimKiem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.cbb_Nganh);
            this.Controls.Add(this.txb_Diem);
            this.Controls.Add(this.txb_HoTen);
            this.Controls.Add(this.txb_MSSV);
            this.Controls.Add(this.dtgv_ThongTin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ThongTin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.ComboBox cbb_Nganh;
        private System.Windows.Forms.TextBox txb_Diem;
        private System.Windows.Forms.TextBox txb_HoTen;
        private System.Windows.Forms.TextBox txb_MSSV;
        private System.Windows.Forms.DataGridView dtgv_ThongTin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_TimKiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Label label6;
    }
}

