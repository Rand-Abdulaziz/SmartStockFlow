namespace OurSystemCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelBlogin = new System.Windows.Forms.Panel();
            this.checkBoxRemember = new System.Windows.Forms.CheckBox();
            this.Forget = new System.Windows.Forms.Label();
            this.pictureEye = new System.Windows.Forms.PictureBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button8 = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.panelBlogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBlogin
            // 
            this.panelBlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.panelBlogin.Controls.Add(this.checkBoxRemember);
            this.panelBlogin.Controls.Add(this.Forget);
            this.panelBlogin.Controls.Add(this.pictureEye);
            this.panelBlogin.Controls.Add(this.buttonLogin);
            this.panelBlogin.Controls.Add(this.labelWelcome);
            this.panelBlogin.Controls.Add(this.labelPassword);
            this.panelBlogin.Controls.Add(this.labelEmail);
            this.panelBlogin.Controls.Add(this.textBoxPassword);
            this.panelBlogin.Controls.Add(this.textBoxEmail);
            this.panelBlogin.Location = new System.Drawing.Point(656, 48);
            this.panelBlogin.Name = "panelBlogin";
            this.panelBlogin.Size = new System.Drawing.Size(603, 766);
            this.panelBlogin.TabIndex = 0;
            this.panelBlogin.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // checkBoxRemember
            // 
            this.checkBoxRemember.AutoSize = true;
            this.checkBoxRemember.Font = new System.Drawing.Font("Calibri", 6F, System.Drawing.FontStyle.Bold);
            this.checkBoxRemember.Location = new System.Drawing.Point(185, 411);
            this.checkBoxRemember.Name = "checkBoxRemember";
            this.checkBoxRemember.Size = new System.Drawing.Size(144, 27);
            this.checkBoxRemember.TabIndex = 12;
            this.checkBoxRemember.Text = "Remember  me";
            this.checkBoxRemember.UseVisualStyleBackColor = true;
            // 
            // Forget
            // 
            this.Forget.AutoSize = true;
            this.Forget.Font = new System.Drawing.Font("Calibri", 6F, System.Drawing.FontStyle.Bold);
            this.Forget.Location = new System.Drawing.Point(383, 414);
            this.Forget.Name = "Forget";
            this.Forget.Size = new System.Drawing.Size(122, 19);
            this.Forget.TabIndex = 11;
            this.Forget.Text = "Forget password";
            this.Forget.Click += new System.EventHandler(this.Forget_Click);
            // 
            // pictureEye
            // 
            this.pictureEye.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureEye.BackColor = System.Drawing.Color.White;
            this.pictureEye.Image = ((System.Drawing.Image)(resources.GetObject("pictureEye.Image")));
            this.pictureEye.Location = new System.Drawing.Point(491, 370);
            this.pictureEye.Name = "pictureEye";
            this.pictureEye.Size = new System.Drawing.Size(25, 25);
            this.pictureEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureEye.TabIndex = 3;
            this.pictureEye.TabStop = false;
            this.pictureEye.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.buttonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLogin.FlatAppearance.BorderSize = 10;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(241, 449);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(195, 48);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            this.buttonLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonLogin_Paint);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.labelWelcome.Location = new System.Drawing.Point(260, 131);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(142, 39);
            this.labelWelcome.TabIndex = 4;
            this.labelWelcome.Text = "Welcom !";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Calibri", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(170, 338);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(93, 26);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Calibri", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(170, 224);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(59, 26);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "Email";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Location = new System.Drawing.Point(175, 370);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(344, 26);
            this.textBoxPassword.TabIndex = 1;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.Location = new System.Drawing.Point(172, 262);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(344, 26);
            this.textBoxEmail.TabIndex = 0;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.Form1_Load);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(603, 766);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(1228, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(35, 39);
            this.button8.TabIndex = 5;
            this.button8.Text = "X";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(1196, 7);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(30, 27);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 7;
            this.pictureBox7.TabStop = false;
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackColor = System.Drawing.Color.White;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinimize.Location = new System.Drawing.Point(1155, 4);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(35, 39);
            this.buttonMinimize.TabIndex = 8;
            this.buttonMinimize.Text = "-";
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1300, 847);
            this.Controls.Add(this.buttonMinimize);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelBlogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelBlogin.ResumeLayout(false);
            this.panelBlogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBlogin;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox pictureEye;
        private System.Windows.Forms.Label Forget;
        private System.Windows.Forms.CheckBox checkBoxRemember;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button buttonMinimize;
    }
}

