using System.Runtime.Serialization;
using System.ServiceModel;

namespace CGeers.Wcf.Server.ApplicationSessionServiceLibrary
{
    // This enumeration type is included purely for 
    // illustrative purposes to showcase the EnumMember
    // attribute.
    [DataContract]
    public enum MessageUrgency
    {
        [EnumMember]
        Low,
        [EnumMember]
        Guarded,
        [EnumMember]
        Elevated,
        [EnumMember]
        High,
        [EnumMember]
        Severe
    }    
    
    public interface IApplicationSessionCallback
    {
        [OperationContract(IsOneWay = true)]
        void MessageReceived(MessageUrgency urgency, string message);
    }
}
