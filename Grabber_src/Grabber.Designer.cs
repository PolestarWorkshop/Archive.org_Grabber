﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Grabber {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Grabber : global::System.Configuration.ApplicationSettingsBase {
        
        private static Grabber defaultInstance = ((Grabber)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Grabber())));
        
        public static Grabber Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://archive.org/advancedsearch.php?q=")]
        public string queryURL {
            get {
                return ((string)(this["queryURL"]));
            }
            set {
                this["queryURL"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("json")]
        public string output {
            get {
                return ((string)(this["output"]));
            }
            set {
                this["output"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.2")]
        public double version {
            get {
                return ((double)(this["version"]));
            }
            set {
                this["version"] = value;
            }
        }
    }
}
