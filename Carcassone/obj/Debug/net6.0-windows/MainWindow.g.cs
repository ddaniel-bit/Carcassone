﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A56FD854DDDC9E82AD02BF1E7FFC3CC8403118B7"
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
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnTalcaraTesz;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnStart;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSettings;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLeaderboard;
        
        #line default
        #line hidden
        
        
        #line 139 "..\..\..\MainWindow.xaml"
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
            System.Uri resourceLocater = new System.Uri("/Carcassone;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
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
            
            #line 14 "..\..\..\MainWindow.xaml"
            ((Carcassone.MainWindow)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnTalcaraTesz = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\MainWindow.xaml"
            this.btnTalcaraTesz.Click += new System.Windows.RoutedEventHandler(this.btnTalcaraTesz_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnStart = ((System.Windows.Controls.Button)(target));
            
            #line 70 "..\..\..\MainWindow.xaml"
            this.btnStart.Click += new System.Windows.RoutedEventHandler(this.btnStart_Click);
            
            #line default
            #line hidden
            
            #line 71 "..\..\..\MainWindow.xaml"
            this.btnStart.MouseEnter += new System.Windows.Input.MouseEventHandler(this.btnStart_MouseEnter);
            
            #line default
            #line hidden
            
            #line 72 "..\..\..\MainWindow.xaml"
            this.btnStart.MouseLeave += new System.Windows.Input.MouseEventHandler(this.btnStart_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnSettings = ((System.Windows.Controls.Button)(target));
            
            #line 96 "..\..\..\MainWindow.xaml"
            this.btnSettings.MouseEnter += new System.Windows.Input.MouseEventHandler(this.btnSettings_MouseEnter);
            
            #line default
            #line hidden
            
            #line 97 "..\..\..\MainWindow.xaml"
            this.btnSettings.MouseLeave += new System.Windows.Input.MouseEventHandler(this.btnSettings_MouseLeave);
            
            #line default
            #line hidden
            
            #line 98 "..\..\..\MainWindow.xaml"
            this.btnSettings.Click += new System.Windows.RoutedEventHandler(this.btnSettings_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnLeaderboard = ((System.Windows.Controls.Button)(target));
            
            #line 121 "..\..\..\MainWindow.xaml"
            this.btnLeaderboard.MouseEnter += new System.Windows.Input.MouseEventHandler(this.btnLeaderboard_MouseEnter);
            
            #line default
            #line hidden
            
            #line 122 "..\..\..\MainWindow.xaml"
            this.btnLeaderboard.MouseLeave += new System.Windows.Input.MouseEventHandler(this.btnLeaderboard_MouseLeave);
            
            #line default
            #line hidden
            
            #line 123 "..\..\..\MainWindow.xaml"
            this.btnLeaderboard.Click += new System.Windows.RoutedEventHandler(this.btnLeaderboard_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnExit = ((System.Windows.Controls.Button)(target));
            
            #line 147 "..\..\..\MainWindow.xaml"
            this.btnExit.MouseEnter += new System.Windows.Input.MouseEventHandler(this.btnExit_MouseEnter);
            
            #line default
            #line hidden
            
            #line 148 "..\..\..\MainWindow.xaml"
            this.btnExit.MouseLeave += new System.Windows.Input.MouseEventHandler(this.btnExit_MouseLeave);
            
            #line default
            #line hidden
            
            #line 149 "..\..\..\MainWindow.xaml"
            this.btnExit.Click += new System.Windows.RoutedEventHandler(this.btnExit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

