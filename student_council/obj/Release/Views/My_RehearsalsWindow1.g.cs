﻿#pragma checksum "..\..\..\Views\My_RehearsalsWindow1.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D0AABBAC3534B3A5F13E6223BFFAA45E6C40C1494CC874CE0D99CA18259E2BAE"
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
    /// My_RehearsalsWindow1
    /// </summary>
    public partial class My_RehearsalsWindow1 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\Views\My_RehearsalsWindow1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_exit;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Views\My_RehearsalsWindow1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DGridMyRehearsals;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Views\My_RehearsalsWindow1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn column_date;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Views\My_RehearsalsWindow1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn column_creater_surname;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Views\My_RehearsalsWindow1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn column_creater_name;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Views\My_RehearsalsWindow1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn column_creater_patronymic;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Views\My_RehearsalsWindow1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn column_post;
        
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
            System.Uri resourceLocater = new System.Uri("/student_council;component/views/my_rehearsalswindow1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\My_RehearsalsWindow1.xaml"
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
            this.btn_exit = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\Views\My_RehearsalsWindow1.xaml"
            this.btn_exit.Click += new System.Windows.RoutedEventHandler(this.btn_exit_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DGridMyRehearsals = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.column_date = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 4:
            this.column_creater_surname = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 5:
            this.column_creater_name = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 6:
            this.column_creater_patronymic = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 7:
            this.column_post = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
