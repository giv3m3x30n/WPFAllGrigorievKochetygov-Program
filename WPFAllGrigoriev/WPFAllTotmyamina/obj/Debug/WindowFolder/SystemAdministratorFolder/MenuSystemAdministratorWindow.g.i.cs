﻿#pragma checksum "..\..\..\..\WindowFolder\SystemAdministratorFolder\MenuSystemAdministratorWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9D334C39A8907189C05FB93FE82B0FE143F51658325AD530F3DA66E47F0F2EFA"
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
using WPFAllTotmyamina.WindowFolder;


namespace WPFAllTotmyamina.WindowFolder {
    
    
    /// <summary>
    /// MenuSystemAdministratorWindow
    /// </summary>
    public partial class MenuSystemAdministratorWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 44 "..\..\..\..\WindowFolder\SystemAdministratorFolder\MenuSystemAdministratorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ListUserBtn;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\WindowFolder\SystemAdministratorFolder\MenuSystemAdministratorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddUserBtn;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\WindowFolder\SystemAdministratorFolder\MenuSystemAdministratorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ListOfProductsBtn;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\WindowFolder\SystemAdministratorFolder\MenuSystemAdministratorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ListOfOrdersBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/WPFAllTotmyamina;component/windowfolder/systemadministratorfolder/menusystemadmi" +
                    "nistratorwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\WindowFolder\SystemAdministratorFolder\MenuSystemAdministratorWindow.xaml"
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
            this.ListUserBtn = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\..\WindowFolder\SystemAdministratorFolder\MenuSystemAdministratorWindow.xaml"
            this.ListUserBtn.Click += new System.Windows.RoutedEventHandler(this.ListUserBtn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.AddUserBtn = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\..\WindowFolder\SystemAdministratorFolder\MenuSystemAdministratorWindow.xaml"
            this.AddUserBtn.Click += new System.Windows.RoutedEventHandler(this.AddUserBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ListOfProductsBtn = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\..\..\WindowFolder\SystemAdministratorFolder\MenuSystemAdministratorWindow.xaml"
            this.ListOfProductsBtn.Click += new System.Windows.RoutedEventHandler(this.ListOfProductsBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ListOfOrdersBtn = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\..\..\WindowFolder\SystemAdministratorFolder\MenuSystemAdministratorWindow.xaml"
            this.ListOfOrdersBtn.Click += new System.Windows.RoutedEventHandler(this.ListOfOrdersBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
