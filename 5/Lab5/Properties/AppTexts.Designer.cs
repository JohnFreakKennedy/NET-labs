//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Application.Properties {
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
    internal class AppTexts {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal AppTexts() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Application.Properties.AppTexts", typeof(AppTexts).Assembly);
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
        ///   Looks up a localized string similar to Please, choose the character: .
        /// </summary>
        internal static string ChooseCharacter {
            get {
                return ResourceManager.GetString("ChooseCharacter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please, choose the moving: .
        /// </summary>
        internal static string ChooseMoving {
            get {
                return ResourceManager.GetString("ChooseMoving", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please, enter the name: .
        /// </summary>
        internal static string EnterName {
            get {
                return ResourceManager.GetString("EnterName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to IS-02 - Zozuliuk Viktor - Variant 6.
        /// </summary>
        internal static string Label {
            get {
                return ResourceManager.GetString("Label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 1 - Elf
        ///2 - Harpy
        ///3 - Orc
        ///4 - Pegasus
        ///5 - Time Keeper
        ///6 - Troll
        ///7 - Vampire
        ///8 - Witch.
        /// </summary>
        internal static string Menu {
            get {
                return ResourceManager.GetString("Menu", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Game includes next characters:.
        /// </summary>
        internal static string MenuLabel {
            get {
                return ResourceManager.GetString("MenuLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sorry, I cannot..
        /// </summary>
        internal static string WrongAction {
            get {
                return ResourceManager.GetString("WrongAction", resourceCulture);
            }
        }
    }
}
