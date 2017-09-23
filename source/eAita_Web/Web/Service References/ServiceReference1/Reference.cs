﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Web.Common;
namespace Web.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://sms.neo", ConfigurationName="ServiceReference1.SendMTPortType")]
    public interface SendMTPortType {
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="urn:insertSMS", ReplyAction="urn:insertSMSResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        Web.ServiceReference1.insertSMSResponse insertSMS(Web.ServiceReference1.insertSMSRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:insertSMS", ReplyAction="urn:insertSMSResponse")]
        System.Threading.Tasks.Task<Web.ServiceReference1.insertSMSResponse> insertSMSAsync(Web.ServiceReference1.insertSMSRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="urn:sendFromServiceNumber", ReplyAction="urn:sendFromServiceNumberResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        Web.ServiceReference1.sendFromServiceNumberResponse sendFromServiceNumber(Web.ServiceReference1.sendFromServiceNumberRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:sendFromServiceNumber", ReplyAction="urn:sendFromServiceNumberResponse")]
        System.Threading.Tasks.Task<Web.ServiceReference1.sendFromServiceNumberResponse> sendFromServiceNumberAsync(Web.ServiceReference1.sendFromServiceNumberRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="urn:sendMessage", ReplyAction="urn:sendMessageResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        Web.ServiceReference1.sendMessageResponse sendMessage(Web.ServiceReference1.sendMessageRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:sendMessage", ReplyAction="urn:sendMessageResponse")]
        System.Threading.Tasks.Task<Web.ServiceReference1.sendMessageResponse> sendMessageAsync(Web.ServiceReference1.sendMessageRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="urn:sendFromBrandname", ReplyAction="urn:sendFromBrandnameResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        Web.ServiceReference1.sendFromBrandnameResponse sendFromBrandname(Web.ServiceReference1.sendFromBrandnameRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:sendFromBrandname", ReplyAction="urn:sendFromBrandnameResponse")]
        System.Threading.Tasks.Task<Web.ServiceReference1.sendFromBrandnameResponse> sendFromBrandnameAsync(Web.ServiceReference1.sendFromBrandnameRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="urn:useCard", ReplyAction="urn:useCardResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        Web.ServiceReference1.useCardResponse useCard(Web.ServiceReference1.useCardRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:useCard", ReplyAction="urn:useCardResponse")]
        System.Threading.Tasks.Task<Web.ServiceReference1.useCardResponse> useCardAsync(Web.ServiceReference1.useCardRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="urn:sendSMS", ReplyAction="urn:sendSMSResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        Web.ServiceReference1.sendSMSResponse sendSMS(Web.ServiceReference1.sendSMSRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:sendSMS", ReplyAction="urn:sendSMSResponse")]
        System.Threading.Tasks.Task<Web.ServiceReference1.sendSMSResponse> sendSMSAsync(Web.ServiceReference1.sendSMSRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertSMS", WrapperNamespace="http://sms.neo", IsWrapped=true)]
    public partial class insertSMSRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sms.neo", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string username;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sms.neo", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string password;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sms.neo", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string receiver;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sms.neo", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string content;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sms.neo", Order=4)]
        public int loaisp;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sms.neo", Order=5)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string brandname;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sms.neo", Order=6)]
        public int isUnicode;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sms.neo", Order=7)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string target;
        
        public insertSMSRequest() {
        }
        
        public insertSMSRequest(string username, string password, string receiver, string content, int loaisp, string brandname, int isUnicode, string target) {
            this.username = username;
            this.password = password;
            this.receiver = receiver;
            this.content = content;
            this.loaisp = loaisp;
            this.brandname = brandname;
            this.isUnicode = isUnicode;
            this.target = target;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertSMSResponse", WrapperNamespace="http://sms.neo", IsWrapped=true)]
    public partial class insertSMSResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sms.neo", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string @return;
        
        public insertSMSResponse() {
        }
        
        public insertSMSResponse(string @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sendFromServiceNumber", WrapperNamespace="http://sms.neo", IsWrapped=true)]
    public partial class sendFromServiceNumberRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sms.neo", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string username;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sms.neo", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string password;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sms.neo", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string receiver;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sms.neo", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string content;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sms.neo", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string target;
        
        public sendFromServiceNumberRequest() {
        }
        
        public sendFromServiceNumberRequest(string username, string password, string receiver, string content, string target) {
            this.username = username;
            this.password = password;
            this.receiver = receiver;
            this.content = content;
            this.target = target;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sendFromServiceNumberResponse", WrapperNamespace="http://sms.neo", IsWrapped=true)]
    public partial class sendFromServiceNumberResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sms.neo", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string @return;
        
        public sendFromServiceNumberResponse() {
        }
        
        public sendFromServiceNumberResponse(string @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sendMessage", WrapperNamespace="http://sms.neo", IsWrapped=true)]
    public partial class sendMessageRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sms.neo", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string username;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sms.neo", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string password;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sms.neo", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string receiver;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sms.neo", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string content;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sms.neo", Order=4)]
        public int repeat;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sms.neo", Order=5)]
        public int repeatType;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sms.neo", Order=6)]
        public int loaisp;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sms.neo", Order=7)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string brandname;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sms.neo", Order=8)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string timestart;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sms.neo", Order=9)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string timeend;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sms.neo", Order=10)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string timesend;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sms.neo", Order=11)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string target;
        
        public sendMessageRequest() {
        }
        
        public sendMessageRequest(string username, string password, string receiver, string content, int repeat, int repeatType, int loaisp, string brandname, string timestart, string timeend, string timesend, string target) {
            this.username = username;
            this.password = password;
            this.receiver = receiver;
            this.content = content;
            this.repeat = repeat;
            this.repeatType = repeatType;
            this.loaisp = loaisp;
            this.brandname = brandname;
            this.timestart = timestart;
            this.timeend = timeend;
            this.timesend = timesend;
            this.target = target;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sendMessageResponse", WrapperNamespace="http://sms.neo", IsWrapped=true)]
    public partial class sendMessageResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sms.neo", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string @return;
        
        public sendMessageResponse() {
        }
        
        public sendMessageResponse(string @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sendFromBrandname", WrapperNamespace="http://sms.neo", IsWrapped=true)]
    public partial class sendFromBrandnameRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sms.neo", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string username;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sms.neo", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string password;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sms.neo", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string receiver;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sms.neo", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string brandname;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sms.neo", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string content;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sms.neo", Order=5)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string target;
        
        public sendFromBrandnameRequest() {
        }
        
        public sendFromBrandnameRequest(string username, string password, string receiver, string brandname, string content, string target) {
            this.username = username;
            this.password = password;
            this.receiver = receiver;
            this.brandname = brandname;
            this.content = content;
            this.target = target;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sendFromBrandnameResponse", WrapperNamespace="http://sms.neo", IsWrapped=true)]
    public partial class sendFromBrandnameResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sms.neo", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string @return;
        
        public sendFromBrandnameResponse() {
        }
        
        public sendFromBrandnameResponse(string @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="useCard", WrapperNamespace="http://sms.neo", IsWrapped=true)]
    public partial class useCardRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sms.neo", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string username;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sms.neo", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string password;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sms.neo", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string issure;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sms.neo", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string cardCode;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sms.neo", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string cardSerial;
        
        public useCardRequest() {
        }
        
        public useCardRequest(string username, string password, string issure, string cardCode, string cardSerial) {
            this.username = username;
            this.password = password;
            this.issure = issure;
            this.cardCode = cardCode;
            this.cardSerial = cardSerial;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="useCardResponse", WrapperNamespace="http://sms.neo", IsWrapped=true)]
    public partial class useCardResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sms.neo", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string @return;
        
        public useCardResponse() {
        }
        
        public useCardResponse(string @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sendSMS", WrapperNamespace="http://sms.neo", IsWrapped=true)]
    public partial class sendSMSRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sms.neo", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string username;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sms.neo", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string password;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sms.neo", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string receiver;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sms.neo", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string content;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sms.neo", Order=4)]
        public int loaisp;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sms.neo", Order=5)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string brandname;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sms.neo", Order=6)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string target;
        
        public sendSMSRequest() {
        }
        
        public sendSMSRequest(string username, string password, string receiver, string content, int loaisp, string brandname, string target) {
            this.username = username;
            this.password = password;
            this.receiver = receiver;
            this.content = content;
            this.loaisp = loaisp;
            this.brandname = brandname;
            this.target = target;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sendSMSResponse", WrapperNamespace="http://sms.neo", IsWrapped=true)]
    public partial class sendSMSResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sms.neo", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string @return;
        
        public sendSMSResponse() {
        }
        
        public sendSMSResponse(string @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SendMTPortTypeChannel : Web.ServiceReference1.SendMTPortType, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SendMTPortTypeClient : System.ServiceModel.ClientBase<Web.ServiceReference1.SendMTPortType>, Web.ServiceReference1.SendMTPortType {
        
        public SendMTPortTypeClient() {
        }
        
        public SendMTPortTypeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SendMTPortTypeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SendMTPortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SendMTPortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Web.ServiceReference1.insertSMSResponse Web.ServiceReference1.SendMTPortType.insertSMS(Web.ServiceReference1.insertSMSRequest request) {
            return base.Channel.insertSMS(request);
        }
        
        public string insertSMS(string username, string password, string receiver, string content, int loaisp, string brandname, int isUnicode, string target) {
            Web.ServiceReference1.insertSMSRequest inValue = new Web.ServiceReference1.insertSMSRequest();
            inValue.username = username;
            inValue.password = password;
            inValue.receiver = receiver;
            inValue.content = content;
            inValue.loaisp = loaisp;
            inValue.brandname = brandname;
            inValue.isUnicode = isUnicode;
            inValue.target = target;
            Web.ServiceReference1.insertSMSResponse retVal = ((Web.ServiceReference1.SendMTPortType)(this)).insertSMS(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Web.ServiceReference1.insertSMSResponse> Web.ServiceReference1.SendMTPortType.insertSMSAsync(Web.ServiceReference1.insertSMSRequest request) {
            return base.Channel.insertSMSAsync(request);
        }
        
        public System.Threading.Tasks.Task<Web.ServiceReference1.insertSMSResponse> insertSMSAsync(string username, string password, string receiver, string content, int loaisp, string brandname, int isUnicode, string target) {
            Web.ServiceReference1.insertSMSRequest inValue = new Web.ServiceReference1.insertSMSRequest();
            inValue.username = username;
            inValue.password = password;
            inValue.receiver = receiver;
            inValue.content = content;
            inValue.loaisp = loaisp;
            inValue.brandname = brandname;
            inValue.isUnicode = isUnicode;
            inValue.target = target;
            return ((Web.ServiceReference1.SendMTPortType)(this)).insertSMSAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Web.ServiceReference1.sendFromServiceNumberResponse Web.ServiceReference1.SendMTPortType.sendFromServiceNumber(Web.ServiceReference1.sendFromServiceNumberRequest request) {
            return base.Channel.sendFromServiceNumber(request);
        }
        
        public string sendFromServiceNumber(string username, string password, string receiver, string content, string target) {
            Web.ServiceReference1.sendFromServiceNumberRequest inValue = new Web.ServiceReference1.sendFromServiceNumberRequest();
            inValue.username = username;
            inValue.password = password;
            inValue.receiver = receiver;
            inValue.content = content;
            inValue.target = target;
            Web.ServiceReference1.sendFromServiceNumberResponse retVal = ((Web.ServiceReference1.SendMTPortType)(this)).sendFromServiceNumber(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Web.ServiceReference1.sendFromServiceNumberResponse> Web.ServiceReference1.SendMTPortType.sendFromServiceNumberAsync(Web.ServiceReference1.sendFromServiceNumberRequest request) {
            return base.Channel.sendFromServiceNumberAsync(request);
        }
        
        public System.Threading.Tasks.Task<Web.ServiceReference1.sendFromServiceNumberResponse> sendFromServiceNumberAsync(string username, string password, string receiver, string content, string target) {
            Web.ServiceReference1.sendFromServiceNumberRequest inValue = new Web.ServiceReference1.sendFromServiceNumberRequest();
            inValue.username = username;
            inValue.password = password;
            inValue.receiver = receiver;
            inValue.content = content;
            inValue.target = target;
            return ((Web.ServiceReference1.SendMTPortType)(this)).sendFromServiceNumberAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Web.ServiceReference1.sendMessageResponse Web.ServiceReference1.SendMTPortType.sendMessage(Web.ServiceReference1.sendMessageRequest request) {
            return base.Channel.sendMessage(request);
        }
        
        public string sendMessage(string username, string password, string receiver, string content, int repeat, int repeatType, int loaisp, string brandname, string timestart, string timeend, string timesend, string target) {
            Web.ServiceReference1.sendMessageRequest inValue = new Web.ServiceReference1.sendMessageRequest();
            inValue.username = username;
            inValue.password = password;
            inValue.receiver = receiver;
            inValue.content = content;
            inValue.repeat = repeat;
            inValue.repeatType = repeatType;
            inValue.loaisp = loaisp;
            inValue.brandname = brandname;
            inValue.timestart = timestart;
            inValue.timeend = timeend;
            inValue.timesend = timesend;
            inValue.target = target;
            Web.ServiceReference1.sendMessageResponse retVal = ((Web.ServiceReference1.SendMTPortType)(this)).sendMessage(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Web.ServiceReference1.sendMessageResponse> Web.ServiceReference1.SendMTPortType.sendMessageAsync(Web.ServiceReference1.sendMessageRequest request) {
            return base.Channel.sendMessageAsync(request);
        }
        
        public System.Threading.Tasks.Task<Web.ServiceReference1.sendMessageResponse> sendMessageAsync(string username, string password, string receiver, string content, int repeat, int repeatType, int loaisp, string brandname, string timestart, string timeend, string timesend, string target) {
            Web.ServiceReference1.sendMessageRequest inValue = new Web.ServiceReference1.sendMessageRequest();
            inValue.username = username;
            inValue.password = password;
            inValue.receiver = receiver;
            inValue.content = content;
            inValue.repeat = repeat;
            inValue.repeatType = repeatType;
            inValue.loaisp = loaisp;
            inValue.brandname = brandname;
            inValue.timestart = timestart;
            inValue.timeend = timeend;
            inValue.timesend = timesend;
            inValue.target = target;
            return ((Web.ServiceReference1.SendMTPortType)(this)).sendMessageAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Web.ServiceReference1.sendFromBrandnameResponse Web.ServiceReference1.SendMTPortType.sendFromBrandname(Web.ServiceReference1.sendFromBrandnameRequest request) {
            return base.Channel.sendFromBrandname(request);
        }
        
        public string sendFromBrandname(string username, string password, string receiver, string brandname, string content, string target) {
            Web.ServiceReference1.sendFromBrandnameRequest inValue = new Web.ServiceReference1.sendFromBrandnameRequest();
            inValue.username = username;
            inValue.password = password;
            inValue.receiver = receiver;
            inValue.brandname = brandname;
            inValue.content = content;
            inValue.target = target;
            Web.ServiceReference1.sendFromBrandnameResponse retVal = ((Web.ServiceReference1.SendMTPortType)(this)).sendFromBrandname(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Web.ServiceReference1.sendFromBrandnameResponse> Web.ServiceReference1.SendMTPortType.sendFromBrandnameAsync(Web.ServiceReference1.sendFromBrandnameRequest request) {
            return base.Channel.sendFromBrandnameAsync(request);
        }
        
        public System.Threading.Tasks.Task<Web.ServiceReference1.sendFromBrandnameResponse> sendFromBrandnameAsync(string username, string password, string receiver, string brandname, string content, string target) {
            Web.ServiceReference1.sendFromBrandnameRequest inValue = new Web.ServiceReference1.sendFromBrandnameRequest();
            inValue.username = username;
            inValue.password = password;
            inValue.receiver = receiver;
            inValue.brandname = brandname;
            inValue.content = content;
            inValue.target = target;
            return ((Web.ServiceReference1.SendMTPortType)(this)).sendFromBrandnameAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Web.ServiceReference1.useCardResponse Web.ServiceReference1.SendMTPortType.useCard(Web.ServiceReference1.useCardRequest request) {
            return base.Channel.useCard(request);
        }
        
        public string useCard(string username, string password, string issure, string cardCode, string cardSerial) {
            Web.ServiceReference1.useCardRequest inValue = new Web.ServiceReference1.useCardRequest();
            inValue.username = username;
            inValue.password = password;
            inValue.issure = issure;
            inValue.cardCode = cardCode;
            inValue.cardSerial = cardSerial;
            Web.ServiceReference1.useCardResponse retVal = ((Web.ServiceReference1.SendMTPortType)(this)).useCard(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Web.ServiceReference1.useCardResponse> Web.ServiceReference1.SendMTPortType.useCardAsync(Web.ServiceReference1.useCardRequest request) {
            return base.Channel.useCardAsync(request);
        }
        
        public System.Threading.Tasks.Task<Web.ServiceReference1.useCardResponse> useCardAsync(string username, string password, string issure, string cardCode, string cardSerial) {
            Web.ServiceReference1.useCardRequest inValue = new Web.ServiceReference1.useCardRequest();
            inValue.username = username;
            inValue.password = password;
            inValue.issure = issure;
            inValue.cardCode = cardCode;
            inValue.cardSerial = cardSerial;
            return ((Web.ServiceReference1.SendMTPortType)(this)).useCardAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Web.ServiceReference1.sendSMSResponse Web.ServiceReference1.SendMTPortType.sendSMS(Web.ServiceReference1.sendSMSRequest request) {
            return base.Channel.sendSMS(request);
        }
        
        public string sendSMS(string username, string password, string receiver, string content, int loaisp, string brandname, string target) {
            //username = PasswordHelper.Decrypt(username);
            //password = PasswordHelper.Decrypt(password);
            Web.ServiceReference1.sendSMSRequest inValue = new Web.ServiceReference1.sendSMSRequest();
            inValue.username = username;
            inValue.password = password;
            inValue.receiver = receiver;
            inValue.content = content;
            inValue.loaisp = loaisp;
            inValue.brandname = brandname;
            inValue.target = target;
            Web.ServiceReference1.sendSMSResponse retVal = ((Web.ServiceReference1.SendMTPortType)(this)).sendSMS(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Web.ServiceReference1.sendSMSResponse> Web.ServiceReference1.SendMTPortType.sendSMSAsync(Web.ServiceReference1.sendSMSRequest request) {
            return base.Channel.sendSMSAsync(request);
        }
        
        public System.Threading.Tasks.Task<Web.ServiceReference1.sendSMSResponse> sendSMSAsync(string username, string password, string receiver, string content, int loaisp, string brandname, string target) {
            Web.ServiceReference1.sendSMSRequest inValue = new Web.ServiceReference1.sendSMSRequest();
            inValue.username = username;
            inValue.password = password;
            inValue.receiver = receiver;
            inValue.content = content;
            inValue.loaisp = loaisp;
            inValue.brandname = brandname;
            inValue.target = target;
            return ((Web.ServiceReference1.SendMTPortType)(this)).sendSMSAsync(inValue);
        }
    }
}
