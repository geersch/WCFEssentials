using System;
using System.ServiceModel;
using ServiceReferences.ApplicationSessionService;

namespace ServiceReferences.ProxyManagers
{
    public class SessionMessageEventArgs : EventArgs
    {
        public MessageUrgency Urgency { get; set; }
        public string Message { get; set; }
    }

    public class ClientSessionManager : IDisposable, IApplicationSessionCallback
    {                        
        // Expose the proxy.
        public ApplicationSessionClient Proxy { get; set; }

        public event EventHandler<SessionMessageEventArgs> OnMessageReceived;                    

        #region Singleton Pattern

        // Static members are lazily initialized.
        // .NET guarantees thread safety for static initialization.
        private static readonly ClientSessionManager instance = new ClientSessionManager();

        // Make the constructor private to hide it. 
        // This class adheres to the singleton pattern.
        private ClientSessionManager()
        {
            InstanceContext site = new InstanceContext(this);
            Proxy = new ApplicationSessionClient(site);
        }

        // Return the single instance of the ClientSessionManager type.
        public static ClientSessionManager Instance
        {
            get
            {
                return instance;
            }
        }   

        #endregion     

        #region IDisposable Members

        private bool disposed;

        private void Dispose(bool disposing)
        {            
            if (!this.disposed)
            {         
                if (disposing)
                {
                    // Clean up any managed resources here.
                    // ...                    
                }

                // Clean up any unmanged resources here.
                Proxy.Close();                                        
                
                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);            
        }

        ~ClientSessionManager()
        {
            Dispose(false);
        }

        #endregion

        #region IApplicationSessionCallback Members

        public void MessageReceived(MessageUrgency urgency, string message)
        {
            // Forward the message to anyone who subscribed to the OnMessageReceived 
            // event.
            if (OnMessageReceived != null)
            {                
                OnMessageReceived(this, 
                    new SessionMessageEventArgs { Urgency = urgency, Message = message });
            }
        }

        #endregion
    }
}
