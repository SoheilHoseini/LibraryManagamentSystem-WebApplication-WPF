﻿#pragma checksum "..\..\employee_personal_info.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DBC3D90A09737321B2D984EAFBDACE5CC27848D592F0CEF15F4A8F5F9EF75208"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using WpfApp1;


namespace WpfApp1 {
    
    
    /// <summary>
    /// employee_personal_info
    /// </summary>
    public partial class employee_personal_info : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\employee_personal_info.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock nametxt;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\employee_personal_info.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock usernametxt;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\employee_personal_info.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock date;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\employee_personal_info.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox email;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\employee_personal_info.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox oldpass;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\employee_personal_info.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox newpass;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\employee_personal_info.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox newpassrepeat;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\employee_personal_info.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button chemail;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\employee_personal_info.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button chpass;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/employee_personal_info.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\employee_personal_info.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.nametxt = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.usernametxt = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.date = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.email = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.oldpass = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.newpass = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.newpassrepeat = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.chemail = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\employee_personal_info.xaml"
            this.chemail.Click += new System.Windows.RoutedEventHandler(this.chemail_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.chpass = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\employee_personal_info.xaml"
            this.chpass.Click += new System.Windows.RoutedEventHandler(this.chpass_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 28 "..\..\employee_personal_info.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
