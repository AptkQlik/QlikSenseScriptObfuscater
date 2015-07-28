using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Qlik.Engine;
using Qlik.Engine.Communication;
using Qlik.Examples.CommonUserControls;

namespace HideScriptExample
{
	public partial class HideScript : Form
	{
		private IApp ActiveApp { get; set; }
		private static ILocation CurrentLocation { get; set; }
		private string _connectedServer;
		private string _connectedUser;
		private string _virtualProxy;

		public HideScript()
		{
			_connectedServer = string.Empty;
			_connectedUser = string.Empty;
			_virtualProxy = string.Empty;
			ActiveApp = null;
			
			InitializeComponent();
			SetModeToInit();

			Notify("No connection!");
		}

		private void Notify(string message)
		{
			tbActions.Text += message + Environment.NewLine;
		}

		private void SetModeToInit()
		{
			connectToolStripMenuItem.Enabled = true;
			appToolStripMenuItem.Enabled = false;
			toolsToolStripMenuItem.Enabled = false;
		}

		private void SetModeToConencted()
		{
			appToolStripMenuItem.Enabled = true;
			saveToolStripMenuItem.Enabled = false;
		}

		private void SetModeToOpen()
		{
			saveToolStripMenuItem.Enabled = true;
			toolsToolStripMenuItem.Enabled = true;
		}


		#region App
		private void listToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (_connectedServer == string.Empty)
			{
				Notify("Not connected to server, please connect an try again.");
				return;
			}

			using (var openDialog = new OpenApplicationDialog(CurrentLocation))
			{
				if (openDialog.ShowDialog(this) == DialogResult.OK)
				{
					OpenApplication(openDialog.SelectedApplication);
				}
			}
		}

		private void OpenApplication(IAppIdentifier appIdentifier)
		{
			if (ActiveApp != null)
			{
				ActiveApp.Dispose();
			}
			try
			{
				ActiveApp = CurrentLocation.App(appIdentifier, noVersionCheck: true);
				Session.WithApp(appIdentifier, SessionType.Random);
				Notify("Open app: " + appIdentifier.AppName);
				SetModeToOpen();
			}
			catch (MethodInvocationException ex)
			{
				Notify("Could not open " + appIdentifier.AppName + ", error " + ex.Message);
			}
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ActiveApp.DoSave();
			Notify("App saved.");
		}

		#endregion

		#region Tools
		private void hideScriptToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var script = ActiveApp.GetScript();
			if (script != string.Empty)
			{
				NxAppProperties prop = ActiveApp.GetAppProperties().As<NxAppProperties>();

                /**We use Set method from AbstractStructure. For more info about abstractstructure class see
                 * https://help.qlik.com/sense/2.0/en-US/apis/net%20sdk/html/T_Qlik_Engine_AbstractStructure.htm
                 * */

                prop.Set("HiddenScript", script);

				ActiveApp.SetAppProperties(prop);
				ActiveApp.SetScript(string.Empty);
				Notify("Hide script. App need to be saved!");
			}
			else
			{
				Notify("Empty script or script is already hidden!");
			}
		}

		private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				NxAppProperties prop = ActiveApp.GetAppProperties().As<NxAppProperties>();
				ActiveApp.SetScript(prop.Get<string>("HiddenScript"));

				if (ActiveApp.GetScript().Length > 1)
				{
					ActiveApp.DoReload();
					ActiveApp.SetScript(string.Empty);
					Notify("Reloaded hidden script. App need to be saved!");
				}
				else
				{
					Notify("Empty script, did not reload!");
				}
			}

			catch (MethodInvocationException ex)
			{
				Notify("There is no hidden script the can be reloaded! " + ex.Message);
			}
		}

		private void unhideSciptToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var prop = ActiveApp.GetAppProperties().As<NxAppProperties>();
			var hiddenscript = prop.Get<string>("HiddenScript");
			var script = ActiveApp.GetScript();

			if (script == string.Empty && hiddenscript != string.Empty)
			{
				ActiveApp.SetScript(hiddenscript);
				prop.Set("HiddenScript", string.Empty);
				ActiveApp.SetAppProperties(prop);
				Notify("Script is visible. App need to be saved!");
			}
			else
			{
				Notify("Script is not empty and there is no hidden script!");
			}
		}

		#endregion

		#region Connection
		private void connectToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (var dialog = new ConnectDialog(_connectedServer, _connectedUser, _virtualProxy))
			{
				if (dialog.ShowDialog(this) == DialogResult.OK)
				{
					_connectedServer = dialog.ConnectedServer;
					_connectedUser = dialog.ConnectedUser;
					_virtualProxy = dialog.VirtualProxy;
					if (string.IsNullOrEmpty(_connectedServer) || _connectedServer == "local")
					{
						CurrentLocation = Qlik.Engine.Location.FromUri(new Uri("ws://127.0.0.1:4848"));
						CurrentLocation.AsDirectConnectionToPersonalEdition();
					}
					else
					{
						CurrentLocation = Qlik.Engine.Location.FromUri(new Uri(_connectedServer));
						if (string.IsNullOrEmpty(_connectedUser))
						{
							CurrentLocation.AsNtlmUserViaProxy();
						}
						else
						{
							CurrentLocation.AsStaticHeaderUserViaProxy(_connectedUser);
						}
						CurrentLocation.VirtualProxyPath = _virtualProxy;
					}
					Notify("Connected to " + CurrentLocation.ServerUri.OriginalString + CurrentLocation.VirtualProxyPath);
					SetModeToConencted();
				}
			}
		}

		#endregion
	}	
}
