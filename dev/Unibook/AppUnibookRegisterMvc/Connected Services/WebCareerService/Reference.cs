﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     //
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebCareerService
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CareerDto", Namespace="http://tempuri.org/")]
    public partial class CareerDto : object
    {
        
        private int CareerIdField;
        
        private string NameField;
        
        private bool DeletedField;
        
        private WebCareerService.FacultyDto FacultyField;
        
        private WebCareerService.UserCareerDto UserCareerField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int CareerId
        {
            get
            {
                return this.CareerIdField;
            }
            set
            {
                this.CareerIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public WebCareerService.FacultyDto Faculty
        {
            get
            {
                return this.FacultyField;
            }
            set
            {
                this.FacultyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public WebCareerService.UserCareerDto UserCareer
        {
            get
            {
                return this.UserCareerField;
            }
            set
            {
                this.UserCareerField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FacultyDto", Namespace="http://tempuri.org/")]
    public partial class FacultyDto : object
    {
        
        private short FacultyIdField;
        
        private string NameField;
        
        private bool DeletedField;
        
        private WebCareerService.CareerDto CareerField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public short FacultyId
        {
            get
            {
                return this.FacultyIdField;
            }
            set
            {
                this.FacultyIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public WebCareerService.CareerDto Career
        {
            get
            {
                return this.CareerField;
            }
            set
            {
                this.CareerField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserCareerDto", Namespace="http://tempuri.org/")]
    public partial class UserCareerDto : object
    {
        
        private long UserCareerIdField;
        
        private WebCareerService.UserDto UserField;
        
        private WebCareerService.CareerDto CareerField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public long UserCareerId
        {
            get
            {
                return this.UserCareerIdField;
            }
            set
            {
                this.UserCareerIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public WebCareerService.UserDto User
        {
            get
            {
                return this.UserField;
            }
            set
            {
                this.UserField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public WebCareerService.CareerDto Career
        {
            get
            {
                return this.CareerField;
            }
            set
            {
                this.CareerField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserDto", Namespace="http://tempuri.org/")]
    public partial class UserDto : object
    {
        
        private long UserIdField;
        
        private string EmailField;
        
        private string PasswordField;
        
        private bool DeletedField;
        
        private WebCareerService.RoleDto RoleField;
        
        private WebCareerService.UserCareerDto UserCareerField;
        
        private WebCareerService.PersonDto PersonField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public long UserId
        {
            get
            {
                return this.UserIdField;
            }
            set
            {
                this.UserIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Email
        {
            get
            {
                return this.EmailField;
            }
            set
            {
                this.EmailField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Password
        {
            get
            {
                return this.PasswordField;
            }
            set
            {
                this.PasswordField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public WebCareerService.RoleDto Role
        {
            get
            {
                return this.RoleField;
            }
            set
            {
                this.RoleField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public WebCareerService.UserCareerDto UserCareer
        {
            get
            {
                return this.UserCareerField;
            }
            set
            {
                this.UserCareerField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public WebCareerService.PersonDto Person
        {
            get
            {
                return this.PersonField;
            }
            set
            {
                this.PersonField = value;
            }
        }
    }
    
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PersonDto", Namespace="http://tempuri.org/")]
    public partial class PersonDto : object
    {
        
        private long PersonIdField;
        
        private string NameField;
        
        private string LastNameField;
        
        private System.Nullable<System.DateTime> BirthDayField;
        
        private bool DeletedField;
        
        private WebCareerService.GenderDto GenderField;
        
        private WebCareerService.UserDto UserField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public long PersonId
        {
            get
            {
                return this.PersonIdField;
            }
            set
            {
                this.PersonIdField = value;
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string LastName
        {
            get
            {
                return this.LastNameField;
            }
            set
            {
                this.LastNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public System.Nullable<System.DateTime> BirthDay
        {
            get
            {
                return this.BirthDayField;
            }
            set
            {
                this.BirthDayField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public WebCareerService.GenderDto Gender
        {
            get
            {
                return this.GenderField;
            }
            set
            {
                this.GenderField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public WebCareerService.UserDto User
        {
            get
            {
                return this.UserField;
            }
            set
            {
                this.UserField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GenderDto", Namespace="http://tempuri.org/")]
    public partial class GenderDto : object
    {
        
        private short GenderIdField;
        
        private string NameField;
        
        private WebCareerService.PersonDto PersonField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public short GenderId
        {
            get
            {
                return this.GenderIdField;
            }
            set
            {
                this.GenderIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public WebCareerService.PersonDto Person
        {
            get
            {
                return this.PersonField;
            }
            set
            {
                this.PersonField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WebCareerService.WebCareerServiceSoap")]
    public interface WebCareerServiceSoap
    {

        // CODEGEN: Generating message contract since element name GetResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/Get", ReplyAction = "*")]
        WebCareerService.GetResponse Get(WebCareerService.GetRequest request);

        // CODEGEN: Generating message contract since element name GetResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/Get", ReplyAction = "*")]
        WebCareerService.GetResponse GetId(WebCareerService.GetRequest request);

        // CODEGEN: Generating message contract since element name roleDto from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/Insert", ReplyAction = "*")]
        WebCareerService.InsertResponse Insert(WebCareerService.InsertRequest request);

        // CODEGEN: Generating message contract since element name roleDto from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/Update", ReplyAction = "*")]
        WebCareerService.UpdateResponse Update(WebCareerService.UpdateRequest request);

        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Insert", ReplyAction="*")]
        System.Threading.Tasks.Task<WebCareerService.InsertResponse> InsertAsync(WebCareerService.InsertRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Update", ReplyAction="*")]
        System.Threading.Tasks.Task<WebCareerService.UpdateResponse> UpdateAsync(WebCareerService.UpdateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Delete", ReplyAction="*")]
        System.Threading.Tasks.Task DeleteAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Get", ReplyAction="*")]
        System.Threading.Tasks.Task<WebCareerService.GetResponse> GetAsync(WebCareerService.GetRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Insert", Namespace="http://tempuri.org/", Order=0)]
        public WebCareerService.InsertRequestBody Body;
        
        public InsertRequest()
        {
        }
        
        public InsertRequest(WebCareerService.InsertRequestBody Body)
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
        public WebCareerService.CareerDto careerDto;
        
        public InsertRequestBody()
        {
        }
        
        public InsertRequestBody(WebCareerService.CareerDto careerDto)
        {
            this.careerDto = careerDto;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebCareerService.InsertResponseBody Body;
        
        public InsertResponse()
        {
        }
        
        public InsertResponse(WebCareerService.InsertResponseBody Body)
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
        public WebCareerService.UpdateRequestBody Body;
        
        public UpdateRequest()
        {
        }
        
        public UpdateRequest(WebCareerService.UpdateRequestBody Body)
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
        public WebCareerService.CareerDto careerDto;
        
        public UpdateRequestBody()
        {
        }
        
        public UpdateRequestBody(WebCareerService.CareerDto careerDto)
        {
            this.careerDto = careerDto;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebCareerService.UpdateResponseBody Body;
        
        public UpdateResponse()
        {
        }
        
        public UpdateResponse(WebCareerService.UpdateResponseBody Body)
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
        public WebCareerService.GetRequestBody Body;
        
        public GetRequest()
        {
        }
        
        public GetRequest(WebCareerService.GetRequestBody Body)
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
        public int id;
        
        public GetRequestBody()
        {
        }
        
        public GetRequestBody(int id)
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
        public WebCareerService.GetResponseBody Body;
        
        public GetResponse()
        {
        }
        
        public GetResponse(WebCareerService.GetResponseBody Body)
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
        public WebCareerService.CareerDto GetResult;
        
        public GetResponseBody()
        {
        }
        
        public GetResponseBody(WebCareerService.CareerDto GetResult)
        {
            this.GetResult = GetResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    public interface WebCareerServiceSoapChannel : WebCareerService.WebCareerServiceSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    public partial class WebCareerServiceSoapClient : System.ServiceModel.ClientBase<WebCareerService.WebCareerServiceSoap>, WebCareerService.WebCareerServiceSoap
    {
        
    /// <summary>
    /// Implement this partial method to configure the service endpoint.
    /// </summary>
    /// <param name="serviceEndpoint">The endpoint to configure</param>
    /// <param name="clientCredentials">The client credentials</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public WebCareerServiceSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(WebCareerServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), WebCareerServiceSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WebCareerServiceSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(WebCareerServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WebCareerServiceSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(WebCareerServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WebCareerServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebCareerService.InsertResponse> WebCareerService.WebCareerServiceSoap.InsertAsync(WebCareerService.InsertRequest request)
        {
            return base.Channel.InsertAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebCareerService.InsertResponse> InsertAsync(WebCareerService.CareerDto careerDto)
        {
            WebCareerService.InsertRequest inValue = new WebCareerService.InsertRequest();
            inValue.Body = new WebCareerService.InsertRequestBody();
            inValue.Body.careerDto = careerDto;
            return ((WebCareerService.WebCareerServiceSoap)(this)).InsertAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebCareerService.UpdateResponse> WebCareerService.WebCareerServiceSoap.UpdateAsync(WebCareerService.UpdateRequest request)
        {
            return base.Channel.UpdateAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebCareerService.UpdateResponse> UpdateAsync(WebCareerService.CareerDto careerDto)
        {
            WebCareerService.UpdateRequest inValue = new WebCareerService.UpdateRequest();
            inValue.Body = new WebCareerService.UpdateRequestBody();
            inValue.Body.careerDto = careerDto;
            return ((WebCareerService.WebCareerServiceSoap)(this)).UpdateAsync(inValue);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(int id)
        {
            return base.Channel.DeleteAsync(id);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebCareerService.GetResponse> WebCareerService.WebCareerServiceSoap.GetAsync(WebCareerService.GetRequest request)
        {
            return base.Channel.GetAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebCareerService.GetResponse> GetAsync(int id)
        {
            WebCareerService.GetRequest inValue = new WebCareerService.GetRequest();
            inValue.Body = new WebCareerService.GetRequestBody();
            inValue.Body.id = id;
            return ((WebCareerService.WebCareerServiceSoap)(this)).GetAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebCareerService.GetResponse WebCareerServiceSoap.Get(WebCareerService.GetRequest request)
        {
            return base.Channel.Get(request);
        }

        public WebCareerService.CareerDto Get()
        {
            WebCareerService.GetRequest inValue = new WebCareerService.GetRequest();
            inValue.Body = new GetRequestBody();
            WebCareerService.GetResponse retVal = ((WebCareerService.WebCareerServiceSoap)(this)).Get(inValue);
            return retVal.Body.GetResult;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebCareerService.GetResponse WebCareerService.WebCareerServiceSoap.GetId(WebCareerService.GetRequest request)
        {
            return base.Channel.Get(request);
        }

        public WebCareerService.CareerDto GetId(int id)
        {
            WebCareerService.GetRequest inValue = new WebCareerService.GetRequest();
            inValue.Body = new WebCareerService.GetRequestBody();
            inValue.Body.id = id;
            WebCareerService.GetResponse retVal = ((WebCareerService.WebCareerServiceSoap)(this)).GetId(inValue);
            return retVal.Body.GetResult;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebCareerService.InsertResponse WebCareerServiceSoap.Insert(WebCareerService.InsertRequest request)
        {
            return base.Channel.Insert(request);
        }

        public void Insert(WebCareerService.CareerDto careerDto)
        {
            WebCareerService.InsertRequest inValue = new WebCareerService.InsertRequest();
            inValue.Body = new WebCareerService.InsertRequestBody();
            inValue.Body.careerDto = careerDto;
            WebCareerService.InsertResponse retVal = ((WebCareerService.WebCareerServiceSoap)(this)).Insert(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebCareerService.UpdateResponse WebCareerService.WebCareerServiceSoap.Update(WebCareerService.UpdateRequest request)
        {
            return base.Channel.Update(request);
        }

        public void Update(WebCareerService.CareerDto careerDto)
        {
            WebCareerService.UpdateRequest inValue = new WebCareerService.UpdateRequest();
            inValue.Body = new WebCareerService.UpdateRequestBody();
            inValue.Body.careerDto = careerDto;
            WebCareerService.UpdateResponse retVal = ((WebCareerService.WebCareerServiceSoap)(this)).Update(inValue);
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
            if ((endpointConfiguration == EndpointConfiguration.WebCareerServiceSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.WebCareerServiceSoap12))
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
            if ((endpointConfiguration == EndpointConfiguration.WebCareerServiceSoap))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:24654/WebCareerService.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.WebCareerServiceSoap12))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:24654/WebCareerService.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            WebCareerServiceSoap,
            
            WebCareerServiceSoap12,
        }
    }
}
