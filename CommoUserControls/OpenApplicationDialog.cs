using System;
using System.Linq;
using System.Windows.Forms;
using Qlik.Engine;

namespace Qlik.Examples.CommonUserControls
{
	public partial class OpenApplicationDialog : Form
	{
	    public IAppIdentifier SelectedApplication { get; set; }

		public OpenApplicationDialog(ILocation currentLocation)
		{
		    InitializeComponent();
            try
            {
				availableApplications.DataSource = currentLocation.GetAppIdentifiers(noVersionCheck: true).ToArray();
                availableApplications.DisplayMember = "AppName";
                availableApplications.ClearSelected();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
		}

		private void OpenButtonClick(object sender, EventArgs e)
		{
            SelectedApplication = availableApplications.SelectedValue as IAppIdentifier;
			DialogResult = SelectedApplication != null ? DialogResult.OK : DialogResult.Cancel;
		}

		private void availableApplications_DoubleClick(object sender, EventArgs e)
		{
			SelectedApplication = availableApplications.SelectedValue as IAppIdentifier;
			DialogResult = SelectedApplication != null ? DialogResult.OK : DialogResult.Cancel;
		}
	}
}
