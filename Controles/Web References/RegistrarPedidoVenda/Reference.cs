﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Este código-fonte foi gerado automaticamente por Microsoft.VSDesigner, Versão 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace Controles.RegistrarPedidoVenda {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="RegistroVendaSoap", Namespace="http://tempuri.org/")]
    public partial class RegistroVenda : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback RegistrarVendaOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public RegistroVenda() {
            this.Url = global::Controles.Properties.Settings.Default.Controles_RegistrarPedidoVenda_RegistroVenda;
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
        public event RegistrarVendaCompletedEventHandler RegistrarVendaCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/RegistrarVenda", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string RegistrarVenda(int IdFilial, System.Xml.XmlNode XmlCadPessoa, System.Xml.XmlNode XmlVenda, System.Xml.XmlNode XmlItens) {
            object[] results = this.Invoke("RegistrarVenda", new object[] {
                        IdFilial,
                        XmlCadPessoa,
                        XmlVenda,
                        XmlItens});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void RegistrarVendaAsync(int IdFilial, System.Xml.XmlNode XmlCadPessoa, System.Xml.XmlNode XmlVenda, System.Xml.XmlNode XmlItens) {
            this.RegistrarVendaAsync(IdFilial, XmlCadPessoa, XmlVenda, XmlItens, null);
        }
        
        /// <remarks/>
        public void RegistrarVendaAsync(int IdFilial, System.Xml.XmlNode XmlCadPessoa, System.Xml.XmlNode XmlVenda, System.Xml.XmlNode XmlItens, object userState) {
            if ((this.RegistrarVendaOperationCompleted == null)) {
                this.RegistrarVendaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRegistrarVendaOperationCompleted);
            }
            this.InvokeAsync("RegistrarVenda", new object[] {
                        IdFilial,
                        XmlCadPessoa,
                        XmlVenda,
                        XmlItens}, this.RegistrarVendaOperationCompleted, userState);
        }
        
        private void OnRegistrarVendaOperationCompleted(object arg) {
            if ((this.RegistrarVendaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RegistrarVendaCompleted(this, new RegistrarVendaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void RegistrarVendaCompletedEventHandler(object sender, RegistrarVendaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RegistrarVendaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal RegistrarVendaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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