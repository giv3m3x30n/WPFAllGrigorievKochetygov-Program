#pragma checksum "..\..\..\..\WindowFolder\SystemAdministratorFolder\ListUserWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7759BE4BB260B7D8783B25A7585C8B35697CB8A9D9BEF1148027B526082223FF"
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
using WPFAllTotmyamina.WindowFolder.SystemAdministratorFolder;


namespace WPFAllTotmyamina.WindowFolder.SystemAdministratorFolder {
    
    
    /// <summary>
    /// ListUserWindow
    /// </summary>
    public partial class ListUserWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 41 "..\..\..\..\WindowFolder\SystemAdministratorFolder\ListUserWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchTb;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\WindowFolder\SystemAdministratorFolder\ListUserWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid UserDG;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\WindowFolder\SystemAdministratorFolder\ListUserWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn dgTcIdStaff;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\WindowFolder\SystemAdministratorFolder\ListUserWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn dgTcLastName;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\WindowFolder\SystemAdministratorFolder\ListUserWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn dgTcFirstName;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\WindowFolder\SystemAdministratorFolder\ListUserWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn dgTcMiddleName;
        
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
            System.Uri resourceLocater = new System.Uri("/WPFAllTotmyamina;component/windowfolder/systemadministratorfolder/listuserwindow" +
                    ".xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\WindowFolder\SystemAdministratorFolder\ListUserWindow.xaml"
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
            
            #line 11 "..\..\..\..\WindowFolder\SystemAdministratorFolder\ListUserWindow.xaml"
            ((WPFAllTotmyamina.WindowFolder.SystemAdministratorFolder.ListUserWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SearchTb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.UserDG = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.dgTcIdStaff = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 5:
            this.dgTcLastName = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 6:
            this.dgTcFirstName = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 7:
            this.dgTcMiddleName = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

