namespace DoanCN
{
    partial class Banle
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
            this.btthanhtoan = new System.Windows.Forms.Button();
            this.cbbsp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.txttonkho = new System.Windows.Forms.TextBox();
            this.txttong = new System.Windows.Forms.TextBox();
            this.txtdonvi = new System.Windows.Forms.Label();
            this.soluong = new System.Windows.Forms.NumericUpDown();
            this.a = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ptanh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.soluong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptanh)).BeginInit();
            this.SuspendLayout();
            // 
            // btthanhtoan
            // 
            this.btthanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthanhtoan.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btthanhtoan.Location = new System.Drawing.Point(473, 319);
            this.btthanhtoan.Name = "btthanhtoan";
            this.btthanhtoan.Size = new System.Drawing.Size(121, 40);
            this.btthanhtoan.TabIndex = 1;
            this.btthanhtoan.Tag = "";
            this.btthanhtoan.Text = "Thanh toán";
            this.btthanhtoan.UseVisualStyleBackColor = true;
            this.btthanhtoan.Click += new System.EventHandler(this.btthanhtoan_Click);
            // 
            // cbbsp
            // 
            this.cbbsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbsp.FormattingEnabled = true;
            this.cbbsp.Location = new System.Drawing.Point(133, 91);
            this.cbbsp.Name = "cbbsp";
            this.cbbsp.Size = new System.Drawing.Size(235, 28);
            this.cbbsp.TabIndex = 4;
            this.cbbsp.SelectedIndexChanged += new System.EventHandler(this.cbbsp_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(41, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sản phẩm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(41, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tồn kho:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(41, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số lượng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(41, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Giá:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(41, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tổng:";
            // 
            // txtgia
            // 
            this.txtgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgia.Location = new System.Drawing.Point(133, 213);
            this.txtgia.Name = "txtgia";
            this.txtgia.ReadOnly = true;
            this.txtgia.Size = new System.Drawing.Size(235, 26);
            this.txtgia.TabIndex = 13;
            // 
            // txttonkho
            // 
            this.txttonkho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttonkho.Location = new System.Drawing.Point(133, 153);
            this.txttonkho.Name = "txttonkho";
            this.txttonkho.ReadOnly = true;
            this.txttonkho.Size = new System.Drawing.Size(235, 26);
            this.txttonkho.TabIndex = 14;
            // 
            // txttong
            // 
            this.txttong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttong.Location = new System.Drawing.Point(133, 333);
            this.txttong.Name = "txttong";
            this.txttong.ReadOnly = true;
            this.txttong.Size = new System.Drawing.Size(235, 26);
            this.txttong.TabIndex = 15;
            // 
            // txtdonvi
            // 
            this.txtdonvi.AutoSize = true;
            this.txtdonvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdonvi.Location = new System.Drawing.Point(469, 273);
            this.txtdonvi.Name = "txtdonvi";
            this.txtdonvi.Size = new System.Drawing.Size(0, 20);
            this.txtdonvi.TabIndex = 16;
            // 
            // soluong
            // 
            this.soluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soluong.Location = new System.Drawing.Point(133, 273);
            this.soluong.Name = "soluong";
            this.soluong.Size = new System.Drawing.Size(235, 26);
            this.soluong.TabIndex = 0;
            this.soluong.Tag = "";
            this.soluong.ValueChanged += new System.EventHandler(this.soluong_ValueChanged);
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.a.Location = new System.Drawing.Point(200, 9);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(238, 31);
            this.a.TabIndex = 19;
            this.a.Text = "Công ty gạo ABC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(559, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Thoát";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // ptanh
            // 
            this.ptanh.Location = new System.Drawing.Point(416, 87);
            this.ptanh.Name = "ptanh";
            this.ptanh.Size = new System.Drawing.Size(178, 177);
            this.ptanh.TabIndex = 10;
            this.ptanh.TabStop = false;
            // 
            // Banle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoanCN.Properties.Resources.nen1;
            this.ClientSize = new System.Drawing.Size(618, 441);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.a);
            this.Controls.Add(this.soluong);
            this.Controls.Add(this.txtdonvi);
            this.Controls.Add(this.txttong);
            this.Controls.Add(this.txttonkho);
            this.Controls.Add(this.txtgia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ptanh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbsp);
            this.Controls.Add(this.btthanhtoan);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Banle";
            this.Text = "Banle";
            this.Load += new System.EventHandler(this.Banle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.soluong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btthanhtoan;
        private System.Windows.Forms.ComboBox cbbsp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox ptanh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.TextBox txttonkho;
        private System.Windows.Forms.TextBox txttong;
        private System.Windows.Forms.Label txtdonvi;
        private System.Windows.Forms.NumericUpDown soluong;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label label6;
    }
}