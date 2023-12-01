namespace Chat_app_Client
{
    partial class ChatBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatBox));
            tblUser = new DataGridView();
            Online = new DataGridViewButtonColumn();
            tblGroup = new DataGridView();
            Group = new DataGridViewButtonColumn();
            rtbDialog = new RichTextBox();
            btnPicture = new PictureBox();
            txtMessage = new TextBox();
            btnSend = new PictureBox();
            lblWelcome = new Label();
            txtReceiver = new TextBox();
            btnCreateGroup = new Button();
            button1 = new Button();
            btnLike = new PictureBox();
            btnLove = new PictureBox();
            btnLaugh = new PictureBox();
            btnCry = new PictureBox();
            btnDevil = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)tblUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tblGroup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSend).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnLike).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnLove).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnLaugh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCry).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnDevil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tblUser
            // 
            tblUser.AllowUserToAddRows = false;
            tblUser.AllowUserToDeleteRows = false;
            tblUser.BackgroundColor = SystemColors.AppWorkspace;
            tblUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblUser.Columns.AddRange(new DataGridViewColumn[] { Online });
            tblUser.Location = new Point(12, 43);
            tblUser.Name = "tblUser";
            tblUser.ReadOnly = true;
            tblUser.RowTemplate.Height = 25;
            tblUser.Size = new Size(152, 201);
            tblUser.TabIndex = 4;
            tblUser.CellContentClick += tblUser_CellContentClick;
            // 
            // Online
            // 
            Online.HeaderText = "Online";
            Online.Name = "Online";
            Online.ReadOnly = true;
            Online.Resizable = DataGridViewTriState.False;
            Online.SortMode = DataGridViewColumnSortMode.Automatic;
            Online.Width = 120;
            // 
            // tblGroup
            // 
            tblGroup.AllowUserToAddRows = false;
            tblGroup.AllowUserToDeleteRows = false;
            tblGroup.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblGroup.Columns.AddRange(new DataGridViewColumn[] { Group });
            tblGroup.Location = new Point(12, 250);
            tblGroup.Name = "tblGroup";
            tblGroup.ReadOnly = true;
            tblGroup.RowTemplate.Height = 25;
            tblGroup.Size = new Size(152, 201);
            tblGroup.TabIndex = 3;
            tblGroup.CellContentClick += tblGroup_CellContentClick;
            // 
            // Group
            // 
            Group.HeaderText = "Group";
            Group.Name = "Group";
            Group.ReadOnly = true;
            Group.Resizable = DataGridViewTriState.False;
            Group.SortMode = DataGridViewColumnSortMode.Automatic;
            Group.Width = 120;
            // 
            // rtbDialog
            // 
            rtbDialog.BackColor = SystemColors.ScrollBar;
            rtbDialog.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rtbDialog.Location = new Point(179, 43);
            rtbDialog.Name = "rtbDialog";
            rtbDialog.Size = new Size(609, 372);
            rtbDialog.TabIndex = 2;
            rtbDialog.Text = "";
            // 
            // btnPicture
            // 
            btnPicture.Cursor = Cursors.Hand;
            btnPicture.Image = (Image)resources.GetObject("btnPicture.Image");
            btnPicture.Location = new Point(179, 457);
            btnPicture.Name = "btnPicture";
            btnPicture.Size = new Size(30, 30);
            btnPicture.SizeMode = PictureBoxSizeMode.Zoom;
            btnPicture.TabIndex = 2;
            btnPicture.TabStop = false;
            btnPicture.Click += btnPicture_Click;
            // 
            // txtMessage
            // 
            txtMessage.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtMessage.Location = new Point(215, 458);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(538, 29);
            txtMessage.TabIndex = 1;
            txtMessage.KeyPress += txtMessage_KeyPress;
            // 
            // btnSend
            // 
            btnSend.Cursor = Cursors.Hand;
            btnSend.Image = (Image)resources.GetObject("btnSend.Image");
            btnSend.Location = new Point(759, 457);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(30, 30);
            btnSend.SizeMode = PictureBoxSizeMode.Zoom;
            btnSend.TabIndex = 2;
            btnSend.TabStop = false;
            btnSend.Click += btnSend_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblWelcome.ForeColor = Color.DarkMagenta;
            lblWelcome.Location = new Point(179, 9);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(101, 22);
            lblWelcome.TabIndex = 4;
            lblWelcome.Text = "Welcome ...";
            // 
            // txtReceiver
            // 
            txtReceiver.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtReceiver.Location = new Point(379, 6);
            txtReceiver.Name = "txtReceiver";
            txtReceiver.Size = new Size(111, 29);
            txtReceiver.TabIndex = 0;
            // 
            // btnCreateGroup
            // 
            btnCreateGroup.BackColor = Color.MediumSlateBlue;
            btnCreateGroup.FlatStyle = FlatStyle.Flat;
            btnCreateGroup.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateGroup.ForeColor = Color.Black;
            btnCreateGroup.Location = new Point(12, 458);
            btnCreateGroup.Name = "btnCreateGroup";
            btnCreateGroup.Size = new Size(152, 29);
            btnCreateGroup.TabIndex = 5;
            btnCreateGroup.Text = "Create Group";
            btnCreateGroup.UseVisualStyleBackColor = false;
            btnCreateGroup.Click += btnCreateGroup_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumOrchid;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(701, 6);
            button1.Name = "button1";
            button1.Size = new Size(88, 29);
            button1.TabIndex = 29;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnLike
            // 
            btnLike.Cursor = Cursors.Hand;
            btnLike.Image = (Image)resources.GetObject("btnLike.Image");
            btnLike.Location = new Point(179, 421);
            btnLike.Name = "btnLike";
            btnLike.Size = new Size(30, 30);
            btnLike.SizeMode = PictureBoxSizeMode.Zoom;
            btnLike.TabIndex = 2;
            btnLike.TabStop = false;
            btnLike.Click += btnLike_Click;
            // 
            // btnLove
            // 
            btnLove.Cursor = Cursors.Hand;
            btnLove.Image = (Image)resources.GetObject("btnLove.Image");
            btnLove.Location = new Point(229, 421);
            btnLove.Name = "btnLove";
            btnLove.Size = new Size(30, 30);
            btnLove.SizeMode = PictureBoxSizeMode.Zoom;
            btnLove.TabIndex = 2;
            btnLove.TabStop = false;
            btnLove.Click += btnLove_Click;
            // 
            // btnLaugh
            // 
            btnLaugh.Cursor = Cursors.Hand;
            btnLaugh.Image = (Image)resources.GetObject("btnLaugh.Image");
            btnLaugh.Location = new Point(279, 421);
            btnLaugh.Name = "btnLaugh";
            btnLaugh.Size = new Size(30, 30);
            btnLaugh.SizeMode = PictureBoxSizeMode.Zoom;
            btnLaugh.TabIndex = 2;
            btnLaugh.TabStop = false;
            btnLaugh.Click += btnLaugh_Click;
            // 
            // btnCry
            // 
            btnCry.Cursor = Cursors.Hand;
            btnCry.Image = (Image)resources.GetObject("btnCry.Image");
            btnCry.Location = new Point(329, 421);
            btnCry.Name = "btnCry";
            btnCry.Size = new Size(30, 30);
            btnCry.SizeMode = PictureBoxSizeMode.Zoom;
            btnCry.TabIndex = 2;
            btnCry.TabStop = false;
            btnCry.Click += btnCry_Click;
            // 
            // btnDevil
            // 
            btnDevil.Cursor = Cursors.Hand;
            btnDevil.Image = (Image)resources.GetObject("btnDevil.Image");
            btnDevil.Location = new Point(379, 421);
            btnDevil.Name = "btnDevil";
            btnDevil.Size = new Size(30, 30);
            btnDevil.SizeMode = PictureBoxSizeMode.Zoom;
            btnDevil.TabIndex = 2;
            btnDevil.TabStop = false;
            btnDevil.Click += btnDevil_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // ChatBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 497);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(btnCreateGroup);
            Controls.Add(lblWelcome);
            Controls.Add(txtReceiver);
            Controls.Add(txtMessage);
            Controls.Add(btnSend);
            Controls.Add(btnDevil);
            Controls.Add(btnCry);
            Controls.Add(btnLaugh);
            Controls.Add(btnLove);
            Controls.Add(btnLike);
            Controls.Add(btnPicture);
            Controls.Add(rtbDialog);
            Controls.Add(tblGroup);
            Controls.Add(tblUser);
            Name = "ChatBox";
            Text = "ChatBox";
            FormClosing += ChatBox_FormClosing;
            Load += ChatBox_Load;
            ((System.ComponentModel.ISupportInitialize)tblUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)tblGroup).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSend).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnLike).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnLove).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnLaugh).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCry).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnDevil).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tblUser;
        private DataGridView tblGroup;
        private RichTextBox rtbDialog;
        private PictureBox btnPicture;
        private TextBox txtMessage;
        private PictureBox btnSend;
        private Label lblWelcome;
        private TextBox txtReceiver;
        private Button btnCreateGroup;
        private Button button1;
        private DataGridViewButtonColumn Online;
        private DataGridViewButtonColumn Group;
        private PictureBox btnLike;
        private PictureBox btnLove;
        private PictureBox btnLaugh;
        private PictureBox btnCry;
        private PictureBox btnDevil;
        private PictureBox pictureBox1;
    }
}