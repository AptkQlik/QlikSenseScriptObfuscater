namespace Qlik.Examples.CommonUserControls
{
	partial class ConnectDialog
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkboxVirtualProxy = new System.Windows.Forms.CheckBox();
            this.btnLoadSettings = new System.Windows.Forms.Button();
            this.cbServers = new System.Windows.Forms.ComboBox();
            this.rbServer = new System.Windows.Forms.RadioButton();
            this.rbLocal = new System.Windows.Forms.RadioButton();
            this.rbStaticHeader = new System.Windows.Forms.RadioButton();
            this.rbNTLM = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbUsers = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbVirtualProxy = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbVirtualProxy);
            this.groupBox1.Controls.Add(this.checkboxVirtualProxy);
            this.groupBox1.Controls.Add(this.btnLoadSettings);
            this.groupBox1.Controls.Add(this.cbServers);
            this.groupBox1.Controls.Add(this.rbServer);
            this.groupBox1.Controls.Add(this.rbLocal);
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 121);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Uri";
            // 
            // checkboxVirtualProxy
            // 
            this.checkboxVirtualProxy.AutoSize = true;
            this.checkboxVirtualProxy.Location = new System.Drawing.Point(10, 78);
            this.checkboxVirtualProxy.Name = "checkboxVirtualProxy";
            this.checkboxVirtualProxy.Size = new System.Drawing.Size(83, 17);
            this.checkboxVirtualProxy.TabIndex = 5;
            this.checkboxVirtualProxy.Text = "Virtual proxy";
            this.checkboxVirtualProxy.UseVisualStyleBackColor = true;
            this.checkboxVirtualProxy.CheckedChanged += new System.EventHandler(this.cbVirtualProxy_CheckedChanged);
            // 
            // btnLoadSettings
            // 
            this.btnLoadSettings.Location = new System.Drawing.Point(453, 44);
            this.btnLoadSettings.Name = "btnLoadSettings";
            this.btnLoadSettings.Size = new System.Drawing.Size(92, 23);
            this.btnLoadSettings.TabIndex = 4;
            this.btnLoadSettings.Text = "Load settings...";
            this.btnLoadSettings.UseVisualStyleBackColor = true;
            this.btnLoadSettings.Click += new System.EventHandler(this.btnLoadSettings_Click);
            // 
            // cbServers
            // 
            this.cbServers.FormattingEnabled = true;
            this.cbServers.Location = new System.Drawing.Point(72, 44);
            this.cbServers.Name = "cbServers";
            this.cbServers.Size = new System.Drawing.Size(375, 21);
            this.cbServers.TabIndex = 3;
            this.cbServers.SelectedIndexChanged += new System.EventHandler(this.serverCombox_SelectedIndexChanged);
            // 
            // rbServer
            // 
            this.rbServer.AutoSize = true;
            this.rbServer.Location = new System.Drawing.Point(10, 44);
            this.rbServer.Name = "rbServer";
            this.rbServer.Size = new System.Drawing.Size(56, 17);
            this.rbServer.TabIndex = 2;
            this.rbServer.TabStop = true;
            this.rbServer.Text = "Server";
            this.rbServer.UseVisualStyleBackColor = true;
            // 
            // rbLocal
            // 
            this.rbLocal.AutoSize = true;
            this.rbLocal.Checked = true;
            this.rbLocal.Location = new System.Drawing.Point(10, 20);
            this.rbLocal.Name = "rbLocal";
            this.rbLocal.Size = new System.Drawing.Size(51, 17);
            this.rbLocal.TabIndex = 1;
            this.rbLocal.TabStop = true;
            this.rbLocal.Text = "Local";
            this.rbLocal.UseVisualStyleBackColor = true;
            this.rbLocal.CheckedChanged += new System.EventHandler(this.localRadioButton_CheckedChanged);
            // 
            // rbStaticHeader
            // 
            this.rbStaticHeader.AutoSize = true;
            this.rbStaticHeader.Location = new System.Drawing.Point(4, 39);
            this.rbStaticHeader.Name = "rbStaticHeader";
            this.rbStaticHeader.Size = new System.Drawing.Size(87, 17);
            this.rbStaticHeader.TabIndex = 5;
            this.rbStaticHeader.TabStop = true;
            this.rbStaticHeader.Text = "StaticHeader";
            this.rbStaticHeader.UseVisualStyleBackColor = true;
            // 
            // rbNTLM
            // 
            this.rbNTLM.AutoSize = true;
            this.rbNTLM.Checked = true;
            this.rbNTLM.Location = new System.Drawing.Point(4, 19);
            this.rbNTLM.Name = "rbNTLM";
            this.rbNTLM.Size = new System.Drawing.Size(55, 17);
            this.rbNTLM.TabIndex = 4;
            this.rbNTLM.TabStop = true;
            this.rbNTLM.Text = "NTLM";
            this.rbNTLM.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbUsers);
            this.groupBox2.Controls.Add(this.rbStaticHeader);
            this.groupBox2.Controls.Add(this.rbNTLM);
            this.groupBox2.Location = new System.Drawing.Point(12, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(551, 83);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User";
            // 
            // cbUsers
            // 
            this.cbUsers.FormattingEnabled = true;
            this.cbUsers.Location = new System.Drawing.Point(94, 38);
            this.cbUsers.Name = "cbUsers";
            this.cbUsers.Size = new System.Drawing.Size(353, 21);
            this.cbUsers.TabIndex = 6;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(398, 242);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(488, 242);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbVirtualProxy
            // 
            this.cbVirtualProxy.FormattingEnabled = true;
            this.cbVirtualProxy.Location = new System.Drawing.Point(94, 78);
            this.cbVirtualProxy.Name = "cbVirtualProxy";
            this.cbVirtualProxy.Size = new System.Drawing.Size(353, 21);
            this.cbVirtualProxy.TabIndex = 7;
            // 
            // ConnectDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 284);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConnectDialog";
            this.Text = "ConnectDialog";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cbServers;
		private System.Windows.Forms.RadioButton rbServer;
		private System.Windows.Forms.RadioButton rbLocal;
		private System.Windows.Forms.RadioButton rbStaticHeader;
		private System.Windows.Forms.RadioButton rbNTLM;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox cbUsers;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnLoadSettings;
        private System.Windows.Forms.CheckBox checkboxVirtualProxy;
        private System.Windows.Forms.ComboBox cbVirtualProxy;
	}
}