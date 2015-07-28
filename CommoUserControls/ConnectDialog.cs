using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Qlik.Examples.CommonUserControls
{
	public partial class ConnectDialog : Form
	{
		private List<KeyValuePair<string, List<string>>> _settingsList = new List<KeyValuePair<string, List<string>>>();

		private List<string> _connections;
		private List<string> _userList;
	    private List<string> _virtualProxyList;
		private readonly string _filepath = Application.StartupPath + @"\ConnectionList.xml";
		public string ConnectedServer  { get; set; }
		public string ConnectedUser  { get; set; }
	    public string VirtualProxy { get; set; }

	    public ConnectDialog(string server, string user, string virtualProxy)
		{
			InitializeComponent();
			ConnectedServer = server;
			ConnectedUser = user;
		    VirtualProxy = virtualProxy;

			InitializeValues(_filepath);
		}

		private void InitializeValues(string filepath)
		{
			if (ReadConfigurationsSettings(filepath))
			{
				_connections = _settingsList.Select(i => i.Key).Distinct().ToList();
				if (_connections.Count > 0)
				{
					cbServers.DataSource = _connections;
					cbServers.SelectedIndex = 0;

					_userList = FindUserListIfExist(cbServers.SelectedItem.ToString());
					cbUsers.DataSource = _userList;
				    _virtualProxyList = FindVirtualProxyListIfExist(cbServers.SelectedItem.ToString());
				    cbVirtualProxy.DataSource = _virtualProxyList;
				}
			}

			if (ConnectedServer != string.Empty && ConnectedServer != "local")
			{
				var idx = cbServers.Items.IndexOf(ConnectedServer);
				if (idx >= 0)
				{
					cbServers.SelectedIndex = idx;
				}
				else
				{
					_connections.Add(ConnectedServer);
					cbServers.DataSource = _connections;
					cbServers.SelectedIndex = cbServers.Items.IndexOf(ConnectedServer);
				}
			}
			if (ConnectedUser != string.Empty)
			{
				_userList = FindUserListIfExist(cbServers.SelectedItem.ToString());
				cbUsers.DataSource = _userList;

				var idx = cbUsers.Items.IndexOf(ConnectedUser);
				if (idx >= 0)
				{
					cbUsers.SelectedIndex = idx;
				}
				else
				{
					_userList.Add(ConnectedUser);
					cbUsers.DataSource = _userList;
					cbUsers.SelectedIndex = cbUsers.Items.IndexOf(ConnectedUser);
				}
			}
		    if (VirtualProxy != string.Empty)
		    {
		        _virtualProxyList = FindVirtualProxyListIfExist(cbServers.SelectedItem.ToString());
		        cbVirtualProxy.DataSource = _virtualProxyList;

		        var idx = cbVirtualProxy.Items.IndexOf(VirtualProxy);
		        if (idx >= 0)
		        {
		            cbVirtualProxy.SelectedIndex = idx;
		        }
		        else
		        {
		            _virtualProxyList.Add(VirtualProxy);
		            cbVirtualProxy.DataSource = _virtualProxyList;
		            cbVirtualProxy.SelectedIndex = cbVirtualProxy.Items.IndexOf(VirtualProxy);
		        }
		    }

			if (_connections != null && (_connections.Count > 0 && ConnectedServer != "local"))
				rbServer.Checked = true;
			localRadioButton_CheckedChanged(null, null);
			if (_userList != null && _userList.Count > 0)
				rbStaticHeader.Checked = true;

		    cbVirtualProxy.Enabled = checkboxVirtualProxy.Checked;
		}

		private bool ReadConfigurationsSettings(string filepath)
		{
			if (!File.Exists(filepath))
				return false;

		    _settingsList = XmlHandler.LoadFile(filepath).ToList();
			return true;
		}

		private List<string> FindUserListIfExist(string connection)
		{
			var userList = new List<string>();
			foreach (var keyValuePair in _settingsList)
			{
				if (String.Compare(connection, keyValuePair.Key, StringComparison.OrdinalIgnoreCase) == 0)
				{
					userList.Add(keyValuePair.Value.First());
				}
			}
			userList = userList.Where(s => !string.IsNullOrWhiteSpace(s)).Distinct().ToList();
			return userList;
		}

        private List<string> FindVirtualProxyListIfExist(string connection)
		{
			var virtualProxyList = new List<string>();
			foreach (var keyValuePair in _settingsList)
			{
				if (String.Compare(connection, keyValuePair.Key, StringComparison.OrdinalIgnoreCase) == 0)
				{
					virtualProxyList.Add(keyValuePair.Value.Last());
				}
			}
			virtualProxyList = virtualProxyList.Where(s => !string.IsNullOrWhiteSpace(s)).Distinct().ToList();
			return virtualProxyList;
		}

		private void serverCombox_SelectedIndexChanged(object sender, EventArgs e)
		{
			cbUsers.DataSource = null;
			var cbSrv = (ComboBox)sender;
			_userList = FindUserListIfExist(cbSrv.SelectedItem.ToString());
			cbUsers.DataSource = _userList;
            _virtualProxyList = FindVirtualProxyListIfExist(cbSrv.SelectedItem.ToString());
		    cbVirtualProxy.DataSource = _virtualProxyList;
		}

		private void localRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			rbStaticHeader.Enabled = !rbLocal.Checked;
			rbNTLM.Enabled = !rbLocal.Checked;
		    checkboxVirtualProxy.Enabled = !rbLocal.Checked;
            cbVirtualProxy.Enabled = checkboxVirtualProxy.Checked;
		}

		private void btnLoadSettings_Click(object sender, EventArgs e)
		{
			var filepath = string.Empty;
			using (var dialog = new OpenFileDialog())
			{
				if (dialog.ShowDialog(this) == DialogResult.OK)
				{
					filepath = dialog.FileName;
				}
			}

			InitializeValues(filepath);
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			if ((string.IsNullOrEmpty(cbServers.Text) || string.IsNullOrEmpty(cbUsers.Text)) &&
				rbStaticHeader.Checked)
			{
				MessageBox.Show("\"Server\" and \"StaticHeader\" can not be empty!");
				return;
			}

			if (rbLocal.Checked)
			{
				ConnectedServer = "local";
				ConnectedUser = string.Empty;
			}
			if (rbServer.Checked)
			{
				var key = new KeyValuePair<string, List<string>>(cbServers.Text, new List<string>() {cbUsers.Text, cbVirtualProxy.Text });
                
                if (!_settingsList.Any(pair => pair.Key == key.Key && pair.Value.First() == key.Value.First() && pair.Value.Last() == key.Value.Last()))
                    _settingsList.Add(key);
				ConnectedServer = cbServers.Text;

				if (rbStaticHeader.Checked)
				{
					ConnectedUser = cbUsers.Text;
				}
			    if (checkboxVirtualProxy.Checked)
			    {
			        VirtualProxy = cbVirtualProxy.Text;
			    }
			}
			XmlHandler.WriteToXml(_filepath, _settingsList.Select(i => i).Distinct().ToList());

			DialogResult = DialogResult.OK;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
        }

        private void cbVirtualProxy_CheckedChanged(object sender, EventArgs e)
        {
            cbVirtualProxy.Enabled = checkboxVirtualProxy.Checked;
        }
	}
}
