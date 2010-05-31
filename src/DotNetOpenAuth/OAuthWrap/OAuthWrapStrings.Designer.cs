﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30426.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DotNetOpenAuth.OAuthWrap {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class OAuthWrapStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal OAuthWrapStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DotNetOpenAuth.OAuthWrap.OAuthWrapStrings", typeof(OAuthWrapStrings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Client&apos;s pre-registered callback URL ({0}) does not match the one found in the authorization request ({1})..
        /// </summary>
        internal static string CallbackMismatch {
            get {
                return ResourceManager.GetString("CallbackMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to obtain access token.  Authorization Server reports reason: {0}.
        /// </summary>
        internal static string CannotObtainAccessTokenWithReason {
            get {
                return ResourceManager.GetString("CannotObtainAccessTokenWithReason", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This message can only be sent over HTTPS..
        /// </summary>
        internal static string HttpsRequired {
            get {
                return ResourceManager.GetString("HttpsRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to obtain access token due to invalid Client Identifier or Client Secret..
        /// </summary>
        internal static string InvalidClientCredentials {
            get {
                return ResourceManager.GetString("InvalidClientCredentials", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No callback URI was available for this request..
        /// </summary>
        internal static string NoCallback {
            get {
                return ResourceManager.GetString("NoCallback", resourceCulture);
            }
        }
    }
}