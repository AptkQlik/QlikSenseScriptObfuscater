using System;
using System.Windows.Forms;

namespace Qlik.Examples.CommonUserControls
{
	public partial class LoggingDialog : Form
	{
	    public string LogFile { get; set; }
	    public bool Append { get; set; }

		public LoggingDialog()
		{
			InitializeComponent();
			tbFileName.Text = @"c:\SDKlog.txt";
		    AcceptButton = btnOk;
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			LogFile = tbFileName.Text;
			Append = cbAppend.Checked;

			DialogResult = DialogResult.OK;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}
	}
}
