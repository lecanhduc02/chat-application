namespace Chat_app_Client
{
	partial class AddMember
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
			btnCreate = new Button();
			txtMembers = new TextBox();
			label3 = new Label();
			txtGroupName = new TextBox();
			label2 = new Label();
			label1 = new Label();
			SuspendLayout();
			// 
			// btnCreate
			// 
			btnCreate.BackColor = Color.MediumPurple;
			btnCreate.FlatStyle = FlatStyle.Flat;
			btnCreate.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			btnCreate.ForeColor = Color.Black;
			btnCreate.Location = new Point(21, 193);
			btnCreate.Margin = new Padding(3, 4, 3, 4);
			btnCreate.Name = "btnCreate";
			btnCreate.Size = new Size(194, 36);
			btnCreate.TabIndex = 8;
			btnCreate.Text = "Add";
			btnCreate.UseVisualStyleBackColor = false;
			btnCreate.Click += btnCreate_Click;
			// 
			// txtMembers
			// 
			txtMembers.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			txtMembers.Location = new Point(21, 139);
			txtMembers.Margin = new Padding(3, 4, 3, 4);
			txtMembers.Name = "txtMembers";
			txtMembers.Size = new Size(194, 26);
			txtMembers.TabIndex = 7;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Times New Roman", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
			label3.Location = new Point(21, 115);
			label3.Name = "label3";
			label3.Size = new Size(74, 19);
			label3.TabIndex = 11;
			label3.Text = "Members";
			// 
			// txtGroupName
			// 
			txtGroupName.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			txtGroupName.Location = new Point(21, 81);
			txtGroupName.Margin = new Padding(3, 4, 3, 4);
			txtGroupName.Name = "txtGroupName";
			txtGroupName.Size = new Size(194, 26);
			txtGroupName.TabIndex = 6;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Times New Roman", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
			label2.Location = new Point(21, 57);
			label2.Name = "label2";
			label2.Size = new Size(98, 19);
			label2.TabIndex = 10;
			label2.Text = "Group Name";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label1.ForeColor = Color.Indigo;
			label1.Location = new Point(21, 18);
			label1.Name = "label1";
			label1.Size = new Size(140, 28);
			label1.TabIndex = 9;
			label1.Text = "Add Member";
			label1.Click += label1_Click;
			// 
			// AddMember
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(266, 296);
			Controls.Add(btnCreate);
			Controls.Add(txtMembers);
			Controls.Add(label3);
			Controls.Add(txtGroupName);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "AddMember";
			Text = "AddMember";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnCreate;
		private TextBox txtMembers;
		private Label label3;
		private TextBox txtGroupName;
		private Label label2;
		private Label label1;
	}
}