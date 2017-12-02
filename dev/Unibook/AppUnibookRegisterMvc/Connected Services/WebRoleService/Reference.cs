﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     //
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebRoleService
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RoleDto", Namespace="http://tempuri.org/")]
    public partial class RoleDto : object
    {
        
        private short RoleIdField;
        
        private string NameField;
        
        private bool DeletedField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public short RoleId
        {
            get
            {
                return this.RoleIdField;
            }
            set
            {
                this.RoleIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public bool Deleted
        {
            get
            {
                return this.DeletedField;
            }
            set
            {
                this.DeletedField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WebRoleService.WebRoleServiceSoap")]
    public interface WebRoleServiceSoap
    {
        // CODEGEN: Generating message contract since element name GetResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/Get", ReplyAction = "*")]
        WebRoleService.GetResponse Get(WebRoleService.GetRequest request);

        // CODEGEN: Generating message contract since element name GetResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/Get", ReplyAction = "*")]
        WebRoleService.GetResponse GetId(WebRoleService.GetRequest request);

        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Insert", ReplyAction="*")]
        System.Threading.Tasks.Task<WebRoleService.InsertResponse> InsertAsync(WebRoleService.InsertRequest request);

        //[System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/Delete", ReplyAction = "*")]
        //void Delete(short id);

        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Update", ReplyAction="*")]
        System.Threading.Tasks.Task<WebRoleService.UpdateResponse> UpdateAsync(WebRoleService.UpdateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Delete", ReplyAction="*")]
        System.Threading.Tasks.Task DeleteAsync(short id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Get", ReplyAction="*")]
        System.Threading.Tasks.Task<WebRoleService.GetResponse> GetAsync(WebRoleService.GetRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAll", ReplyAction="*")]
        System.Threading.Tasks.Task<WebRoleService.GetAllResponse> GetAllAsync(WebRoleService.GetAllRequest request);

        // CODEGEN: Generating message contract since element name roleDto from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/Insert", ReplyAction = "*")]
        WebRoleService.InsertResponse Insert(WebRoleService.InsertRequest request);

        // CODEGEN: Generating message contract since element name roleDto from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/Update", ReplyAction = "*")]
        WebRoleService.UpdateResponse Update(WebRoleService.UpdateRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Insert", Namespace="http://tempuri.org/", Order=0)]
        public WebRoleService.InsertRequestBody Body;
        
        public InsertRequest()
        {
        }
        
        public InsertRequest(WebRoleService.InsertRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InsertRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WebRoleService.RoleDto roleDto;
        
        public InsertRequestBody()
        {
        }
        
        public InsertRequestBody(WebRoleService.RoleDto roleDto)
        {
            this.roleDto = roleDto;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebRoleService.InsertResponseBody Body;
        
        public InsertResponse()
        {
        }
        
        public InsertResponse(WebRoleService.InsertResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class InsertResponseBody
    {
        
        public InsertResponseBody()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Update", Namespace="http://tempuri.org/", Order=0)]
        public WebRoleService.UpdateRequestBody Body;
        
        public UpdateRequest()
        {
        }
        
        public UpdateRequest(WebRoleService.UpdateRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdateRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WebRoleService.RoleDto roleDto;
        
        public UpdateRequestBody()
        {
        }
        
        public UpdateRequestBody(WebRoleService.RoleDto roleDto)
        {
            this.roleDto = roleDto;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebRoleService.UpdateResponseBody Body;
        
        public UpdateResponse()
        {
        }
        
        public UpdateResponse(WebRoleService.UpdateResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class UpdateResponseBody
    {
        
        public UpdateResponseBody()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Get", Namespace="http://tempuri.org/", Order=0)]
        public WebRoleService.GetRequestBody Body;
        
        public GetRequest()
        {
        }
        
        public GetRequest(WebRoleService.GetRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public short id;
        
        public GetRequestBody()
        {
        }
        
        public GetRequestBody(short id)
        {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebRoleService.GetResponseBody Body;
        
        public GetResponse()
        {
        }
        
        public GetResponse(WebRoleService.GetResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WebRoleService.RoleDto GetResult;
        
        public GetResponseBody()
        {
        }
        
        public GetResponseBody(WebRoleService.RoleDto GetResult)
        {
            this.GetResult = GetResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAll", Namespace="http://tempuri.org/", Order=0)]
        public WebRoleService.GetAllRequestBody Body;
        
        public GetAllRequest()
        {
        }
        
        public GetAllRequest(WebRoleService.GetAllRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetAllRequestBody
    {
        
        public GetAllRequestBody()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebRoleService.GetAllResponseBody Body;
        
        public GetAllResponse()
        {
        }
        
        public GetAllResponse(WebRoleService.GetAllResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAllResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WebRoleService.RoleDto[] GetAllResult;
        
        public GetAllResponseBody()
        {
        }
        
        public GetAllResponseBody(WebRoleService.RoleDto[] GetAllResult)
        {
            this.GetAllResult = GetAllResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    public interface WebRoleServiceSoapChannel : WebRoleService.WebRoleServiceSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    public partial class WebRoleServiceSoapClient : System.ServiceModel.ClientBase<WebRoleService.WebRoleServiceSoap>, WebRoleService.WebRoleServiceSoap
    {
        
    /// <summary>
    /// Implement this partial method to configure the service endpoint.
    /// </summary>
    /// <param name="serviceEndpoint">The endpoint to configure</param>
    /// <param name="clientCredentials">The client credentials</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public WebRoleServiceSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(WebRoleServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), WebRoleServiceSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WebRoleServiceSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(WebRoleServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WebRoleServiceSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(WebRoleServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WebRoleServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebRoleService.InsertResponse> WebRoleService.WebRoleServiceSoap.InsertAsync(WebRoleService.InsertRequest request)
        {
            return base.Channel.InsertAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebRoleService.InsertResponse> InsertAsync(WebRoleService.RoleDto roleDto)
        {
            WebRoleService.InsertRequest inValue = new WebRoleService.InsertRequest();
            inValue.Body = new WebRoleService.InsertRequestBody();
            inValue.Body.roleDto = roleDto;
            return ((WebRoleService.WebRoleServiceSoap)(this)).InsertAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebRoleService.UpdateResponse> WebRoleService.WebRoleServiceSoap.UpdateAsync(WebRoleService.UpdateRequest request)
        {
            return base.Channel.UpdateAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebRoleService.UpdateResponse> UpdateAsync(WebRoleService.RoleDto roleDto)
        {
            WebRoleService.UpdateRequest inValue = new WebRoleService.UpdateRequest();
            inValue.Body = new WebRoleService.UpdateRequestBody();
            inValue.Body.roleDto = roleDto;
            return ((WebRoleService.WebRoleServiceSoap)(this)).UpdateAsync(inValue);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(short id)
        {
            return base.Channel.DeleteAsync(id);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebRoleService.GetResponse> WebRoleService.WebRoleServiceSoap.GetAsync(WebRoleService.GetRequest request)
        {
            return base.Channel.GetAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebRoleService.GetResponse> GetAsync(short id)
        {
            WebRoleService.GetRequest inValue = new WebRoleService.GetRequest();
            inValue.Body = new WebRoleService.GetRequestBody();
            inValue.Body.id = id;
            return ((WebRoleService.WebRoleServiceSoap)(this)).GetAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebRoleService.GetAllResponse> WebRoleService.WebRoleServiceSoap.GetAllAsync(WebRoleService.GetAllRequest request)
        {
            return base.Channel.GetAllAsync(request);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebRoleService.GetResponse WebRoleServiceSoap.Get(WebRoleService.GetRequest request)
        {
            return base.Channel.Get(request);
        }

        public WebRoleService.RoleDto Get()
        {
            WebRoleService.GetRequest inValue = new WebRoleService.GetRequest();
            inValue.Body = new GetRequestBody();
            WebRoleService.GetResponse retVal = ((WebRoleService.WebRoleServiceSoap)(this)).Get(inValue);
            return retVal.Body.GetResult;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebRoleService.UpdateResponse WebRoleService.WebRoleServiceSoap.Update(WebRoleService.UpdateRequest request)
        {
            return base.Channel.Update(request);
        }

        public void Update(WebRoleService.RoleDto roleDto)
        {
            WebRoleService.UpdateRequest inValue = new WebRoleService.UpdateRequest();
            inValue.Body = new WebRoleService.UpdateRequestBody();
            inValue.Body.roleDto = roleDto;
            WebRoleService.UpdateResponse retVal = ((WebRoleService.WebRoleServiceSoap)(this)).Update(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebRoleService.GetResponse WebRoleService.WebRoleServiceSoap.GetId(WebRoleService.GetRequest request)
        {
            return base.Channel.Get(request);
        }

        public WebRoleService.RoleDto GetId(short id)
        {
            WebRoleService.GetRequest inValue = new WebRoleService.GetRequest();
            inValue.Body = new WebRoleService.GetRequestBody();
            inValue.Body.id = id;
            WebRoleService.GetResponse retVal = ((WebRoleService.WebRoleServiceSoap)(this)).GetId(inValue);
            return retVal.Body.GetResult;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebRoleService.InsertResponse WebRoleServiceSoap.Insert(WebRoleService.InsertRequest request)
        {
            return base.Channel.Insert(request);
        }

        public void Insert(WebRoleService.RoleDto roleDto)
        {
            WebRoleService.InsertRequest inValue = new WebRoleService.InsertRequest();
            inValue.Body = new WebRoleService.InsertRequestBody();
            inValue.Body.roleDto = roleDto;
            WebRoleService.InsertResponse retVal = ((WebRoleService.WebRoleServiceSoap)(this)).Insert(inValue);
        }

        //public void Delete(short id)
        //{
            //base.Channel.Delete(id);
        //}

        public System.Threading.Tasks.Task<WebRoleService.GetAllResponse> GetAllAsync()
        {
            WebRoleService.GetAllRequest inValue = new WebRoleService.GetAllRequest();
            inValue.Body = new WebRoleService.GetAllRequestBody();
            return ((WebRoleService.WebRoleServiceSoap)(this)).GetAllAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.WebRoleServiceSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.WebRoleServiceSoap12))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpTransportBindingElement httpBindingElement = new System.ServiceModel.Channels.HttpTransportBindingElement();
                httpBindingElement.AllowCookies = true;
                httpBindingElement.MaxBufferSize = int.MaxValue;
                httpBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.WebRoleServiceSoap))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:24654/WebRoleService.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.WebRoleServiceSoap12))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:24654/WebRoleService.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            WebRoleServiceSoap,
            
            WebRoleServiceSoap12,
        }
    }
}