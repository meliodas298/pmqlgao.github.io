namespace DoanCN
{
    partial class ChamCong
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
            this.a = new System.Windows.Forms.Label();
            this.btchamcong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbcv = new System.Windows.Forms.ComboBox();
            this.dgvds = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtthuong = new System.Windows.Forms.TextBox();
            this.txttongluong = new System.Windows.Forms.TextBox();
            this.txtluong = new System.Windows.Forms.TextBox();
            this.txtchamcong = new System.Windows.Forms.TextBox();
            this.txtungtruoc = new System.Windows.Forms.TextBox();
            this.txtnhapthuong = new System.Windows.Forms.TextBox();
            this.txtnhapung = new System.Windows.Forms.TextBox();
            this.btthuongung = new System.Windows.Forms.Button();
            this.btcapnhat = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvds)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.a.Location = new System.Drawing.Point(305, 9);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(238, 31);
            this.a.TabIndex = 18;
            this.a.Text = "Công ty gạo ABC";
            // 
            // btchamcong
            // 
            this.btchamcong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btchamcong.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btchamcong.Location = new System.Drawing.Point(458, 443);
            this.btchamcong.Name = "btchamcong";
            this.btchamcong.Size = new System.Drawing.Size(178, 42);
            this.btchamcong.TabIndex = 1;
            this.btchamcong.Text = "Điểm Danh";
            this.btchamcong.UseVisualStyleBackColor = true;
            this.btchamcong.Click += new System.EventHandler(this.btchamcong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Chức vụ:";
            // 
            // cbcv
            // 
            this.cbcv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcv.FormattingEnabled = true;
            this.cbcv.Location = new System.Drawing.Point(106, 60);
            this.cbcv.Name = "cbcv";
            this.cbcv.Size = new System.Drawing.Size(161, 28);
            this.cbcv.TabIndex = 0;
            this.cbcv.SelectedIndexChanged += new System.EventHandler(this.cbcv_SelectedIndexChanged);
            // 
            // dgvds
            // 
            this.dgvds.BackgroundColor = System.Drawing.Color.White;
            this.dgvds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvds.Location = new System.Drawing.Point(10, 21);
            this.dgvds.Name = "dgvds";
            this.dgvds.Size = new System.Drawing.Size(346, 319);
            this.dgvds.TabIndex = 23;
            this.dgvds.DataSourceChanged += new System.EventHandler(this.dgvds_DataSourceChanged);
            this.dgvds.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvds_CellClick);
            this.dgvds.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvds_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvds);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(458, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 346);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nhân viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Họ tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Số ngày làm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Ứng trước:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Lương/ngày:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Nhập tiền thưởng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Nhập tiền ứng trước:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "Thưởng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 20);
            this.label9.TabIndex = 32;
            this.label9.Text = "Tổng lương:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtten);
            this.groupBox2.Controls.Add(this.txtthuong);
            this.groupBox2.Controls.Add(this.txttongluong);
            this.groupBox2.Controls.Add(this.txtluong);
            this.groupBox2.Controls.Add(this.txtchamcong);
            this.groupBox2.Controls.Add(this.txtungtruoc);
            this.groupBox2.Controls.Add(this.txtnhapthuong);
            this.groupBox2.Controls.Add(this.txtnhapung);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(21, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 403);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chấm công";
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(197, 22);
            this.txtten.Name = "txtten";
            this.txtten.ReadOnly = true;
            this.txtten.Size = new System.Drawing.Size(217, 26);
            this.txtten.TabIndex = 40;
            // 
            // txtthuong
            // 
            this.txtthuong.Location = new System.Drawing.Point(197, 211);
            this.txtthuong.Name = "txtthuong";
            this.txtthuong.ReadOnly = true;
            this.txtthuong.Size = new System.Drawing.Size(217, 26);
            this.txtthuong.TabIndex = 39;
            // 
            // txttongluong
            // 
            this.txttongluong.Location = new System.Drawing.Point(197, 259);
            this.txttongluong.Name = "txttongluong";
            this.txttongluong.ReadOnly = true;
            this.txttongluong.Size = new System.Drawing.Size(217, 26);
            this.txttongluong.TabIndex = 38;
            // 
            // txtluong
            // 
            this.txtluong.Location = new System.Drawing.Point(197, 163);
            this.txtluong.Name = "txtluong";
            this.txtluong.ReadOnly = true;
            this.txtluong.Size = new System.Drawing.Size(217, 26);
            this.txtluong.TabIndex = 37;
            // 
            // txtchamcong
            // 
            this.txtchamcong.Location = new System.Drawing.Point(197, 70);
            this.txtchamcong.Name = "txtchamcong";
            this.txtchamcong.ReadOnly = true;
            this.txtchamcong.Size = new System.Drawing.Size(217, 26);
            this.txtchamcong.TabIndex = 36;
            // 
            // txtungtruoc
            // 
            this.txtungtruoc.Location = new System.Drawing.Point(197, 118);
            this.txtungtruoc.Name = "txtungtruoc";
            this.txtungtruoc.ReadOnly = true;
            this.txtungtruoc.Size = new System.Drawing.Size(217, 26);
            this.txtungtruoc.TabIndex = 35;
            // 
            // txtnhapthuong
            // 
            this.txtnhapthuong.Location = new System.Drawing.Point(197, 358);
            this.txtnhapthuong.Name = "txtnhapthuong";
            this.txtnhapthuong.Size = new System.Drawing.Size(217, 26);
            this.txtnhapthuong.TabIndex = 3;
            this.txtnhapthuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnhapthuong_KeyPress);
            // 
            // txtnhapung
            // 
            this.txtnhapung.Location = new System.Drawing.Point(197, 310);
            this.txtnhapung.Name = "txtnhapung";
            this.txtnhapung.Size = new System.Drawing.Size(217, 26);
            this.txtnhapung.TabIndex = 2;
            this.txtnhapung.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnhapung_KeyPress);
            // 
            // btthuongung
            // 
            this.btthuongung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthuongung.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btthuongung.Location = new System.Drawing.Point(458, 491);
            this.btthuongung.Name = "btthuongung";
            this.btthuongung.Size = new System.Drawing.Size(178, 41);
            this.btthuongung.TabIndex = 4;
            this.btthuongung.Text = "Thưởng/Ứng";
            this.btthuongung.UseVisualStyleBackColor = true;
            this.btthuongung.Click += new System.EventHandler(this.btthuongung_Click);
            // 
            // btcapnhat
            // 
            this.btcapnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcapnhat.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btcapnhat.Location = new System.Drawing.Point(642, 444);
            this.btcapnhat.Name = "btcapnhat";
            this.btcapnhat.Size = new System.Drawing.Size(178, 41);
            this.btcapnhat.TabIndex = 35;
            this.btcapnhat.Text = "Tháng Mới";
            this.btcapnhat.UseVisualStyleBackColor = true;
            this.btcapnhat.Click += new System.EventHandler(this.btcapnhat_Click);
            // 
            // btthoat
            // 
            this.btthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthoat.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btthoat.Location = new System.Drawing.Point(642, 491);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(178, 41);
            this.btthoat.TabIndex = 5;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // ChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoanCN.Properties.Resources.nen3;
            this.ClientSize = new System.Drawing.Size(832, 559);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.btcapnhat);
            this.Controls.Add(this.btthuongung);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbcv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btchamcong);
            this.Controls.Add(this.a);
            this.Name = "ChamCong";
            this.Text = "ChamCong";
            this.Load += new System.EventHandler(this.ChamCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvds)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Button btchamcong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbcv;
        private System.Windows.Forms.DataGridView dgvds;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtthuong;
        private System.Windows.Forms.TextBox txttongluong;
        private System.Windows.Forms.TextBox txtluong;
        private System.Windows.Forms.TextBox txtchamcong;
        private System.Windows.Forms.TextBox txtungtruoc;
        private System.Windows.Forms.TextBox txtnhapthuong;
        private System.Windows.Forms.TextBox txtnhapung;
        private System.Windows.Forms.Button btthuongung;
        private System.Windows.Forms.Button btcapnhat;
        private System.Windows.Forms.Button btthoat;
    }
}