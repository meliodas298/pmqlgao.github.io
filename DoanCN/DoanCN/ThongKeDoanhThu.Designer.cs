namespace DoanCN
{
    partial class ThongKeDoanhThu
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
            this.treeds = new System.Windows.Forms.TreeView();
            this.dgvds = new System.Windows.Forms.DataGridView();
            this.btin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbnam = new System.Windows.Forms.ComboBox();
            this.cbbthang = new System.Windows.Forms.ComboBox();
            this.cbloaihd = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbtong = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.abc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvds)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeds
            // 
            this.treeds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeds.Location = new System.Drawing.Point(6, 25);
            this.treeds.Name = "treeds";
            this.treeds.Size = new System.Drawing.Size(199, 433);
            this.treeds.TabIndex = 0;
            this.treeds.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeds_AfterSelect);
            // 
            // dgvds
            // 
            this.dgvds.BackgroundColor = System.Drawing.Color.White;
            this.dgvds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvds.Location = new System.Drawing.Point(6, 25);
            this.dgvds.Name = "dgvds";
            this.dgvds.Size = new System.Drawing.Size(749, 343);
            this.dgvds.TabIndex = 14;
            this.dgvds.DataSourceChanged += new System.EventHandler(this.dgvds_DataSourceChanged);
            // 
            // btin
            // 
            this.btin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btin.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btin.Location = new System.Drawing.Point(480, 549);
            this.btin.Name = "btin";
            this.btin.Size = new System.Drawing.Size(195, 63);
            this.btin.TabIndex = 3;
            this.btin.Text = "In Hóa Đơn";
            this.btin.UseVisualStyleBackColor = true;
            this.btin.Click += new System.EventHandler(this.btin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(564, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Năm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tháng:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbnam);
            this.groupBox1.Controls.Add(this.cbbthang);
            this.groupBox1.Controls.Add(this.cbloaihd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(229, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(761, 89);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin in";
            // 
            // cbbnam
            // 
            this.cbbnam.FormattingEnabled = true;
            this.cbbnam.Location = new System.Drawing.Point(616, 30);
            this.cbbnam.Name = "cbbnam";
            this.cbbnam.Size = new System.Drawing.Size(117, 28);
            this.cbbnam.TabIndex = 2;
            // 
            // cbbthang
            // 
            this.cbbthang.FormattingEnabled = true;
            this.cbbthang.Location = new System.Drawing.Point(406, 30);
            this.cbbthang.Name = "cbbthang";
            this.cbbthang.Size = new System.Drawing.Size(117, 28);
            this.cbbthang.TabIndex = 1;
            // 
            // cbloaihd
            // 
            this.cbloaihd.FormattingEnabled = true;
            this.cbloaihd.Location = new System.Drawing.Point(136, 30);
            this.cbloaihd.Name = "cbloaihd";
            this.cbloaihd.Size = new System.Drawing.Size(168, 28);
            this.cbloaihd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Loại Hóa Đơn";
            // 
            // lbtong
            // 
            this.lbtong.AutoSize = true;
            this.lbtong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtong.Location = new System.Drawing.Point(225, 574);
            this.lbtong.Name = "lbtong";
            this.lbtong.Size = new System.Drawing.Size(96, 20);
            this.lbtong.TabIndex = 26;
            this.lbtong.Text = "Tổng tiền : 0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvds);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(229, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(761, 374);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin hóa đơn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(947, 587);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Thoát";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.treeds);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 74);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(211, 468);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách hóa đơn";
            // 
            // abc
            // 
            this.abc.AutoSize = true;
            this.abc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abc.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.abc.Location = new System.Drawing.Point(375, 9);
            this.abc.Name = "abc";
            this.abc.Size = new System.Drawing.Size(238, 31);
            this.abc.TabIndex = 3;
            this.abc.Text = "Công ty gạo ABC";
            // 
            // ThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoanCN.Properties.Resources.nen5;
            this.ClientSize = new System.Drawing.Size(1009, 624);
            this.Controls.Add(this.abc);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbtong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btin);
            this.Name = "ThongKeDoanhThu";
            this.Text = "ThongKeDoanhThu";
            this.Load += new System.EventHandler(this.ThongKeDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvds)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeds;
        private System.Windows.Forms.DataGridView dgvds;
        private System.Windows.Forms.Button btin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbnam;
        private System.Windows.Forms.ComboBox cbbthang;
        private System.Windows.Forms.ComboBox cbloaihd;
        private System.Windows.Forms.Label lbtong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label abc;
    }
}