namespace DoanCN
{
    partial class GDQuanLi
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvds = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbnv = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbthang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbnam = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvds)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.a.Location = new System.Drawing.Point(254, 9);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(238, 31);
            this.a.TabIndex = 2;
            this.a.Text = "Công ty gạo ABC";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::DoanCN.Properties.Resources.nen1;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(590, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 72);
            this.button1.TabIndex = 3;
            this.button1.Text = "Chấm Công";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::DoanCN.Properties.Resources.nen2;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button2.Location = new System.Drawing.Point(590, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 69);
            this.button2.TabIndex = 4;
            this.button2.Text = "     Quản Lý       Sản Phẩm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::DoanCN.Properties.Resources.nen3;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button3.Location = new System.Drawing.Point(590, 270);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 71);
            this.button3.TabIndex = 5;
            this.button3.Text = "    Quản lý       nhân viên";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvds
            // 
            this.dgvds.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvds.Location = new System.Drawing.Point(6, 25);
            this.dgvds.Name = "dgvds";
            this.dgvds.Size = new System.Drawing.Size(549, 304);
            this.dgvds.TabIndex = 6;
            this.dgvds.DataSourceChanged += new System.EventHandler(this.dgvds_DataSourceChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nhân viên:";
            // 
            // cbnv
            // 
            this.cbnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbnv.FormattingEnabled = true;
            this.cbnv.Location = new System.Drawing.Point(128, 72);
            this.cbnv.Name = "cbnv";
            this.cbnv.Size = new System.Drawing.Size(178, 28);
            this.cbnv.TabIndex = 0;
            this.cbnv.SelectedIndexChanged += new System.EventHandler(this.cbnv_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(324, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tháng:";
            // 
            // cbthang
            // 
            this.cbthang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbthang.FormattingEnabled = true;
            this.cbthang.Location = new System.Drawing.Point(388, 72);
            this.cbthang.Name = "cbthang";
            this.cbthang.Size = new System.Drawing.Size(66, 28);
            this.cbthang.TabIndex = 1;
            this.cbthang.SelectedIndexChanged += new System.EventHandler(this.cbthang_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(476, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Năm:";
            // 
            // cbnam
            // 
            this.cbnam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbnam.FormattingEnabled = true;
            this.cbnam.Location = new System.Drawing.Point(528, 72);
            this.cbnam.Name = "cbnam";
            this.cbnam.Size = new System.Drawing.Size(72, 28);
            this.cbnam.TabIndex = 2;
            this.cbnam.SelectedIndexChanged += new System.EventHandler(this.cbnam_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.dgvds);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 345);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hóa đơn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(693, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Thoát";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // GDQuanLi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoanCN.Properties.Resources.nenql;
            this.ClientSize = new System.Drawing.Size(748, 460);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbnam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbthang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbnv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.a);
            this.Name = "GDQuanLi";
            this.Text = "GDQuanLi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GDQuanLi_FormClosing);
            this.Load += new System.EventHandler(this.GDQuanLi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvds)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbnv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbthang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbnam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
    }
}