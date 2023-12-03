namespace Chat_app_Client
{
	partial class DeleteGroup
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
			btnDeleteGroup = new Button();
			txtGroupName = new TextBox();
			label2 = new Label();
			label1 = new Label();
			SuspendLayout();
			// 
			// btnDeleteGroup
			// 
			btnDeleteGroup.BackColor = Color.MediumPurple;
			btnDeleteGroup.FlatStyle = FlatStyle.Flat;
			btnDeleteGroup.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			btnDeleteGroup.ForeColor = Color.Black;
			btnDeleteGroup.Location = new Point(27, 117);
			btnDeleteGroup.Margin = new Padding(3, 4, 3, 4);
			btnDeleteGroup.Name = "btnDeleteGroup";
			btnDeleteGroup.Size = new Size(194, 41);
			btnDeleteGroup.TabIndex = 14;
			btnDeleteGroup.Text = "Delete";
			btnDeleteGroup.UseVisualStyleBackColor = false;
			btnDeleteGroup.Click += btnDeleteGroup_Click;
			// 
			// txtGroupName
			// 
			txtGroupName.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			txtGroupName.Location = new Point(27, 72);
			txtGroupName.Margin = new Padding(3, 4, 3, 4);
			txtGroupName.Name = "txtGroupName";
			txtGroupName.Size = new Size(194, 26);
			txtGroupName.TabIndex = 12;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Times New Roman", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
			label2.Location = new Point(27, 48);
			label2.Name = "label2";
			label2.Size = new Size(98, 19);
			label2.TabIndex = 16;
			label2.Text = "Group Name";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label1.ForeColor = Color.Indigo;
			label1.Location = new Point(27, 9);
			label1.Name = "label1";
			label1.Size = new Size(145, 28);
			label1.TabIndex = 15;
			label1.Text = "Delete Group";
			// 
			// DeleteGroup
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(253, 188);
			Controls.Add(btnDeleteGroup);
			Controls.Add(txtGroupName);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "DeleteGroup";
			Text = "DeleteGroup";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnDeleteGroup;
		private TextBox txtGroupName;
		private Label label2;
		private Label label1;
	}
}