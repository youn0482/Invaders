﻿#pragma checksum "C:\Users\Matt\documents\visual studio 2015\Projects\Invaders\Invaders\HowToPlay.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3E3C27F37D74617984CD54931333F05F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Invaders
{
    partial class HowToPlay : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.howToBackBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 83 "..\..\..\HowToPlay.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.howToBackBtn).Click += this.howToBackBtn_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.howToPlayBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 3:
                {
                    this.settingsBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 40 "..\..\..\HowToPlay.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.settingsBtn).Click += this.settingsBtn_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.howBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 5:
                {
                    this.aboutBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 68 "..\..\..\HowToPlay.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.aboutBtn).Click += this.aboutBtn_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

