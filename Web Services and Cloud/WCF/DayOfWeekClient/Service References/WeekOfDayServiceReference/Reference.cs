﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.WeekOfDayServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WeekOfDayServiceReference.IDayOfWeekService")]
    public interface IDayOfWeekService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDayOfWeekService/GetDayInBulgarian", ReplyAction="http://tempuri.org/IDayOfWeekService/GetDayInBulgarianResponse")]
        string GetDayInBulgarian(System.DateTime inputDateTime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDayOfWeekService/GetDayInBulgarian", ReplyAction="http://tempuri.org/IDayOfWeekService/GetDayInBulgarianResponse")]
        System.Threading.Tasks.Task<string> GetDayInBulgarianAsync(System.DateTime inputDateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDayOfWeekServiceChannel : Client.WeekOfDayServiceReference.IDayOfWeekService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DayOfWeekServiceClient : System.ServiceModel.ClientBase<Client.WeekOfDayServiceReference.IDayOfWeekService>, Client.WeekOfDayServiceReference.IDayOfWeekService {
        
        public DayOfWeekServiceClient() {
        }
        
        public DayOfWeekServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DayOfWeekServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DayOfWeekServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DayOfWeekServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetDayInBulgarian(System.DateTime inputDateTime) {
            return base.Channel.GetDayInBulgarian(inputDateTime);
        }
        
        public System.Threading.Tasks.Task<string> GetDayInBulgarianAsync(System.DateTime inputDateTime) {
            return base.Channel.GetDayInBulgarianAsync(inputDateTime);
        }
    }
}