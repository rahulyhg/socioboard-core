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

namespace Socioboard.Api.TeamMemberProfile {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="TeamMemberProfileSoap", Namespace="http://tempuri.org/")]
    public partial class TeamMemberProfile : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback AddTeamMemberProfileOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetTeamMemberProfilesByTeamIdOperationCompleted;
        
        private System.Threading.SendOrPostCallback getAllTeamMemberProfilesOfTeamOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetTeamMembeDetailsForGroupReportOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetTeamMemberTwitterProfilesByTeamIdOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public TeamMemberProfile() {
            this.Url = global::Socioboard.Properties.Settings.Default.Socioboard_Api_TeamMemberProfile_TeamMemberProfile;
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
        public event AddTeamMemberProfileCompletedEventHandler AddTeamMemberProfileCompleted;
        
        /// <remarks/>
        public event GetTeamMemberProfilesByTeamIdCompletedEventHandler GetTeamMemberProfilesByTeamIdCompleted;
        
        /// <remarks/>
        public event getAllTeamMemberProfilesOfTeamCompletedEventHandler getAllTeamMemberProfilesOfTeamCompleted;
        
        /// <remarks/>
        public event GetTeamMembeDetailsForGroupReportCompletedEventHandler GetTeamMembeDetailsForGroupReportCompleted;
        
        /// <remarks/>
        public event GetTeamMemberTwitterProfilesByTeamIdCompletedEventHandler GetTeamMemberTwitterProfilesByTeamIdCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddTeamMemberProfile", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string AddTeamMemberProfile(string TeamId, string ProfileId, string ProfileType, string Status) {
            object[] results = this.Invoke("AddTeamMemberProfile", new object[] {
                        TeamId,
                        ProfileId,
                        ProfileType,
                        Status});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void AddTeamMemberProfileAsync(string TeamId, string ProfileId, string ProfileType, string Status) {
            this.AddTeamMemberProfileAsync(TeamId, ProfileId, ProfileType, Status, null);
        }
        
        /// <remarks/>
        public void AddTeamMemberProfileAsync(string TeamId, string ProfileId, string ProfileType, string Status, object userState) {
            if ((this.AddTeamMemberProfileOperationCompleted == null)) {
                this.AddTeamMemberProfileOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddTeamMemberProfileOperationCompleted);
            }
            this.InvokeAsync("AddTeamMemberProfile", new object[] {
                        TeamId,
                        ProfileId,
                        ProfileType,
                        Status}, this.AddTeamMemberProfileOperationCompleted, userState);
        }
        
        private void OnAddTeamMemberProfileOperationCompleted(object arg) {
            if ((this.AddTeamMemberProfileCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddTeamMemberProfileCompleted(this, new AddTeamMemberProfileCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetTeamMemberProfilesByTeamId", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetTeamMemberProfilesByTeamId(string TeamId) {
            object[] results = this.Invoke("GetTeamMemberProfilesByTeamId", new object[] {
                        TeamId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetTeamMemberProfilesByTeamIdAsync(string TeamId) {
            this.GetTeamMemberProfilesByTeamIdAsync(TeamId, null);
        }
        
        /// <remarks/>
        public void GetTeamMemberProfilesByTeamIdAsync(string TeamId, object userState) {
            if ((this.GetTeamMemberProfilesByTeamIdOperationCompleted == null)) {
                this.GetTeamMemberProfilesByTeamIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetTeamMemberProfilesByTeamIdOperationCompleted);
            }
            this.InvokeAsync("GetTeamMemberProfilesByTeamId", new object[] {
                        TeamId}, this.GetTeamMemberProfilesByTeamIdOperationCompleted, userState);
        }
        
        private void OnGetTeamMemberProfilesByTeamIdOperationCompleted(object arg) {
            if ((this.GetTeamMemberProfilesByTeamIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetTeamMemberProfilesByTeamIdCompleted(this, new GetTeamMemberProfilesByTeamIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getAllTeamMemberProfilesOfTeam", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string getAllTeamMemberProfilesOfTeam(string TeamId) {
            object[] results = this.Invoke("getAllTeamMemberProfilesOfTeam", new object[] {
                        TeamId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getAllTeamMemberProfilesOfTeamAsync(string TeamId) {
            this.getAllTeamMemberProfilesOfTeamAsync(TeamId, null);
        }
        
        /// <remarks/>
        public void getAllTeamMemberProfilesOfTeamAsync(string TeamId, object userState) {
            if ((this.getAllTeamMemberProfilesOfTeamOperationCompleted == null)) {
                this.getAllTeamMemberProfilesOfTeamOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetAllTeamMemberProfilesOfTeamOperationCompleted);
            }
            this.InvokeAsync("getAllTeamMemberProfilesOfTeam", new object[] {
                        TeamId}, this.getAllTeamMemberProfilesOfTeamOperationCompleted, userState);
        }
        
        private void OngetAllTeamMemberProfilesOfTeamOperationCompleted(object arg) {
            if ((this.getAllTeamMemberProfilesOfTeamCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getAllTeamMemberProfilesOfTeamCompleted(this, new getAllTeamMemberProfilesOfTeamCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetTeamMembeDetailsForGroupReport", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetTeamMembeDetailsForGroupReport(string TeamId, string userid, string days) {
            object[] results = this.Invoke("GetTeamMembeDetailsForGroupReport", new object[] {
                        TeamId,
                        userid,
                        days});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetTeamMembeDetailsForGroupReportAsync(string TeamId, string userid, string days) {
            this.GetTeamMembeDetailsForGroupReportAsync(TeamId, userid, days, null);
        }
        
        /// <remarks/>
        public void GetTeamMembeDetailsForGroupReportAsync(string TeamId, string userid, string days, object userState) {
            if ((this.GetTeamMembeDetailsForGroupReportOperationCompleted == null)) {
                this.GetTeamMembeDetailsForGroupReportOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetTeamMembeDetailsForGroupReportOperationCompleted);
            }
            this.InvokeAsync("GetTeamMembeDetailsForGroupReport", new object[] {
                        TeamId,
                        userid,
                        days}, this.GetTeamMembeDetailsForGroupReportOperationCompleted, userState);
        }
        
        private void OnGetTeamMembeDetailsForGroupReportOperationCompleted(object arg) {
            if ((this.GetTeamMembeDetailsForGroupReportCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetTeamMembeDetailsForGroupReportCompleted(this, new GetTeamMembeDetailsForGroupReportCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetTeamMemberTwitterProfilesByTeamId", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetTeamMemberTwitterProfilesByTeamId(string TeamId) {
            object[] results = this.Invoke("GetTeamMemberTwitterProfilesByTeamId", new object[] {
                        TeamId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetTeamMemberTwitterProfilesByTeamIdAsync(string TeamId) {
            this.GetTeamMemberTwitterProfilesByTeamIdAsync(TeamId, null);
        }
        
        /// <remarks/>
        public void GetTeamMemberTwitterProfilesByTeamIdAsync(string TeamId, object userState) {
            if ((this.GetTeamMemberTwitterProfilesByTeamIdOperationCompleted == null)) {
                this.GetTeamMemberTwitterProfilesByTeamIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetTeamMemberTwitterProfilesByTeamIdOperationCompleted);
            }
            this.InvokeAsync("GetTeamMemberTwitterProfilesByTeamId", new object[] {
                        TeamId}, this.GetTeamMemberTwitterProfilesByTeamIdOperationCompleted, userState);
        }
        
        private void OnGetTeamMemberTwitterProfilesByTeamIdOperationCompleted(object arg) {
            if ((this.GetTeamMemberTwitterProfilesByTeamIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetTeamMemberTwitterProfilesByTeamIdCompleted(this, new GetTeamMemberTwitterProfilesByTeamIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public delegate void AddTeamMemberProfileCompletedEventHandler(object sender, AddTeamMemberProfileCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddTeamMemberProfileCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddTeamMemberProfileCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void GetTeamMemberProfilesByTeamIdCompletedEventHandler(object sender, GetTeamMemberProfilesByTeamIdCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetTeamMemberProfilesByTeamIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetTeamMemberProfilesByTeamIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void getAllTeamMemberProfilesOfTeamCompletedEventHandler(object sender, getAllTeamMemberProfilesOfTeamCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getAllTeamMemberProfilesOfTeamCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getAllTeamMemberProfilesOfTeamCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void GetTeamMembeDetailsForGroupReportCompletedEventHandler(object sender, GetTeamMembeDetailsForGroupReportCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetTeamMembeDetailsForGroupReportCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetTeamMembeDetailsForGroupReportCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void GetTeamMemberTwitterProfilesByTeamIdCompletedEventHandler(object sender, GetTeamMemberTwitterProfilesByTeamIdCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetTeamMemberTwitterProfilesByTeamIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetTeamMemberTwitterProfilesByTeamIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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