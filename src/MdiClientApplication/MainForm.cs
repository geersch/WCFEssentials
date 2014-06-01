using System;
using System.Windows.Forms;
using ServiceReferences.ApplicationSessionService;
using ServiceReferences.ProxyManagers;

namespace MdiClientApplication
{
    public partial class MainForm : Form
    {
        ClientSessionManager sessionManager = ClientSessionManager.Instance;
        public Guid ApplicationId { get; set; }

        public MainForm()
        {
            InitializeComponent();
            ApplicationId = Guid.NewGuid();
            // Subscribe to any incoming messages.
            sessionManager.OnMessageReceived +=
                new EventHandler<SessionMessageEventArgs>(OnMessageReceived);                
        }

        private void OnMessageReceived(object sender, SessionMessageEventArgs e)
        {
            MessageBox.Show(String.Format("Urgency: {0}, Message: {1}", 
                e.Urgency, e.Message));
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            sessionManager.Proxy.RegisterApplication(ApplicationId, 
                String.Format("My Mdi Client Application (Started at {0}", DateTime.Now));
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // If you close the application and there are still windows opened
            // they will be unregistered automatically by the UnregisterApplication
            // call.
            sessionManager.Proxy.UnregisterApplication(ApplicationId);
            sessionManager.Dispose();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm.NewForm(this, sessionManager);            
        }        
    }
}
