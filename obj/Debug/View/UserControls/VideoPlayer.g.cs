﻿#pragma checksum "..\..\..\..\View\UserControls\VideoPlayer.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A31C51BCD06237B8B08DF91AF3DFE7F46FFC45D45E277D26EA756CB28EE4E477"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FlightSimulatorApp.View.UserControls;
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


namespace FlightSimulatorApp.View.UserControls {
    
    
    /// <summary>
    /// VideoPlayer
    /// </summary>
    public partial class VideoPlayer : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\..\View\UserControls\VideoPlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid text;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\View\UserControls\VideoPlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Play;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\View\UserControls\VideoPlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Pause;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\View\UserControls\VideoPlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider Slider_Time;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\View\UserControls\VideoPlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Speed;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\View\UserControls\VideoPlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem _05_Speed;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\View\UserControls\VideoPlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem _10_Speed;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\View\UserControls\VideoPlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem _15_Speed;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\View\UserControls\VideoPlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock RelativeTime;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\View\UserControls\VideoPlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock overall_Time;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\View\UserControls\VideoPlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock slash;
        
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
            System.Uri resourceLocater = new System.Uri("/FlightSimulatorApp;component/view/usercontrols/videoplayer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\UserControls\VideoPlayer.xaml"
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
            this.text = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.Play = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\..\View\UserControls\VideoPlayer.xaml"
            this.Play.Click += new System.Windows.RoutedEventHandler(this.Play_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Pause = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\..\View\UserControls\VideoPlayer.xaml"
            this.Pause.Click += new System.Windows.RoutedEventHandler(this.Pause_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Slider_Time = ((System.Windows.Controls.Slider)(target));
            return;
            case 5:
            this.Speed = ((System.Windows.Controls.ComboBox)(target));
            
            #line 40 "..\..\..\..\View\UserControls\VideoPlayer.xaml"
            this.Speed.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Speed_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this._05_Speed = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 7:
            this._10_Speed = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 8:
            this._15_Speed = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 9:
            this.RelativeTime = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.overall_Time = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.slash = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

