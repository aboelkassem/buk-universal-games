﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Buk.UniversalGames.Library.Cultures {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Buk.UniversalGames.Library.Cultures.Strings", typeof(Strings).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to minutter.
        /// </summary>
        public static string Minutes {
            get {
                return ResourceManager.GetString("Minutes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No team code specified.
        /// </summary>
        public static string MissingTeamCode {
            get {
                return ResourceManager.GetString("MissingTeamCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This feature is only allowed for participants.
        /// </summary>
        public static string ParticipantsOnly {
            get {
                return ResourceManager.GetString("ParticipantsOnly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sorry, your team has scanned this sticker {times} times allready.
        /// </summary>
        public static string ScanErrorScannedBefore {
            get {
                return ResourceManager.GetString("ScanErrorScannedBefore", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sorry, another teammate scanned this sticker {time} {unit} ago.
        /// </summary>
        public static string ScanErrorScannedLastTime {
            get {
                return ResourceManager.GetString("ScanErrorScannedLastTime", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nice! You found a new sticker and {points} points to your team!.
        /// </summary>
        public static string ScanSuccessPointsInfo {
            get {
                return ResourceManager.GetString("ScanSuccessPointsInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to sekunder.
        /// </summary>
        public static string Seconds {
            get {
                return ResourceManager.GetString("Seconds", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sorry, your team does not have access to this feature.
        /// </summary>
        public static string TeamUnathorized {
            get {
                return ResourceManager.GetString("TeamUnathorized", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sorry, this is not a valid sticker key.
        /// </summary>
        public static string UnknownStickerCode {
            get {
                return ResourceManager.GetString("UnknownStickerCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sorry, your team key is not valid.
        /// </summary>
        public static string UnknownTeamCode {
            get {
                return ResourceManager.GetString("UnknownTeamCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sorry, you&apos;re a little off course. This sticker belongs to another league.
        /// </summary>
        public static string WrongLeagueSticker {
            get {
                return ResourceManager.GetString("WrongLeagueSticker", resourceCulture);
            }
        }
    }
}