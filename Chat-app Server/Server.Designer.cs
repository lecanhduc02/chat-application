namespace Chat_app_Server
{
    partial class Server
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server));
            label2 = new Label();
            txtIP = new TextBox();
            label3 = new Label();
            txtPort = new TextBox();
            btnStart = new Button();
            rtbDialog = new RichTextBox();
            btnStop = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.InfoText;
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 1;
            label2.Text = "IP Address";
            // 
            // txtIP
            // 
            txtIP.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtIP.Location = new Point(12, 84);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(225, 22);
            txtIP.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(252, 66);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 1;
            label3.Text = "Port";
            // 
            // txtPort
            // 
            txtPort.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPort.Location = new Point(252, 84);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(225, 22);
            txtPort.TabIndex = 2;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.MediumPurple;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnStart.ForeColor = Color.Black;
            btnStart.Location = new Point(12, 162);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(225, 32);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // rtbDialog
            // 
            rtbDialog.Enabled = false;
            rtbDialog.Location = new Point(12, 222);
            rtbDialog.Name = "rtbDialog";
            rtbDialog.Size = new Size(465, 114);
            rtbDialog.TabIndex = 4;
            rtbDialog.Text = "";
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.MidnightBlue;
            btnStop.FlatStyle = FlatStyle.Flat;
            btnStop.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnStop.ForeColor = Color.White;
            btnStop.Location = new Point(252, 162);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(225, 32);
            btnStop.TabIndex = 3;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(12, 112);
            button1.Name = "button1";
            button1.Size = new Size(92, 27);
            button1.TabIndex = 5;
            button1.Text = "Find ID";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(24, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(98, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(144, 23);
            label1.Name = "label1";
            label1.Size = new Size(208, 31);
            label1.TabIndex = 0;
            label1.Text = "Chat App (Sever)";
            // 
            // Server
            // 
            BackColor = SystemColors.Control;
            ClientSize = new Size(489, 356);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(rtbDialog);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(txtPort);
            Controls.Add(label3);
            Controls.Add(txtIP);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Server";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Server";
            Load += Server_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox txtIP;
        private Label label3;
        private TextBox txtPort;
        private Button btnStart;
        private RichTextBox rtbDialog;
        private Button btnStop;
        private Button button1;
        private TextBox tbIPAddress;
        private PictureBox pictureBox1;
        private Label label1;
    }
}