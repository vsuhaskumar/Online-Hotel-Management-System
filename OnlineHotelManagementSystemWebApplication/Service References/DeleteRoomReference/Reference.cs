﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1026
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineHotelManagementSystemWebApplication.DeleteRoomReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Room", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Room : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int _roomIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string _roomDescField;
        
        private int _roomTypeIDField;
        
        private decimal _roomChargesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string _roomServicesField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int _roomID {
            get {
                return this._roomIDField;
            }
            set {
                if ((this._roomIDField.Equals(value) != true)) {
                    this._roomIDField = value;
                    this.RaisePropertyChanged("_roomID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string _roomDesc {
            get {
                return this._roomDescField;
            }
            set {
                if ((object.ReferenceEquals(this._roomDescField, value) != true)) {
                    this._roomDescField = value;
                    this.RaisePropertyChanged("_roomDesc");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public int _roomTypeID {
            get {
                return this._roomTypeIDField;
            }
            set {
                if ((this._roomTypeIDField.Equals(value) != true)) {
                    this._roomTypeIDField = value;
                    this.RaisePropertyChanged("_roomTypeID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public decimal _roomCharges {
            get {
                return this._roomChargesField;
            }
            set {
                if ((this._roomChargesField.Equals(value) != true)) {
                    this._roomChargesField = value;
                    this.RaisePropertyChanged("_roomCharges");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string _roomServices {
            get {
                return this._roomServicesField;
            }
            set {
                if ((object.ReferenceEquals(this._roomServicesField, value) != true)) {
                    this._roomServicesField = value;
                    this.RaisePropertyChanged("_roomServices");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DeleteRoomReference.DeleteRoomServiceSoap")]
    public interface DeleteRoomServiceSoap {
        
        // CODEGEN: Generating message contract since element name RoomDeleteResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RoomDelete", ReplyAction="*")]
        OnlineHotelManagementSystemWebApplication.DeleteRoomReference.RoomDeleteResponse RoomDelete(OnlineHotelManagementSystemWebApplication.DeleteRoomReference.RoomDeleteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Deleteroom", ReplyAction="*")]
        void Deleteroom(int RoomID);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RoomDeleteRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RoomDelete", Namespace="http://tempuri.org/", Order=0)]
        public OnlineHotelManagementSystemWebApplication.DeleteRoomReference.RoomDeleteRequestBody Body;
        
        public RoomDeleteRequest() {
        }
        
        public RoomDeleteRequest(OnlineHotelManagementSystemWebApplication.DeleteRoomReference.RoomDeleteRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class RoomDeleteRequestBody {
        
        public RoomDeleteRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RoomDeleteResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RoomDeleteResponse", Namespace="http://tempuri.org/", Order=0)]
        public OnlineHotelManagementSystemWebApplication.DeleteRoomReference.RoomDeleteResponseBody Body;
        
        public RoomDeleteResponse() {
        }
        
        public RoomDeleteResponse(OnlineHotelManagementSystemWebApplication.DeleteRoomReference.RoomDeleteResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class RoomDeleteResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public OnlineHotelManagementSystemWebApplication.DeleteRoomReference.Room[] RoomDeleteResult;
        
        public RoomDeleteResponseBody() {
        }
        
        public RoomDeleteResponseBody(OnlineHotelManagementSystemWebApplication.DeleteRoomReference.Room[] RoomDeleteResult) {
            this.RoomDeleteResult = RoomDeleteResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface DeleteRoomServiceSoapChannel : OnlineHotelManagementSystemWebApplication.DeleteRoomReference.DeleteRoomServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DeleteRoomServiceSoapClient : System.ServiceModel.ClientBase<OnlineHotelManagementSystemWebApplication.DeleteRoomReference.DeleteRoomServiceSoap>, OnlineHotelManagementSystemWebApplication.DeleteRoomReference.DeleteRoomServiceSoap {
        
        public DeleteRoomServiceSoapClient() {
        }
        
        public DeleteRoomServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DeleteRoomServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DeleteRoomServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DeleteRoomServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        OnlineHotelManagementSystemWebApplication.DeleteRoomReference.RoomDeleteResponse OnlineHotelManagementSystemWebApplication.DeleteRoomReference.DeleteRoomServiceSoap.RoomDelete(OnlineHotelManagementSystemWebApplication.DeleteRoomReference.RoomDeleteRequest request) {
            return base.Channel.RoomDelete(request);
        }
        
        public OnlineHotelManagementSystemWebApplication.DeleteRoomReference.Room[] RoomDelete() {
            OnlineHotelManagementSystemWebApplication.DeleteRoomReference.RoomDeleteRequest inValue = new OnlineHotelManagementSystemWebApplication.DeleteRoomReference.RoomDeleteRequest();
            inValue.Body = new OnlineHotelManagementSystemWebApplication.DeleteRoomReference.RoomDeleteRequestBody();
            OnlineHotelManagementSystemWebApplication.DeleteRoomReference.RoomDeleteResponse retVal = ((OnlineHotelManagementSystemWebApplication.DeleteRoomReference.DeleteRoomServiceSoap)(this)).RoomDelete(inValue);
            return retVal.Body.RoomDeleteResult;
        }
        
        public void Deleteroom(int RoomID) {
            base.Channel.Deleteroom(RoomID);
        }
    }
}