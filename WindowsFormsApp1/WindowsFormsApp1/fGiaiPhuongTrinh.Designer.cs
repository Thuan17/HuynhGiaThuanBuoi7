namespace WindowsFormsApp1
{
    partial class fGiaiPhuongTrinh
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
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_giai = new System.Windows.Forms.Button();
            this.txt_kq = new System.Windows.Forms.TextBox();
            this.txt_c = new System.Windows.Forms.TextBox();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblc = new System.Windows.Forms.Label();
            this.lblb = new System.Windows.Forms.Label();
            this.lbla = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radptb2 = new System.Windows.Forms.RadioButton();
            this.radptb1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(530, 412);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(100, 70);
            this.btn_thoat.TabIndex = 23;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            // 
            // btn_giai
            // 
            this.btn_giai.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_giai.Location = new System.Drawing.Point(530, 325);
            this.btn_giai.Margin = new System.Windows.Forms.Padding(4);
            this.btn_giai.Name = "btn_giai";
            this.btn_giai.Size = new System.Drawing.Size(100, 70);
            this.btn_giai.TabIndex = 22;
            this.btn_giai.Text = "Giải";
            this.btn_giai.UseVisualStyleBackColor = true;
            this.btn_giai.Click += new System.EventHandler(this.btn_giai_Click);
            // 
            // txt_kq
            // 
            this.txt_kq.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kq.Location = new System.Drawing.Point(221, 515);
            this.txt_kq.Margin = new System.Windows.Forms.Padding(4);
            this.txt_kq.Name = "txt_kq";
            this.txt_kq.Size = new System.Drawing.Size(404, 98);
            this.txt_kq.TabIndex = 21;
            // 
            // txt_c
            // 
            this.txt_c.Enabled = false;
            this.txt_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_c.Location = new System.Drawing.Point(221, 452);
            this.txt_c.Margin = new System.Windows.Forms.Padding(4);
            this.txt_c.Name = "txt_c";
            this.txt_c.Size = new System.Drawing.Size(288, 29);
            this.txt_c.TabIndex = 20;
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(221, 392);
            this.txt_b.Margin = new System.Windows.Forms.Padding(4);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(288, 22);
            this.txt_b.TabIndex = 19;
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(221, 325);
            this.txt_a.Margin = new System.Windows.Forms.Padding(4);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(288, 22);
            this.txt_a.TabIndex = 18;
            this.txt_a.TextChanged += new System.EventHandler(this.txt_a_TextChanged);
            this.txt_a.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_a_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(140, 515);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Kết quả";
            // 
            // lblc
            // 
            this.lblc.AutoSize = true;
            this.lblc.Enabled = false;
            this.lblc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblc.Location = new System.Drawing.Point(140, 460);
            this.lblc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblc.Name = "lblc";
            this.lblc.Size = new System.Drawing.Size(71, 24);
            this.lblc.TabIndex = 16;
            this.lblc.Text = "Nhập c";
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblb.Location = new System.Drawing.Point(140, 394);
            this.lblb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(72, 24);
            this.lblb.TabIndex = 15;
            this.lblb.Text = "Nhập b";
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbla.Location = new System.Drawing.Point(140, 328);
            this.lbla.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(71, 24);
            this.lbla.TabIndex = 14;
            this.lbla.Text = "Nhập a";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radptb2);
            this.groupBox1.Controls.Add(this.radptb1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(144, 162);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(487, 124);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bạn vui lòng chọn";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radptb2
            // 
            this.radptb2.AutoSize = true;
            this.radptb2.Location = new System.Drawing.Point(23, 74);
            this.radptb2.Margin = new System.Windows.Forms.Padding(4);
            this.radptb2.Name = "radptb2";
            this.radptb2.Size = new System.Drawing.Size(205, 28);
            this.radptb2.TabIndex = 1;
            this.radptb2.TabStop = true;
            this.radptb2.Text = "Phương trình bậc hai";
            this.radptb2.UseVisualStyleBackColor = true;
            // 
            // radptb1
            // 
            this.radptb1.AutoSize = true;
            this.radptb1.Location = new System.Drawing.Point(23, 39);
            this.radptb1.Margin = new System.Windows.Forms.Padding(4);
            this.radptb1.Name = "radptb1";
            this.radptb1.Size = new System.Drawing.Size(210, 28);
            this.radptb1.TabIndex = 0;
            this.radptb1.TabStop = true;
            this.radptb1.Text = "Phương trình bật nhất";
            this.radptb1.UseVisualStyleBackColor = true;
            this.radptb1.CheckedChanged += new System.EventHandler(this.radptb1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(193, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 39);
            this.label1.TabIndex = 12;
            this.label1.Text = "GIẢI PHƯƠNG TRÌNH";
            // 
            // fGiaiPhuongTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 678);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_giai);
            this.Controls.Add(this.txt_kq);
            this.Controls.Add(this.txt_c);
            this.Controls.Add(this.txt_b);
            this.Controls.Add(this.txt_a);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblc);
            this.Controls.Add(this.lblb);
            this.Controls.Add(this.lbla);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "fGiaiPhuongTrinh";
            this.Text = "fGiaiPhuongTrinh";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fGiaiPhuongTrinh_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_giai;
        private System.Windows.Forms.TextBox txt_kq;
        private System.Windows.Forms.TextBox txt_c;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblc;
        private System.Windows.Forms.Label lblb;
        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radptb2;
        private System.Windows.Forms.RadioButton radptb1;
        private System.Windows.Forms.Label label1;
    }
}