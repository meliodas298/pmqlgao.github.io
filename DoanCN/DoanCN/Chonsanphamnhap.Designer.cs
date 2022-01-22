namespace DoanCN
{
    partial class Chonsanphamnhap
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
            this.txttonkho = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bthuy = new System.Windows.Forms.Button();
            this.cbbtensp = new System.Windows.Forms.ComboBox();
            this.cbbmasp = new System.Windows.Forms.ComboBox();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bthoanthanh = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btnhap = new System.Windows.Forms.Button();
            this.txttong = new System.Windows.Forms.TextBox();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.txtdonvi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtgia2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvds = new System.Windows.Forms.DataGridView();
            this.MaSp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Donvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvds)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txttonkho
            // 
            this.txttonkho.Location = new System.Drawing.Point(148, 167);
            this.txttonkho.Name = "txttonkho";
            this.txttonkho.ReadOnly = true;
            this.txttonkho.Size = new System.Drawing.Size(160, 26);
            this.txttonkho.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 46;
            this.label8.Text = "Tồn kho:";
            // 
            // bthuy
            // 
            this.bthuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bthuy.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bthuy.Location = new System.Drawing.Point(193, 520);
            this.bthuy.Name = "bthuy";
            this.bthuy.Size = new System.Drawing.Size(133, 36);
            this.bthuy.TabIndex = 7;
            this.bthuy.Text = "HỦY";
            this.bthuy.UseVisualStyleBackColor = true;
            this.bthuy.Click += new System.EventHandler(this.bthuy_Click);
            // 
            // cbbtensp
            // 
            this.cbbtensp.FormattingEnabled = true;
            this.cbbtensp.Location = new System.Drawing.Point(148, 71);
            this.cbbtensp.Name = "cbbtensp";
            this.cbbtensp.Size = new System.Drawing.Size(160, 28);
            this.cbbtensp.TabIndex = 44;
            this.cbbtensp.SelectedIndexChanged += new System.EventHandler(this.cbbtensp_SelectedIndexChanged);
            // 
            // cbbmasp
            // 
            this.cbbmasp.FormattingEnabled = true;
            this.cbbmasp.Location = new System.Drawing.Point(148, 22);
            this.cbbmasp.Name = "cbbmasp";
            this.cbbmasp.Size = new System.Drawing.Size(160, 28);
            this.cbbmasp.TabIndex = 0;
            this.cbbmasp.SelectedIndexChanged += new System.EventHandler(this.cbbmasp_SelectedIndexChanged);
            // 
            // txtsl
            // 
            this.txtsl.Location = new System.Drawing.Point(148, 261);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(160, 26);
            this.txtsl.TabIndex = 1;
            this.txtsl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsl_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 41;
            this.label7.Text = "Đơn giá";
            // 
            // bthoanthanh
            // 
            this.bthoanthanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bthoanthanh.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bthoanthanh.Location = new System.Drawing.Point(54, 520);
            this.bthoanthanh.Name = "bthoanthanh";
            this.bthoanthanh.Size = new System.Drawing.Size(133, 36);
            this.bthoanthanh.TabIndex = 5;
            this.bthoanthanh.Text = "HOÀN THÀNH";
            this.bthoanthanh.UseVisualStyleBackColor = true;
            this.bthoanthanh.Click += new System.EventHandler(this.bthoanthanh_Click);
            // 
            // btxoa
            // 
            this.btxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoa.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btxoa.Location = new System.Drawing.Point(193, 472);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(133, 42);
            this.btxoa.TabIndex = 6;
            this.btxoa.Text = "XÓA";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btnhap
            // 
            this.btnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhap.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnhap.Location = new System.Drawing.Point(54, 472);
            this.btnhap.Name = "btnhap";
            this.btnhap.Size = new System.Drawing.Size(133, 42);
            this.btnhap.TabIndex = 4;
            this.btnhap.Text = "THÊM";
            this.btnhap.UseVisualStyleBackColor = true;
            this.btnhap.Click += new System.EventHandler(this.btnhap_Click);
            // 
            // txttong
            // 
            this.txttong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttong.Location = new System.Drawing.Point(718, 565);
            this.txttong.Name = "txttong";
            this.txttong.ReadOnly = true;
            this.txttong.Size = new System.Drawing.Size(151, 26);
            this.txttong.TabIndex = 36;
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(148, 214);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.ReadOnly = true;
            this.txtdongia.Size = new System.Drawing.Size(160, 26);
            this.txtdongia.TabIndex = 35;
            // 
            // txtdonvi
            // 
            this.txtdonvi.Location = new System.Drawing.Point(148, 120);
            this.txtdonvi.Name = "txtdonvi";
            this.txtdonvi.ReadOnly = true;
            this.txtdonvi.Size = new System.Drawing.Size(160, 26);
            this.txtdonvi.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Tên sản phẩm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Đơn vị:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Số lượng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(633, 571);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Tổng tiền:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Mã sản phẩm:";
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.a.Location = new System.Drawing.Point(275, 9);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(238, 31);
            this.a.TabIndex = 28;
            this.a.Text = "Công ty gạo ABC";
            this.a.Click += new System.EventHandler(this.a_Click);
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(148, 308);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(160, 26);
            this.txtgia.TabIndex = 2;
            this.txtgia.TextChanged += new System.EventHandler(this.txtgia_TextChanged);
            this.txtgia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtgia_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 20);
            this.label9.TabIndex = 49;
            this.label9.Text = "Giá nhập Kho:";
            // 
            // txtgia2
            // 
            this.txtgia2.Location = new System.Drawing.Point(148, 355);
            this.txtgia2.Name = "txtgia2";
            this.txtgia2.Size = new System.Drawing.Size(160, 26);
            this.txtgia2.TabIndex = 3;
            this.txtgia2.TextChanged += new System.EventHandler(this.txtgia2_TextChanged);
            this.txtgia2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtgia2_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 354);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 20);
            this.label10.TabIndex = 51;
            this.label10.Text = "Giá nhập kho: (%)";
            // 
            // dgvds
            // 
            this.dgvds.BackgroundColor = System.Drawing.Color.White;
            this.dgvds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSp,
            this.SL,
            this.ThanhTien,
            this.Donvi});
            this.dgvds.Location = new System.Drawing.Point(16, 25);
            this.dgvds.Name = "dgvds";
            this.dgvds.Size = new System.Drawing.Size(504, 450);
            this.dgvds.TabIndex = 48;
            // 
            // MaSp
            // 
            this.MaSp.HeaderText = "Mã sản phẩm";
            this.MaSp.Name = "MaSp";
            this.MaSp.Width = 140;
            // 
            // SL
            // 
            this.SL.HeaderText = "Số lượng";
            this.SL.Name = "SL";
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Width = 140;
            // 
            // Donvi
            // 
            this.Donvi.HeaderText = "Đơn vị";
            this.Donvi.Name = "Donvi";
            this.Donvi.Width = 120;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvds);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(332, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 492);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sản phẩm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtgia2);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtgia);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txttonkho);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbbtensp);
            this.groupBox2.Controls.Add(this.cbbmasp);
            this.groupBox2.Controls.Add(this.txtsl);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtdongia);
            this.groupBox2.Controls.Add(this.txtdonvi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 392);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sản phẩm";
            // 
            // Chonsanphamnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoanCN.Properties.Resources.nen3;
            this.ClientSize = new System.Drawing.Size(881, 597);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bthuy);
            this.Controls.Add(this.bthoanthanh);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btnhap);
            this.Controls.Add(this.txttong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.a);
            this.Name = "Chonsanphamnhap";
            this.Text = "Chonsanphamnhap";
            this.Load += new System.EventHandler(this.Chonsanphamnhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvds)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txttonkho;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bthuy;
        private System.Windows.Forms.ComboBox cbbtensp;
        private System.Windows.Forms.ComboBox cbbmasp;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bthoanthanh;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btnhap;
        private System.Windows.Forms.TextBox txttong;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.TextBox txtdonvi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtgia2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvds;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSp;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Donvi;
    }
}