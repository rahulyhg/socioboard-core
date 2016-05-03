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

namespace Socioboard.Api.TaskComment {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="TaskCommentSoap", Namespace="http://tempuri.org/")]
    public partial class TaskComment : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetAllTaskCommentByUserIdTaskIdOperationCompleted;
        
        private System.Threading.SendOrPostCallback AddTaskCommentOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public TaskComment() {
            this.Url = global::Socioboard.Properties.Settings.Default.Socioboard_Api_TaskComment_TaskComment;
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
        public event GetAllTaskCommentByUserIdTaskIdCompletedEventHandler GetAllTaskCommentByUserIdTaskIdCompleted;
        
        /// <remarks/>
        public event AddTaskCommentCompletedEventHandler AddTaskCommentCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetAllTaskCommentByUserIdTaskId", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetAllTaskCommentByUserIdTaskId(string taskId, string userId) {
            object[] results = this.Invoke("GetAllTaskCommentByUserIdTaskId", new object[] {
                        taskId,
                        userId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetAllTaskCommentByUserIdTaskIdAsync(string taskId, string userId) {
            this.GetAllTaskCommentByUserIdTaskIdAsync(taskId, userId, null);
        }
        
        /// <remarks/>
        public void GetAllTaskCommentByUserIdTaskIdAsync(string taskId, string userId, object userState) {
            if ((this.GetAllTaskCommentByUserIdTaskIdOperationCompleted == null)) {
                this.GetAllTaskCommentByUserIdTaskIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAllTaskCommentByUserIdTaskIdOperationCompleted);
            }
            this.InvokeAsync("GetAllTaskCommentByUserIdTaskId", new object[] {
                        taskId,
                        userId}, this.GetAllTaskCommentByUserIdTaskIdOperationCompleted, userState);
        }
        
        private void OnGetAllTaskCommentByUserIdTaskIdOperationCompleted(object arg) {
            if ((this.GetAllTaskCommentByUserIdTaskIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAllTaskCommentByUserIdTaskIdCompleted(this, new GetAllTaskCommentByUserIdTaskIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddTaskComment", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string AddTaskComment(string comment, string userId, string taskId, string commentDate, System.DateTime entryDate) {
            object[] results = this.Invoke("AddTaskComment", new object[] {
                        comment,
                        userId,
                        taskId,
                        commentDate,
                        entryDate});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void AddTaskCommentAsync(string comment, string userId, string taskId, string commentDate, System.DateTime entryDate) {
            this.AddTaskCommentAsync(comment, userId, taskId, commentDate, entryDate, null);
        }
        
        /// <remarks/>
        public void AddTaskCommentAsync(string comment, string userId, string taskId, string commentDate, System.DateTime entryDate, object userState) {
            if ((this.AddTaskCommentOperationCompleted == null)) {
                this.AddTaskCommentOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddTaskCommentOperationCompleted);
            }
            this.InvokeAsync("AddTaskComment", new object[] {
                        comment,
                        userId,
                        taskId,
                        commentDate,
                        entryDate}, this.AddTaskCommentOperationCompleted, userState);
        }
        
        private void OnAddTaskCommentOperationCompleted(object arg) {
            if ((this.AddTaskCommentCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddTaskCommentCompleted(this, new AddTaskCommentCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public delegate void GetAllTaskCommentByUserIdTaskIdCompletedEventHandler(object sender, GetAllTaskCommentByUserIdTaskIdCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAllTaskCommentByUserIdTaskIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAllTaskCommentByUserIdTaskIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void AddTaskCommentCompletedEventHandler(object sender, AddTaskCommentCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddTaskCommentCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddTaskCommentCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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