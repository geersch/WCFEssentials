using System;
using System.Windows.Forms;
using ServiceReferences.ProxyManagers;
using ServiceReferences.ApplicationSessionService;

namespace AdminTool
{
    public partial class MainForm : Form
    {        
        ClientSessionManager sessionManager = ClientSessionManager.Instance;
        ClientApplication[] clients;

        public MainForm()
        {
            InitializeComponent();
            btnRefresh_Click(null, null);
            cmbUrgency.DataSource = Enum.GetValues(typeof(MessageUrgency));                
        }        

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            sessionManager.Dispose();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lstClients.Items.Clear();
            clients = sessionManager.Proxy.RegisteredClients();
            foreach (ClientApplication client in clients)
            {
                lstClients.Items.Add(String.Format(
                    "{0} ({1})", client.PetName, client.Id.ToString()));
            }
        }

        private void btnSendToAllClients_Click(object sender, EventArgs e)
        {
            MessageUrgency urgency = (MessageUrgency)cmbUrgency.SelectedValue;            
            sessionManager.Proxy.MulticastMessage(Guid.Empty, urgency, txtMessage.Text);
        }

        private void btnSendToSelectedClient_Click(object sender, EventArgs e)
        {
            if (lstClients.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a client.");
                return;
            }

            ClientApplication client = clients[lstClients.SelectedIndex];
            MessageUrgency urgency = (MessageUrgency)cmbUrgency.SelectedValue;
            sessionManager.Proxy.MulticastMessage(client.Id, urgency, txtMessage.Text);
        }        
    }
}
