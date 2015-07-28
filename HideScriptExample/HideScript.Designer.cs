namespace HideScriptExample
{
	partial class HideScript
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
			this.applicationMenu = new System.Windows.Forms.MenuStrip();
			this.appToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hideScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.unhideSciptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel = new System.Windows.Forms.Panel();
			this.tbActions = new System.Windows.Forms.TextBox();
			this.applicationMenu.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// applicationMenu
			// 
			this.applicationMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.connectionToolStripMenuItem});
			this.applicationMenu.Location = new System.Drawing.Point(0, 0);
			this.applicationMenu.Name = "applicationMenu";
			this.applicationMenu.Size = new System.Drawing.Size(292, 24);
			this.applicationMenu.TabIndex = 0;
			this.applicationMenu.Text = "applicationMenu";
			// 
			// appToolStripMenuItem
			// 
			this.appToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listToolStripMenuItem,
            this.saveToolStripMenuItem});
			this.appToolStripMenuItem.Name = "appToolStripMenuItem";
			this.appToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
			this.appToolStripMenuItem.Text = "&App";
			// 
			// listToolStripMenuItem
			// 
			this.listToolStripMenuItem.Name = "listToolStripMenuItem";
			this.listToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
			this.listToolStripMenuItem.Text = "&List...";
			this.listToolStripMenuItem.Click += new System.EventHandler(this.listToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
			this.saveToolStripMenuItem.Text = "&Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hideScriptToolStripMenuItem,
            this.unhideSciptToolStripMenuItem,
            this.reloadToolStripMenuItem});
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.toolsToolStripMenuItem.Text = "&Tools";
			// 
			// hideScriptToolStripMenuItem
			// 
			this.hideScriptToolStripMenuItem.Name = "hideScriptToolStripMenuItem";
			this.hideScriptToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
			this.hideScriptToolStripMenuItem.Text = "&Hide script";
			this.hideScriptToolStripMenuItem.Click += new System.EventHandler(this.hideScriptToolStripMenuItem_Click);
			// 
			// unhideSciptToolStripMenuItem
			// 
			this.unhideSciptToolStripMenuItem.Name = "unhideSciptToolStripMenuItem";
			this.unhideSciptToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
			this.unhideSciptToolStripMenuItem.Text = "&Unhide scipt";
			this.unhideSciptToolStripMenuItem.Click += new System.EventHandler(this.unhideSciptToolStripMenuItem_Click);
			// 
			// reloadToolStripMenuItem
			// 
			this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
			this.reloadToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
			this.reloadToolStripMenuItem.Text = "&Reload hidden";
			this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
			// 
			// connectionToolStripMenuItem
			// 
			this.connectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem});
			this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
			this.connectionToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
			this.connectionToolStripMenuItem.Text = "&Connection";
			// 
			// connectToolStripMenuItem
			// 
			this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
			this.connectToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.connectToolStripMenuItem.Text = "&Connect";
			this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
			// 
			// panel
			// 
			this.panel.AutoScroll = true;
			this.panel.AutoSize = true;
			this.panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel.Controls.Add(this.tbActions);
			this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel.Location = new System.Drawing.Point(0, 24);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(292, 249);
			this.panel.TabIndex = 1;
			// 
			// tbActions
			// 
			this.tbActions.CausesValidation = false;
			this.tbActions.Cursor = System.Windows.Forms.Cursors.No;
			this.tbActions.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbActions.Location = new System.Drawing.Point(0, 0);
			this.tbActions.Multiline = true;
			this.tbActions.Name = "tbActions";
			this.tbActions.ReadOnly = true;
			this.tbActions.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.tbActions.ShortcutsEnabled = false;
			this.tbActions.Size = new System.Drawing.Size(292, 249);
			this.tbActions.TabIndex = 0;
			this.tbActions.TabStop = false;
			this.tbActions.WordWrap = false;
			// 
			// HideScript
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.Add(this.panel);
			this.Controls.Add(this.applicationMenu);
			this.MainMenuStrip = this.applicationMenu;
			this.Name = "HideScript";
			this.Text = "Form1";
			this.applicationMenu.ResumeLayout(false);
			this.applicationMenu.PerformLayout();
			this.panel.ResumeLayout(false);
			this.panel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip applicationMenu;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem hideScriptToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem appToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem unhideSciptToolStripMenuItem;
		private System.Windows.Forms.Panel panel;
		private System.Windows.Forms.TextBox tbActions;

	}
}

