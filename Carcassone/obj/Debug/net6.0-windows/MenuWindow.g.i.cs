﻿#pragma checksum "..\..\..\MenuWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "843846AEF0B29892636F8E380365D266DB182B3A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Carcassone;
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


namespace Carcassone {
    
    
    /// <summary>
    /// MenuWindow
    /// </summary>
    public partial class MenuWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 41 "..\..\..\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnTalcaraTesz;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnKi;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\..\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbZene;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\..\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBe;
        
        #line default
        #line hidden
        
        
        #line 182 "..\..\..\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider sliHangero;
        
        #line default
        #line hidden
        
        
        #line 220 "..\..\..\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbFelbontas;
        
        #line default
        #line hidden
        
        
        #line 240 "..\..\..\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider sliFelbontas;
        
        #line default
        #line hidden
        
        
        #line 261 "..\..\..\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnExit;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Carcassone;component/menuwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MenuWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 14 "..\..\..\MenuWindow.xaml"
            ((Carcassone.MenuWindow)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnTalcaraTesz = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\MenuWindow.xaml"
            this.btnTalcaraTesz.Click += new System.Windows.RoutedEventHandler(this.btnTalcaraTesz_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnKi = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\..\MenuWindow.xaml"
            this.btnKi.Click += new System.Windows.RoutedEventHandler(this.btnKi_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lbZene = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.btnBe = ((System.Windows.Controls.Button)(target));
            
            #line 133 "..\..\..\MenuWindow.xaml"
            this.btnBe.Click += new System.Windows.RoutedEventHandler(this.btnBe_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.sliHangero = ((System.Windows.Controls.Slider)(target));
            return;
            case 7:
            this.lbFelbontas = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.sliFelbontas = ((System.Windows.Controls.Slider)(target));
            
            #line 249 "..\..\..\MenuWindow.xaml"
            this.sliFelbontas.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.sliFelbontas_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnExit = ((System.Windows.Controls.Button)(target));
            
            #line 271 "..\..\..\MenuWindow.xaml"
            this.btnExit.MouseEnter += new System.Windows.Input.MouseEventHandler(this.btnExit_MouseEnter);
            
            #line default
            #line hidden
            
            #line 272 "..\..\..\MenuWindow.xaml"
            this.btnExit.MouseLeave += new System.Windows.Input.MouseEventHandler(this.btnExit_MouseLeave);
            
            #line default
            #line hidden
            
            #line 273 "..\..\..\MenuWindow.xaml"
            this.btnExit.Click += new System.Windows.RoutedEventHandler(this.btnExit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

