﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace Socioboard.Api.TumblrAccount {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="TumblrAccountSoap", Namespace="http://tempuri.org/")]
    public partial class TumblrAccount : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetTumblrAccountDetailsByIdOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetAllTumblrAccountsOfUserOperationCompleted;
        
        private System.Threading.SendOrPostCallback DeleteTumblrAccountOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetAllTumblrAccountsByUserIdAndGroupIdOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetAllTumblrAccountsOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public TumblrAccount() {
            this.Url = global::Socioboard.Properties.Settings.Default.Socioboard_Api_TumblrAccount_TumblrAccount;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetTumblrAccountDetailsByIdCompletedEventHandler GetTumblrAccountDetailsByIdCompleted;
        
        /// <remarks/>
        public event GetAllTumblrAccountsOfUserCompletedEventHandler GetAllTumblrAccountsOfUserCompleted;
        
        /// <remarks/>
        public event DeleteTumblrAccountCompletedEventHandler DeleteTumblrAccountCompleted;
        
        /// <remarks/>
        public event GetAllTumblrAccountsByUserIdAndGroupIdCompletedEventHandler GetAllTumblrAccountsByUserIdAndGroupIdCompleted;
        
        /// <remarks/>
        public event GetAllTumblrAccountsCompletedEventHandler GetAllTumblrAccountsCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetTumblrAccountDetailsById", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetTumblrAccountDetailsById(string UserId, string ProfileId) {
            object[] results = this.Invoke("GetTumblrAccountDetailsById", new object[] {
                        UserId,
                        ProfileId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetTumblrAccountDetailsByIdAsync(string UserId, string ProfileId) {
            this.GetTumblrAccountDetailsByIdAsync(UserId, ProfileId, null);
        }
        
        /// <remarks/>
        public void GetTumblrAccountDetailsByIdAsync(string UserId, string ProfileId, object userState) {
            if ((this.GetTumblrAccountDetailsByIdOperationCompleted == null)) {
                this.GetTumblrAccountDetailsByIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetTumblrAccountDetailsByIdOperationCompleted);
            }
            this.InvokeAsync("GetTumblrAccountDetailsById", new object[] {
                        UserId,
                        ProfileId}, this.GetTumblrAccountDetailsByIdOperationCompleted, userState);
        }
        
        private void OnGetTumblrAccountDetailsByIdOperationCompleted(object arg) {
            if ((this.GetTumblrAccountDetailsByIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetTumblrAccountDetailsByIdCompleted(this, new GetTumblrAccountDetailsByIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetAllTumblrAccountsOfUser", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetAllTumblrAccountsOfUser(string UserId) {
            object[] results = this.Invoke("GetAllTumblrAccountsOfUser", new object[] {
                        UserId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetAllTumblrAccountsOfUserAsync(string UserId) {
            this.GetAllTumblrAccountsOfUserAsync(UserId, null);
        }
        
        /// <remarks/>
        public void GetAllTumblrAccountsOfUserAsync(string UserId, object userState) {
            if ((this.GetAllTumblrAccountsOfUserOperationCompleted == null)) {
                this.GetAllTumblrAccountsOfUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAllTumblrAccountsOfUserOperationCompleted);
            }
            this.InvokeAsync("GetAllTumblrAccountsOfUser", new object[] {
                        UserId}, this.GetAllTumblrAccountsOfUserOperationCompleted, userState);
        }
        
        private void OnGetAllTumblrAccountsOfUserOperationCompleted(object arg) {
            if ((this.GetAllTumblrAccountsOfUserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAllTumblrAccountsOfUserCompleted(this, new GetAllTumblrAccountsOfUserCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/DeleteTumblrAccount", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string DeleteTumblrAccount(string UserId, string ProfileId, string GroupId) {
            object[] results = this.Invoke("DeleteTumblrAccount", new object[] {
                        UserId,
                        ProfileId,
                        GroupId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void DeleteTumblrAccountAsync(string UserId, string ProfileId, string GroupId) {
            this.DeleteTumblrAccountAsync(UserId, ProfileId, GroupId, null);
        }
        
        /// <remarks/>
        public void DeleteTumblrAccountAsync(string UserId, string ProfileId, string GroupId, object userState) {
            if ((this.DeleteTumblrAccountOperationCompleted == null)) {
                this.DeleteTumblrAccountOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteTumblrAccountOperationCompleted);
            }
            this.InvokeAsync("DeleteTumblrAccount", new object[] {
                        UserId,
                        ProfileId,
                        GroupId}, this.DeleteTumblrAccountOperationCompleted, userState);
        }
        
        private void OnDeleteTumblrAccountOperationCompleted(object arg) {
            if ((this.DeleteTumblrAccountCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteTumblrAccountCompleted(this, new DeleteTumblrAccountCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetAllTumblrAccountsByUserIdAndGroupId", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetAllTumblrAccountsByUserIdAndGroupId(string userid, string groupid) {
            object[] results = this.Invoke("GetAllTumblrAccountsByUserIdAndGroupId", new object[] {
                        userid,
                        groupid});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetAllTumblrAccountsByUserIdAndGroupIdAsync(string userid, string groupid) {
            this.GetAllTumblrAccountsByUserIdAndGroupIdAsync(userid, groupid, null);
        }
        
        /// <remarks/>
        public void GetAllTumblrAccountsByUserIdAndGroupIdAsync(string userid, string groupid, object userState) {
            if ((this.GetAllTumblrAccountsByUserIdAndGroupIdOperationCompleted == null)) {
                this.GetAllTumblrAccountsByUserIdAndGroupIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAllTumblrAccountsByUserIdAndGroupIdOperationCompleted);
            }
            this.InvokeAsync("GetAllTumblrAccountsByUserIdAndGroupId", new object[] {
                        userid,
                        groupid}, this.GetAllTumblrAccountsByUserIdAndGroupIdOperationCompleted, userState);
        }
        
        private void OnGetAllTumblrAccountsByUserIdAndGroupIdOperationCompleted(object arg) {
            if ((this.GetAllTumblrAccountsByUserIdAndGroupIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAllTumblrAccountsByUserIdAndGroupIdCompleted(this, new GetAllTumblrAccountsByUserIdAndGroupIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetAllTumblrAccounts", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetAllTumblrAccounts() {
            object[] results = this.Invoke("GetAllTumblrAccounts", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetAllTumblrAccountsAsync() {
            this.GetAllTumblrAccountsAsync(null);
        }
        
        /// <remarks/>
        public void GetAllTumblrAccountsAsync(object userState) {
            if ((this.GetAllTumblrAccountsOperationCompleted == null)) {
                this.GetAllTumblrAccountsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAllTumblrAccountsOperationCompleted);
            }
            this.InvokeAsync("GetAllTumblrAccounts", new object[0], this.GetAllTumblrAccountsOperationCompleted, userState);
        }
        
        private void OnGetAllTumblrAccountsOperationCompleted(object arg) {
            if ((this.GetAllTumblrAccountsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAllTumblrAccountsCompleted(this, new GetAllTumblrAccountsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void GetTumblrAccountDetailsByIdCompletedEventHandler(object sender, GetTumblrAccountDetailsByIdCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetTumblrAccountDetailsByIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetTumblrAccountDetailsByIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void GetAllTumblrAccountsOfUserCompletedEventHandler(object sender, GetAllTumblrAccountsOfUserCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAllTumblrAccountsOfUserCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAllTumblrAccountsOfUserCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void DeleteTumblrAccountCompletedEventHandler(object sender, DeleteTumblrAccountCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DeleteTumblrAccountCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DeleteTumblrAccountCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void GetAllTumblrAccountsByUserIdAndGroupIdCompletedEventHandler(object sender, GetAllTumblrAccountsByUserIdAndGroupIdCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAllTumblrAccountsByUserIdAndGroupIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAllTumblrAccountsByUserIdAndGroupIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void GetAllTumblrAccountsCompletedEventHandler(object sender, GetAllTumblrAccountsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAllTumblrAccountsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAllTumblrAccountsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591