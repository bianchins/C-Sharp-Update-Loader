﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:2.0.50727.3623
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

namespace grafLoader.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "8.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("c:\\prenotaMI\\prenotazioni.exe")]
        public string eseguibileLocale {
            get {
                return ((string)(this["eseguibileLocale"]));
            }
            set {
                this["eseguibileLocale"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("p:\\prenotaMI\\update\\prenotazioni.exe")]
        public string eseguibileRemoto {
            get {
                return ((string)(this["eseguibileRemoto"]));
            }
            set {
                this["eseguibileRemoto"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("c:\\prenotaMI\\")]
        public string cartellaLocale {
            get {
                return ((string)(this["cartellaLocale"]));
            }
            set {
                this["cartellaLocale"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("p:\\prenotaMI\\update")]
        public string cartellaRemota {
            get {
                return ((string)(this["cartellaRemota"]));
            }
            set {
                this["cartellaRemota"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("A 18")]
        public string parametri {
            get {
                return ((string)(this["parametri"]));
            }
            set {
                this["parametri"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Prenotazioni Ambulatori")]
        public string nomeProgramma {
            get {
                return ((string)(this["nomeProgramma"]));
            }
            set {
                this["nomeProgramma"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection copiaSoloQuestiFiles {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["copiaSoloQuestiFiles"]));
            }
            set {
                this["copiaSoloQuestiFiles"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool copiaTutto {
            get {
                return ((bool)(this["copiaTutto"]));
            }
            set {
                this["copiaTutto"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string eseguiDa {
            get {
                return ((string)(this["eseguiDa"]));
            }
            set {
                this["eseguiDa"] = value;
            }
        }
    }
}
