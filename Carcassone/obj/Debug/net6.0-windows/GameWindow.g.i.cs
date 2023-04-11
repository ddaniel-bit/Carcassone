﻿#pragma checksum "..\..\..\GameWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B2084EE3F4BA0EE056971FBAA7A0BB18903F11B0"
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
    /// GameWindow
    /// </summary>
    public partial class GameWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gameGrid;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblDebug;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnTalcaraTesz;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image preview;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RotateRight;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgRotateRight;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RotateLeft;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgRotateLeft;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbVege;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnKiertekeles;
        
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
            System.Uri resourceLocater = new System.Uri("/Carcassone;component/gamewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\GameWindow.xaml"
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
            
            #line 14 "..\..\..\GameWindow.xaml"
            ((Carcassone.GameWindow)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 16 "..\..\..\GameWindow.xaml"
            ((System.Windows.Controls.Border)(target)).PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.Border_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.gameGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.lblDebug = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.btnTalcaraTesz = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\GameWindow.xaml"
            this.btnTalcaraTesz.Click += new System.Windows.RoutedEventHandler(this.btnTalcaraTesz_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.preview = ((System.Windows.Controls.Image)(target));
            return;
            case 7:
            this.RotateRight = ((System.Windows.Controls.Button)(target));
            
            #line 88 "..\..\..\GameWindow.xaml"
            this.RotateRight.Click += new System.Windows.RoutedEventHandler(this.RotateRight_Click_1);
            
            #line default
            #line hidden
            return;
            case 8:
            this.imgRotateRight = ((System.Windows.Controls.Image)(target));
            return;
            case 9:
            this.RotateLeft = ((System.Windows.Controls.Button)(target));
            
            #line 96 "..\..\..\GameWindow.xaml"
            this.RotateLeft.Click += new System.Windows.RoutedEventHandler(this.RotateLeft_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.imgRotateLeft = ((System.Windows.Controls.Image)(target));
            return;
            case 11:
            this.tbVege = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 12:
            this.btnKiertekeles = ((System.Windows.Controls.Button)(target));
            
            #line 140 "..\..\..\GameWindow.xaml"
            this.btnKiertekeles.Click += new System.Windows.RoutedEventHandler(this.btnKiertekeles_Click);
            
            #line default
            #line hidden
            
            #line 141 "..\..\..\GameWindow.xaml"
            this.btnKiertekeles.MouseEnter += new System.Windows.Input.MouseEventHandler(this.btnKiertekeles_MouseEnter);
            
            #line default
            #line hidden
            
            #line 142 "..\..\..\GameWindow.xaml"
            this.btnKiertekeles.MouseLeave += new System.Windows.Input.MouseEventHandler(this.btnKiertekeles_MouseLeave);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

