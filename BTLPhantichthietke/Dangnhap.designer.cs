namespace BTLPhantichthietke
{
    partial class Dangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dangnhap));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tendangnhap = new System.Windows.Forms.TextBox();
            this.btdangnhap = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cbbtucach = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbmaso = new System.Windows.Forms.TextBox();
            this.matkhau = new System.Windows.Forms.TextBox();
            this.lbma = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên đăng nhập :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mật khẩu :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tendangnhap
            // 
            this.tendangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tendangnhap.Location = new System.Drawing.Point(239, 103);
            this.tendangnhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tendangnhap.Multiline = true;
            this.tendangnhap.Name = "tendangnhap";
            this.tendangnhap.Size = new System.Drawing.Size(416, 46);
            this.tendangnhap.TabIndex = 0;
            this.tendangnhap.TextChanged += new System.EventHandler(this.tendangnhap_TextChanged);
            // 
            // btdangnhap
            // 
            this.btdangnhap.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdangnhap.Location = new System.Drawing.Point(320, 345);
            this.btdangnhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btdangnhap.Name = "btdangnhap";
            this.btdangnhap.Size = new System.Drawing.Size(175, 63);
            this.btdangnhap.TabIndex = 2;
            this.btdangnhap.Text = "Đăng nhập";
            this.btdangnhap.UseVisualStyleBackColor = true;
            this.btdangnhap.Click += new System.EventHandler(this.button1_Click);
            this.btdangnhap.Enter += new System.EventHandler(this.btdangnhap_Enter);
            // 
            // btthoat
            // 
            this.btthoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btthoat.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthoat.Location = new System.Drawing.Point(549, 345);
            this.btthoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(175, 63);
            this.btthoat.TabIndex = 4;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.button3_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(16, 359);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(231, 31);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Đăng ký tài khoản";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // cbbtucach
            // 
            this.cbbtucach.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbtucach.FormattingEnabled = true;
            this.cbbtucach.Items.AddRange(new object[] {
            "Khách hàng",
            "Quản Lý",
            "Nhân Viên chăm sóc khách hàng",
            "BP Thống kê"});
            this.cbbtucach.Location = new System.Drawing.Point(341, 212);
            this.cbbtucach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbtucach.Name = "cbbtucach";
            this.cbbtucach.Size = new System.Drawing.Size(313, 32);
            this.cbbtucach.TabIndex = 7;
            this.cbbtucach.Text = "Khách hàng";
            this.cbbtucach.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 212);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(302, 33);
            this.label3.TabIndex = 8;
            this.label3.Text = "Đăng nhập với tư cách là :";
            // 
            // tbmaso
            // 
            this.tbmaso.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmaso.Location = new System.Drawing.Point(239, 256);
            this.tbmaso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbmaso.Multiline = true;
            this.tbmaso.Name = "tbmaso";
            this.tbmaso.Size = new System.Drawing.Size(169, 40);
            this.tbmaso.TabIndex = 9;
            this.tbmaso.TextChanged += new System.EventHandler(this.tbmaso_TextChanged);
            // 
            // matkhau
            // 
            this.matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matkhau.Location = new System.Drawing.Point(239, 158);
            this.matkhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.matkhau.Multiline = true;
            this.matkhau.Name = "matkhau";
            this.matkhau.PasswordChar = '*';
            this.matkhau.Size = new System.Drawing.Size(416, 46);
            this.matkhau.TabIndex = 1;
            // 
            // lbma
            // 
            this.lbma.AutoSize = true;
            this.lbma.BackColor = System.Drawing.Color.Transparent;
            this.lbma.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbma.Location = new System.Drawing.Point(16, 256);
            this.lbma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbma.Name = "lbma";
            this.lbma.Size = new System.Drawing.Size(128, 33);
            this.lbma.TabIndex = 10;
            this.lbma.Text = "Nhập mã :";
            this.lbma.Click += new System.EventHandler(this.label4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(273, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 72);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tripvn";
            // 
            // Dangnhap
            // 
            this.AcceptButton = this.btdangnhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btthoat;
            this.ClientSize = new System.Drawing.Size(779, 444);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbma);
            this.Controls.Add(this.tbmaso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbtucach);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.btdangnhap);
            this.Controls.Add(this.matkhau);
            this.Controls.Add(this.tendangnhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Dangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP";
            this.Load += new System.EventHandler(this.Dangnhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tendangnhap;
        private System.Windows.Forms.Button btdangnhap;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbtucach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbmaso;
        private System.Windows.Forms.TextBox matkhau;
        private System.Windows.Forms.Label lbma;
        private System.Windows.Forms.Label label4;
    }
}

