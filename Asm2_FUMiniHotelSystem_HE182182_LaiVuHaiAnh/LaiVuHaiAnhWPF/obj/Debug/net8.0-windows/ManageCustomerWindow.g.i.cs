﻿#pragma checksum "..\..\..\ManageCustomerWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95AB95FCC38A9E6E1CC29DB3E437F3590A5E5C6A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LaiVuHaiAnhWPF;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace LaiVuHaiAnhWPF {
    
    
    /// <summary>
    /// ManageCustomerWindow
    /// </summary>
    public partial class ManageCustomerWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 52 "..\..\..\ManageCustomerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLoadCustomer;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\ManageCustomerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddCustomer;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\ManageCustomerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUpdateCustomer;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\ManageCustomerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDeleteCustomer;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\..\ManageCustomerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSearchCustomer;
        
        #line default
        #line hidden
        
        
        #line 144 "..\..\..\ManageCustomerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSearchCustomer;
        
        #line default
        #line hidden
        
        
        #line 166 "..\..\..\ManageCustomerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCustomerID;
        
        #line default
        #line hidden
        
        
        #line 173 "..\..\..\ManageCustomerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgData;
        
        #line default
        #line hidden
        
        
        #line 199 "..\..\..\ManageCustomerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLogout1;
        
        #line default
        #line hidden
        
        
        #line 216 "..\..\..\ManageCustomerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/LaiVuHaiAnhWPF;component/managecustomerwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ManageCustomerWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\ManageCustomerWindow.xaml"
            ((LaiVuHaiAnhWPF.ManageCustomerWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnLoadCustomer = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\ManageCustomerWindow.xaml"
            this.btnLoadCustomer.Click += new System.Windows.RoutedEventHandler(this.btnLoadCustomer_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnAddCustomer = ((System.Windows.Controls.Button)(target));
            
            #line 71 "..\..\..\ManageCustomerWindow.xaml"
            this.btnAddCustomer.Click += new System.Windows.RoutedEventHandler(this.btnCreate_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnUpdateCustomer = ((System.Windows.Controls.Button)(target));
            
            #line 89 "..\..\..\ManageCustomerWindow.xaml"
            this.btnUpdateCustomer.Click += new System.Windows.RoutedEventHandler(this.btnUpdate_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnDeleteCustomer = ((System.Windows.Controls.Button)(target));
            
            #line 106 "..\..\..\ManageCustomerWindow.xaml"
            this.btnDeleteCustomer.Click += new System.Windows.RoutedEventHandler(this.btnDelete_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnSearchCustomer = ((System.Windows.Controls.Button)(target));
            
            #line 127 "..\..\..\ManageCustomerWindow.xaml"
            this.btnSearchCustomer.Click += new System.Windows.RoutedEventHandler(this.btnSearchCustomer_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtSearchCustomer = ((System.Windows.Controls.TextBox)(target));
            
            #line 146 "..\..\..\ManageCustomerWindow.xaml"
            this.txtSearchCustomer.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtSearchCustomer_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.txtCustomerID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.dgData = ((System.Windows.Controls.DataGrid)(target));
            
            #line 174 "..\..\..\ManageCustomerWindow.xaml"
            this.dgData.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgData_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnLogout1 = ((System.Windows.Controls.Button)(target));
            
            #line 204 "..\..\..\ManageCustomerWindow.xaml"
            this.btnLogout1.Click += new System.Windows.RoutedEventHandler(this.btnLogout1_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btnClose = ((System.Windows.Controls.Button)(target));
            
            #line 220 "..\..\..\ManageCustomerWindow.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

