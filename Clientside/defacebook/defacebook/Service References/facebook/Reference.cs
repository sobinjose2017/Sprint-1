﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace defacebook.facebook {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="facebook.IService2")]
    public interface IService2 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/InsertIntoRegister", ReplyAction="http://tempuri.org/IService2/InsertIntoRegisterResponse")]
        string InsertIntoRegister(string fname, string lname, string username, string password, string gender, string dob);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/InsertIntoRegister", ReplyAction="http://tempuri.org/IService2/InsertIntoRegisterResponse")]
        System.Threading.Tasks.Task<string> InsertIntoRegisterAsync(string fname, string lname, string username, string password, string gender, string dob);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService2Channel : defacebook.facebook.IService2, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service2Client : System.ServiceModel.ClientBase<defacebook.facebook.IService2>, defacebook.facebook.IService2 {
        
        public Service2Client() {
        }
        
        public Service2Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service2Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service2Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service2Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string InsertIntoRegister(string fname, string lname, string username, string password, string gender, string dob) {
            return base.Channel.InsertIntoRegister(fname, lname, username, password, gender, dob);
        }
        
        public System.Threading.Tasks.Task<string> InsertIntoRegisterAsync(string fname, string lname, string username, string password, string gender, string dob) {
            return base.Channel.InsertIntoRegisterAsync(fname, lname, username, password, gender, dob);
        }
    }
}
