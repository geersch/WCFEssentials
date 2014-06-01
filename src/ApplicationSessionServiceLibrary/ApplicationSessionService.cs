using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace CGeers.Wcf.Server.ApplicationSessionServiceLibrary
{
    [DataContract]
    public class ClientApplication
    {
        [DataMember]
        public Guid Id { get; set; }
        [DataMember]
        public string PetName { get; set; }
    }

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
        ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class ApplicationSessionService : IApplicationSession
    {
        #region Instance fields

        // The thisLock object is used to protect critical sections 
        // of code. This ensures that only one thread at a time can 
        // enter a critical section of code. Other threads trying to 
        // enter this critical section will have to wait until the 
        // object is released.        
        private static object thisLock = new object();                

        // This dictionary maintains a collection of the connected client applications.
        private Dictionary<ClientApplication, IApplicationSessionCallback> clients =
            new Dictionary<ClientApplication, IApplicationSessionCallback>();

        // This dictionary maintains a collection of opened windows for each client
        // application.
        private Dictionary<Guid, Guid> windows =
            new Dictionary<Guid, Guid>();

        #endregion

        #region IApplicationSession Members

        public void RegisterApplication(Guid applicationId, string petName)
        {
            IApplicationSessionCallback callback =
                OperationContext.Current.GetCallbackChannel<IApplicationSessionCallback>();
            lock (thisLock)
            {
                clients.Add(new ClientApplication { Id = applicationId, PetName = petName }, callback);                
            }            
        }

        public void UnregisterApplication(Guid applicationId)
        {
            // Use a simple LINQ to Objects query to extract the element(s)
            // we want to delete from the clients & windows dictionary.
            lock (thisLock)
            {
                // Remove all the windows belonging to the application.
                Action<Guid> action =
                    delegate(Guid windowId)
                    {
                        windows.Remove(windowId);
                    };                
                List<Guid> windowsList =
                    (from w in windows
                     where w.Value == applicationId
                     select w.Key).ToList();
                windowsList.ForEach(action);

                // Remove the application itself.
                var aQuery = from c in clients.Keys
                             where c.Id == applicationId
                             select c;
                clients.Remove(aQuery.First());
            }
        }

        public void RegisterWindow(Guid windowId, Guid applicationId)
        {
            lock (thisLock)
            {
                windows.Add(windowId, applicationId);
            }            
        }

        public void UnregisterWindow(Guid windowId)
        {
            lock (thisLock)
            {
                windows.Remove(windowId);
            }            
        }                         

        public void MulticastMessage(Guid applicationId, MessageUrgency urgency, string message)
        {
            List<IApplicationSessionCallback> query = null;
            if (applicationId != Guid.Empty)
            {
                query = (from c in clients
                         where c.Key.Id == applicationId
                         select c.Value).ToList();
            }
            else
            {
                query = (from c in clients select c.Value).ToList();
            }

            Action<IApplicationSessionCallback> action =
                delegate(IApplicationSessionCallback callback)
                {
                    callback.MessageReceived(urgency, message);
                };

            query.ForEach(action);                            
        }        

        public ClientApplication[] RegisteredClients()
        {
            return clients.Keys.ToArray<ClientApplication>();            
        }

        #endregion
    }                        
}