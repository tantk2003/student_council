﻿#pragma checksum "..\..\..\Views\Registration_Window.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6E3459B449E5DCA5EC890DA5926F1A9A46DAEE91B89E093B7E70F361C7A4C807"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using System.Windows.Forms.Integration;
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
using student_council.Views;


namespace student_council.Views {
    
    
    /// <summary>
    /// Registration_Window
    /// </summary>
    public partial class Registration_Window : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\Views\Registration_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox name_reg;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Views\Registration_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox surname_reg;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Views\Registration_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox patronmic_reg;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Views\Registration_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox faculty_reg;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Views\Registration_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox numgroup_reg;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Views\Registration_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox email_reg;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Views\Registration_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox login_reg;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Views\Registration_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox password_reg;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Views\Registration_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_signup;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Views\Registration_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_back;
        
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
            System.Uri resourceLocater = new System.Uri("/student_council;component/views/registration_window.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\Registration_Window.xaml"
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
            this.name_reg = ((System.Windows.Controls.TextBox)(target));
            
            #line 18 "..\..\..\Views\Registration_Window.xaml"
            this.name_reg.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.name_reg_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 2:
            this.surname_reg = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\..\Views\Registration_Window.xaml"
            this.surname_reg.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.name_reg_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 3:
            this.patronmic_reg = ((System.Windows.Controls.TextBox)(target));
            
            #line 24 "..\..\..\Views\Registration_Window.xaml"
            this.patronmic_reg.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.name_reg_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 4:
            this.faculty_reg = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.numgroup_reg = ((System.Windows.Controls.TextBox)(target));
            
            #line 30 "..\..\..\Views\Registration_Window.xaml"
            this.numgroup_reg.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.numgroup_reg_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 6:
            this.email_reg = ((System.Windows.Controls.TextBox)(target));
            
            #line 33 "..\..\..\Views\Registration_Window.xaml"
            this.email_reg.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.email_reg_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 7:
            this.login_reg = ((System.Windows.Controls.TextBox)(target));
            
            #line 36 "..\..\..\Views\Registration_Window.xaml"
            this.login_reg.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.email_reg_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 8:
            this.password_reg = ((System.Windows.Controls.TextBox)(target));
            
            #line 39 "..\..\..\Views\Registration_Window.xaml"
            this.password_reg.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.email_reg_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btn_signup = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\Views\Registration_Window.xaml"
            this.btn_signup.Click += new System.Windows.RoutedEventHandler(this.btn_signup_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btn_back = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\Views\Registration_Window.xaml"
            this.btn_back.Click += new System.Windows.RoutedEventHandler(this.btn_back_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
