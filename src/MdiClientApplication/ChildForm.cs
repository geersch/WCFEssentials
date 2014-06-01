using System;
using System.Windows.Forms;
using ServiceReferences.ApplicationSessionService;
using ServiceReferences.ProxyManagers;

namespace MdiClientApplication
{
    public partial class ChildForm : Form
    {
        ClientSessionManager sessionManager;
        public Guid WindowId { get; set; }

        public ChildForm()
        {
            InitializeComponent();
            WindowId = Guid.NewGuid();
        }

        private void ChildForm_Load(object sender, EventArgs e)
        {            
            sessionManager.Proxy.RegisterWindow(WindowId, ((MainForm)this.MdiParent).ApplicationId);
        }

        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            sessionManager.Proxy.UnregisterWindow(WindowId);
        }

        public static void NewForm(Form parent, ClientSessionManager sessionManager)
        {
            ChildForm form = new ChildForm();
            if (parent != null)
            {
                form.MdiParent = parent;
            }
            form.sessionManager = sessionManager;
            form.Show();
        }             
    }
}
