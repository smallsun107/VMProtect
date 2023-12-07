﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.34014.
// 

using System.Security.Cryptography.X509Certificates;
using ipn_sqlclr;

#pragma warning disable 1591

namespace veriSignCertIssuingService {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="veriSignCertIssuingServiceSOAP", Namespace="http://schemas.verisign.com/pkiservices/2009/07/enrollment")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AttributedString))]
	public partial class veriSignCertIssuingService : XmlReaderSpyService
	{
        
        private System.Threading.SendOrPostCallback RequestSecurityTokenOperationCompleted;
        
        private System.Threading.SendOrPostCallback RequestSecurityToken2OperationCompleted;
        
        /// <remarks/>
		public veriSignCertIssuingService(X509Certificate clientCert, string url)
			: base(clientCert, url)
		{
		}
        
        /// <remarks/>
        public event RequestSecurityTokenCompletedEventHandler RequestSecurityTokenCompleted;
        
        /// <remarks/>
        public event RequestSecurityToken2CompletedEventHandler RequestSecurityToken2Completed;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.verisign.com/pkiservices/2009/07/enrollment/requestSecurityToken", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute("RequestSecurityTokenResponse", Namespace="http://docs.oasis-open.org/ws-sx/ws-trust/200512/")]
        public RequestSecurityTokenResponseType RequestSecurityToken([System.Xml.Serialization.XmlElementAttribute("RequestSecurityToken", Namespace="http://docs.oasis-open.org/ws-sx/ws-trust/200512/")] RequestSecurityTokenType RequestSecurityToken1) {
            object[] results = this.Invoke("RequestSecurityToken", new object[] {
                        RequestSecurityToken1});
            return ((RequestSecurityTokenResponseType)(results[0]));
        }
        
        /// <remarks/>
        public void RequestSecurityTokenAsync(RequestSecurityTokenType RequestSecurityToken1) {
            this.RequestSecurityTokenAsync(RequestSecurityToken1, null);
        }
        
        /// <remarks/>
        public void RequestSecurityTokenAsync(RequestSecurityTokenType RequestSecurityToken1, object userState) {
            if ((this.RequestSecurityTokenOperationCompleted == null)) {
                this.RequestSecurityTokenOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRequestSecurityTokenOperationCompleted);
            }
            this.InvokeAsync("RequestSecurityToken", new object[] {
                        RequestSecurityToken1}, this.RequestSecurityTokenOperationCompleted, userState);
        }
        
        private void OnRequestSecurityTokenOperationCompleted(object arg) {
            if ((this.RequestSecurityTokenCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RequestSecurityTokenCompleted(this, new RequestSecurityTokenCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.verisign.com/pkiservices/2009/07/enrollment/requestSecurityToken2", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute("RequestSecurityTokenResponseCollection", Namespace="http://docs.oasis-open.org/ws-sx/ws-trust/200512/")]
        public RequestSecurityTokenResponseCollectionType RequestSecurityToken2([System.Xml.Serialization.XmlElementAttribute("RequestSecurityToken", Namespace="http://docs.oasis-open.org/ws-sx/ws-trust/200512/")] RequestSecurityTokenType RequestSecurityToken1) {
            object[] results = this.Invoke("RequestSecurityToken2", new object[] {
                        RequestSecurityToken1});
            return ((RequestSecurityTokenResponseCollectionType)(results[0]));
        }
        
        /// <remarks/>
        public void RequestSecurityToken2Async(RequestSecurityTokenType RequestSecurityToken1) {
            this.RequestSecurityToken2Async(RequestSecurityToken1, null);
        }
        
        /// <remarks/>
        public void RequestSecurityToken2Async(RequestSecurityTokenType RequestSecurityToken1, object userState) {
            if ((this.RequestSecurityToken2OperationCompleted == null)) {
                this.RequestSecurityToken2OperationCompleted = new System.Threading.SendOrPostCallback(this.OnRequestSecurityToken2OperationCompleted);
            }
            this.InvokeAsync("RequestSecurityToken2", new object[] {
                        RequestSecurityToken1}, this.RequestSecurityToken2OperationCompleted, userState);
        }
        
        private void OnRequestSecurityToken2OperationCompleted(object arg) {
            if ((this.RequestSecurityToken2Completed != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RequestSecurityToken2Completed(this, new RequestSecurityToken2CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.oasis-open.org/ws-sx/ws-trust/200512/")]
    public partial class RequestSecurityTokenType {
        
        private RequestVSSecurityTokenEnrollmentType itemField;
        
        private System.Xml.XmlElement[] anyField;
        
        private string contextField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("requestVSSecurityToken", Namespace="http://schemas.verisign.com/pkiservices/2009/07/enrollment")]
        public RequestVSSecurityTokenEnrollmentType Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string Context {
            get {
                return this.contextField;
            }
            set {
                this.contextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.verisign.com/pkiservices/2009/07/enrollment")]
    public partial class RequestVSSecurityTokenEnrollmentType {
        
        private string certificateProfileIDField;
        
        private string clientTransactionIDField;
        
        private TokenType tokenTypeField;
        
        private bool tokenTypeFieldSpecified;
        
        private RequestTypeEnum requestTypeField;
        
        private BinarySecurityTokenType[] binarySecurityTokenField;
        
        private AdditionalContextType additionalContextField;
        
        private string pendingTokenReferenceIDField;
        
        private NameValueType[] nameValuePairField;
        
        private string versionField;
        
        private System.Xml.XmlElement[] anyField;
        
        private string preferredLanguageField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        public string certificateProfileID {
            get {
                return this.certificateProfileIDField;
            }
            set {
                this.certificateProfileIDField = value;
            }
        }
        
        /// <remarks/>
        public string clientTransactionID {
            get {
                return this.clientTransactionIDField;
            }
            set {
                this.clientTransactionIDField = value;
            }
        }
        
        /// <remarks/>
        public TokenType tokenType {
            get {
                return this.tokenTypeField;
            }
            set {
                this.tokenTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tokenTypeSpecified {
            get {
                return this.tokenTypeFieldSpecified;
            }
            set {
                this.tokenTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public RequestTypeEnum requestType {
            get {
                return this.requestTypeField;
            }
            set {
                this.requestTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("binarySecurityToken")]
        public BinarySecurityTokenType[] binarySecurityToken {
            get {
                return this.binarySecurityTokenField;
            }
            set {
                this.binarySecurityTokenField = value;
            }
        }
        
        /// <remarks/>
        public AdditionalContextType additionalContext {
            get {
                return this.additionalContextField;
            }
            set {
                this.additionalContextField = value;
            }
        }
        
        /// <remarks/>
        public string pendingTokenReferenceID {
            get {
                return this.pendingTokenReferenceIDField;
            }
            set {
                this.pendingTokenReferenceIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("nameValuePair")]
        public NameValueType[] nameValuePair {
            get {
                return this.nameValuePairField;
            }
            set {
                this.nameValuePairField = value;
            }
        }
        
        /// <remarks/>
        public string version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="language")]
        public string preferredLanguage {
            get {
                return this.preferredLanguageField;
            }
            set {
                this.preferredLanguageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.verisign.com/pkiservices/2009/07/enrollment")]
    public enum TokenType {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-x509-token-profile-1.0#X5" +
            "09v3")]
        httpdocsoasisopenorgwss200401oasis200401wssx509tokenprofile10X509v3,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-x509-token-profile-1.0#PK" +
            "CS7")]
        httpdocsoasisopenorgwss200401oasis200401wssx509tokenprofile10PKCS7,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://schemas.verisign.com/pkiservices/2009/07/PKCS12")]
        httpschemasverisigncompkiservices200907PKCS12,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.verisign.com/pkiservices/2009/07/enrollment")]
    public enum RequestTypeEnum {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://docs.oasis-open.org/ws-sx/ws-trust/200512/Issue")]
        httpdocsoasisopenorgwssxwstrust200512Issue,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://docs.oasis-open.org/ws-sx/ws-trust/200512/Renew")]
        httpdocsoasisopenorgwssxwstrust200512Renew,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://schemas.verisign.com/pkiservices/2009/07/QueryTokenStatus")]
        httpschemasverisigncompkiservices200907QueryTokenStatus,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd" +
        "")]
    public partial class BinarySecurityTokenType : EncodedString {
        
        private string valueTypeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string ValueType {
            get {
                return this.valueTypeField;
            }
            set {
                this.valueTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(KeyIdentifierType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BinarySecurityTokenType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd" +
        "")]
    public partial class EncodedString : AttributedString {
        
        private string encodingTypeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string EncodingType {
            get {
                return this.encodingTypeField;
            }
            set {
                this.encodingTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EncodedString))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(KeyIdentifierType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BinarySecurityTokenType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PasswordString))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd" +
        "")]
    public partial class AttributedString {
        
        private string idField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xs" +
            "d", DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.oasis-open.org/ws-sx/ws-trust/200512/")]
    public partial class RequestSecurityTokenResponseCollectionType {
        
        private RequestSecurityTokenResponseType[] requestSecurityTokenResponseField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RequestSecurityTokenResponse")]
        public RequestSecurityTokenResponseType[] RequestSecurityTokenResponse {
            get {
                return this.requestSecurityTokenResponseField;
            }
            set {
                this.requestSecurityTokenResponseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.oasis-open.org/ws-sx/ws-trust/200512/")]
    public partial class RequestSecurityTokenResponseType {
        
        private RequestVSSecurityTokenResponseEnrollmentType itemField;
        
        private System.Xml.XmlElement[] anyField;
        
        private string contextField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RequestVSSecurityTokenResponse", Namespace="http://schemas.verisign.com/pkiservices/2009/07/enrollment")]
        public RequestVSSecurityTokenResponseEnrollmentType Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string Context {
            get {
                return this.contextField;
            }
            set {
                this.contextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.verisign.com/pkiservices/2009/07/enrollment")]
    public partial class RequestVSSecurityTokenResponseEnrollmentType {
        
        private string clientTransactionIDField;
        
        private string serverTransactionIDField;
        
        private TokenType tokenTypeField;
        
        private bool tokenTypeFieldSpecified;
        
        private string dispositionMessageField;
        
        private BinarySecurityTokenType binarySecurityTokenField;
        
        private RequestedVSSecurityTokenEnrollmentType requestedVSSecurityTokenField;
        
        private string versionField;
        
        private System.Xml.XmlElement[] anyField;
        
        private string preferredLanguageField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        public string clientTransactionID {
            get {
                return this.clientTransactionIDField;
            }
            set {
                this.clientTransactionIDField = value;
            }
        }
        
        /// <remarks/>
        public string serverTransactionID {
            get {
                return this.serverTransactionIDField;
            }
            set {
                this.serverTransactionIDField = value;
            }
        }
        
        /// <remarks/>
        public TokenType tokenType {
            get {
                return this.tokenTypeField;
            }
            set {
                this.tokenTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tokenTypeSpecified {
            get {
                return this.tokenTypeFieldSpecified;
            }
            set {
                this.tokenTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string dispositionMessage {
            get {
                return this.dispositionMessageField;
            }
            set {
                this.dispositionMessageField = value;
            }
        }
        
        /// <remarks/>
        public BinarySecurityTokenType binarySecurityToken {
            get {
                return this.binarySecurityTokenField;
            }
            set {
                this.binarySecurityTokenField = value;
            }
        }
        
        /// <remarks/>
        public RequestedVSSecurityTokenEnrollmentType requestedVSSecurityToken {
            get {
                return this.requestedVSSecurityTokenField;
            }
            set {
                this.requestedVSSecurityTokenField = value;
            }
        }
        
        /// <remarks/>
        public string version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="language")]
        public string preferredLanguage {
            get {
                return this.preferredLanguageField;
            }
            set {
                this.preferredLanguageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.verisign.com/pkiservices/2009/07/enrollment")]
    public partial class RequestedVSSecurityTokenEnrollmentType {
        
        private object[] itemsField;
        
        private ItemsChoiceType[] itemsElementNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("binarySecurityToken", typeof(BinarySecurityTokenType))]
        [System.Xml.Serialization.XmlElementAttribute("pKCS12Password", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("pendingTokenReferenceID", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.verisign.com/pkiservices/2009/07/enrollment", IncludeInSchema=false)]
    public enum ItemsChoiceType {
        
        /// <remarks/>
        binarySecurityToken,
        
        /// <remarks/>
        pKCS12Password,
        
        /// <remarks/>
        pendingTokenReferenceID,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.verisign.com/pkiservices/2009/07/enrollment")]
    public partial class NameValueType {
        
        private string nameField;
        
        private string valueField;
        
        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.xmlsoap.org/ws/2006/12/authorization")]
    public partial class ContextItemType {
        
        private object itemField;
        
        private string nameField;
        
        private string scopeField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Value", typeof(string))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string Scope {
            get {
                return this.scopeField;
            }
            set {
                this.scopeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.xmlsoap.org/ws/2006/12/authorization")]
    public partial class AdditionalContextType {
        
        private ContextItemType[] contextItemField;
        
        private System.Xml.XmlElement[] anyField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ContextItem")]
        public ContextItemType[] ContextItem {
            get {
                return this.contextItemField;
            }
            set {
                this.contextItemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd" +
        "")]
    public partial class PasswordString : AttributedString {
        
        private string typeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd" +
        "")]
    public partial class KeyIdentifierType : EncodedString {
        
        private string valueTypeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string ValueType {
            get {
                return this.valueTypeField;
            }
            set {
                this.valueTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void RequestSecurityTokenCompletedEventHandler(object sender, RequestSecurityTokenCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RequestSecurityTokenCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal RequestSecurityTokenCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public RequestSecurityTokenResponseType Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((RequestSecurityTokenResponseType)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void RequestSecurityToken2CompletedEventHandler(object sender, RequestSecurityToken2CompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RequestSecurityToken2CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal RequestSecurityToken2CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public RequestSecurityTokenResponseCollectionType Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((RequestSecurityTokenResponseCollectionType)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591