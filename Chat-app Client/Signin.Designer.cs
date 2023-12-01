namespace Chat_app_Client
{
    partial class Signin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signin));
            label3 = new Label();
            textBox1 = new TextBox();
            txtIP = new TextBox();
            label2 = new Label();
            btnSignin = new Button();
            lblSignin = new Label();
            label7 = new Label();
            txtSigninPassword = new TextBox();
            label8 = new Label();
            txtSigninUsername = new TextBox();
            txtSigninIP = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtSigninPort = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(23, 181);
            label3.Name = "label3";
            label3.Size = new Size(96, 23);
            label3.TabIndex = 13;
            label3.Text = "Username";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(23, 211);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(324, 35);
            textBox1.TabIndex = 2;
            // 
            // txtIP
            // 
            txtIP.Enabled = false;
            txtIP.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtIP.Location = new Point(23, 132);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(324, 35);
            txtIP.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(23, 102);
            label2.Name = "label2";
            label2.Size = new Size(89, 23);
            label2.TabIndex = 14;
            label2.Text = "Server IP";
            // 
            // btnSignin
            // 
            btnSignin.BackColor = Color.MediumPurple;
            btnSignin.FlatStyle = FlatStyle.Flat;
            btnSignin.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignin.ForeColor = Color.Black;
            btnSignin.Location = new Point(195, 276);
            btnSignin.Name = "btnSignin";
            btnSignin.Size = new Size(324, 46);
            btnSignin.TabIndex = 4;
            btnSignin.Text = "Sign in";
            btnSignin.UseVisualStyleBackColor = false;
            btnSignin.Click += btnSignin_Click;
            // 
            // lblSignin
            // 
            lblSignin.AutoSize = true;
            lblSignin.Cursor = Cursors.Hand;
            lblSignin.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            lblSignin.ForeColor = SystemColors.MenuHighlight;
            lblSignin.Location = new Point(265, 342);
            lblSignin.Name = "lblSignin";
            lblSignin.Size = new Size(209, 21);
            lblSignin.TabIndex = 5;
            lblSignin.Text = "Already have an account?";
            lblSignin.Click += lblSignin_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(381, 185);
            label7.Name = "label7";
            label7.Size = new Size(93, 23);
            label7.TabIndex = 22;
            label7.Text = "Password";
            // 
            // txtSigninPassword
            // 
            txtSigninPassword.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtSigninPassword.Location = new Point(381, 211);
            txtSigninPassword.Name = "txtSigninPassword";
            txtSigninPassword.Size = new Size(324, 35);
            txtSigninPassword.TabIndex = 3;
            txtSigninPassword.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(23, 181);
            label8.Name = "label8";
            label8.Size = new Size(96, 23);
            label8.TabIndex = 23;
            label8.Text = "Username";
            // 
            // txtSigninUsername
            // 
            txtSigninUsername.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtSigninUsername.Location = new Point(23, 211);
            txtSigninUsername.Name = "txtSigninUsername";
            txtSigninUsername.Size = new Size(324, 35);
            txtSigninUsername.TabIndex = 1;
            // 
            // txtSigninIP
            // 
            txtSigninIP.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtSigninIP.Location = new Point(23, 132);
            txtSigninIP.Name = "txtSigninIP";
            txtSigninIP.Size = new Size(324, 35);
            txtSigninIP.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(23, 102);
            label9.Name = "label9";
            label9.Size = new Size(89, 23);
            label9.TabIndex = 24;
            label9.Text = "Server IP";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.ForeColor = Color.DarkBlue;
            label10.Location = new Point(318, 58);
            label10.Name = "label10";
            label10.Size = new Size(96, 31);
            label10.TabIndex = 19;
            label10.Text = "Sign in";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label11.ForeColor = Color.Purple;
            label11.Location = new Point(229, 15);
            label11.Name = "label11";
            label11.Size = new Size(290, 43);
            label11.TabIndex = 20;
            label11.Text = "Chat App (Client)";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(69, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(98, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(381, 102);
            label1.Name = "label1";
            label1.Size = new Size(107, 23);
            label1.TabIndex = 27;
            label1.Text = "Server Port";
            // 
            // txtSigninPort
            // 
            txtSigninPort.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtSigninPort.Location = new Point(381, 132);
            txtSigninPort.Name = "txtSigninPort";
            txtSigninPort.Size = new Size(324, 35);
            txtSigninPort.TabIndex = 28;
            // 
            // Signin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 429);
            Controls.Add(txtSigninPort);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnSignin);
            Controls.Add(lblSignin);
            Controls.Add(label7);
            Controls.Add(txtSigninPassword);
            Controls.Add(label8);
            Controls.Add(txtSigninUsername);
            Controls.Add(txtSigninIP);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(txtIP);
            Controls.Add(label2);
            Name = "Signin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Signin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private TextBox textBox1;
        private TextBox txtIP;
        private Label label2;
        private Label label1;
        private Button btnSignin;
        private Label lblSignin;
        private Label label7;
        private TextBox txtSigninPassword;
        private Label label8;
        private TextBox txtSigninUsername;
        private TextBox txtSigninIP;
        private Label label9;
        private Label label10;
        private Label label11;
        private PictureBox pictureBox1;
        private TextBox textBox2;
        private TextBox txtSigninPort;
    }
}