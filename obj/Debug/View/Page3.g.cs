﻿#pragma checksum "..\..\..\View\Page3.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2D4C825DFAED9E0293EC66CBAD11D4B5471EC54FD625E6C0AD9542A172217260"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FlightSimulatorApp.View;
using FlightSimulatorApp.ViewModel;
using OxyPlot.Wpf;
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


namespace FlightSimulatorApp.View {
    
    
    /// <summary>
    /// Page3
    /// </summary>
    public partial class Page3 : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\View\Page3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView List;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\View\Page3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal OxyPlot.Wpf.Plot Graph;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\View\Page3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal OxyPlot.Wpf.LineSeries GraphPoints;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\View\Page3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal OxyPlot.Wpf.Plot Graph_Correlative;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\View\Page3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal OxyPlot.Wpf.LineSeries GraphPoints_Correlative;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\View\Page3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal OxyPlot.Wpf.Plot Graph_Regression;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\View\Page3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal OxyPlot.Wpf.LineSeries GraphPoints_Regression;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\View\Page3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal OxyPlot.Wpf.LineSeries GraphPoints_Line;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\View\Page3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal OxyPlot.Wpf.LineSeries GraphPoints_30Seconds;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\View\Page3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\View\Page3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame _mainFrame;
        
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
            System.Uri resourceLocater = new System.Uri("/FlightSimulatorApp;component/view/page3.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\Page3.xaml"
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
            this.List = ((System.Windows.Controls.ListView)(target));
            
            #line 31 "..\..\..\View\Page3.xaml"
            this.List.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.List_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Graph = ((OxyPlot.Wpf.Plot)(target));
            return;
            case 3:
            this.GraphPoints = ((OxyPlot.Wpf.LineSeries)(target));
            return;
            case 4:
            this.Graph_Correlative = ((OxyPlot.Wpf.Plot)(target));
            return;
            case 5:
            this.GraphPoints_Correlative = ((OxyPlot.Wpf.LineSeries)(target));
            return;
            case 6:
            this.Graph_Regression = ((OxyPlot.Wpf.Plot)(target));
            return;
            case 7:
            this.GraphPoints_Regression = ((OxyPlot.Wpf.LineSeries)(target));
            return;
            case 8:
            this.GraphPoints_Line = ((OxyPlot.Wpf.LineSeries)(target));
            return;
            case 9:
            this.GraphPoints_30Seconds = ((OxyPlot.Wpf.LineSeries)(target));
            return;
            case 10:
            this.button = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\..\View\Page3.xaml"
            this.button.Click += new System.Windows.RoutedEventHandler(this.Go_Controls);
            
            #line default
            #line hidden
            return;
            case 11:
            this._mainFrame = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

