﻿using Communicator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat_app_Client
{
	public partial class AddMember : Form
	{
		private TcpClient server;
		public AddMember(TcpClient server)
		{
			this.server = server;
			InitializeComponent();
		}


		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			if (txtGroupName.Text == "" || txtMembers.Text == "")
			{
				MessageBox.Show("Empty Fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			StreamWriter streamWriter = new StreamWriter(server.GetStream());

			Group group = new Group(txtGroupName.Text, txtMembers.Text);
			String jsonString = JsonSerializer.Serialize(group);
			Json json = new Json("ADD_MEMBER", jsonString);

			byte[] jsonUtf8Bytes = JsonSerializer.SerializeToUtf8Bytes(json);
			String S = Encoding.ASCII.GetString(jsonUtf8Bytes, 0, jsonUtf8Bytes.Length);

			streamWriter.WriteLine(S);
			streamWriter.Flush();

			this.Close();
		}
	}
}
