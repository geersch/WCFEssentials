using System;
using System.ServiceModel;

namespace CGeers.Wcf.Server.ApplicationSessionServiceLibrary
{
    // The Namespace property is provided for illustrative purposes    
    [ServiceContract(Namespace = "cgeers.wordpress.com",
        CallbackContract = typeof(IApplicationSessionCallback))]
    public interface IApplicationSession
    {        
        [OperationContract(IsOneWay = true)]
        void RegisterApplication(Guid applicationId, String petName);
        [OperationContract(IsOneWay = true)]
        void UnregisterApplication(Guid applicationId);
        [OperationContract(IsOneWay = true)]
        void RegisterWindow(Guid windowId, Guid applicationId);
        [OperationContract(IsOneWay = true)]
        void UnregisterWindow(Guid windowId);
        // The following two methods are required by the admin tool.
        [OperationContract]
        ClientApplication[] RegisteredClients();   
        [OperationContract(IsOneWay = true)]
        void MulticastMessage(Guid applicationId, MessageUrgency urgency, string message);
    }         
}