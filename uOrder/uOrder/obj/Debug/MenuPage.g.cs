﻿#pragma checksum "..\..\MenuPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0BA2DD185C9DDB25FE638A98997A61A4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
using uOrder;


namespace uOrder {
    
    
    /// <summary>
    /// MenuPage
    /// </summary>
    public partial class MenuPage : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\MenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel order_stack;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\MenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label sub_label;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\MenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label gst_label;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\MenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label tot_label;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\MenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button order;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\MenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel page_viewer;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\MenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl menu;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\MenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button tpiaj;
        
        #line default
        #line hidden
        
        
        #line 643 "..\..\MenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle kb_background;
        
        #line default
        #line hidden
        
        
        #line 644 "..\..\MenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image kb;
        
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
            System.Uri resourceLocater = new System.Uri("/uOrder;component/menupage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MenuPage.xaml"
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
            this.order_stack = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.sub_label = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.gst_label = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.tot_label = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.order = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\MenuPage.xaml"
            this.order.Click += new System.Windows.RoutedEventHandler(this.order_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.page_viewer = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 7:
            this.menu = ((System.Windows.Controls.TabControl)(target));
            return;
            case 8:
            this.tpiaj = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\MenuPage.xaml"
            this.tpiaj.Click += new System.Windows.RoutedEventHandler(this.tpiaj_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 40 "..\..\MenuPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.kfc_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 47 "..\..\MenuPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.c_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 54 "..\..\MenuPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.b_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 61 "..\..\MenuPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ps_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 68 "..\..\MenuPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.mb_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 75 "..\..\MenuPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.dr_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 82 "..\..\MenuPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.sc_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 89 "..\..\MenuPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.icf_Click);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 97 "..\..\MenuPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.md_Click);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 104 "..\..\MenuPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.scc_Click);
            
            #line default
            #line hidden
            return;
            case 19:
            
            #line 111 "..\..\MenuPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.cw_Click);
            
            #line default
            #line hidden
            return;
            case 20:
            
            #line 118 "..\..\MenuPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.lw_Click);
            
            #line default
            #line hidden
            return;
            case 21:
            
            #line 126 "..\..\MenuPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.dcnsp_Click);
            
            #line default
            #line hidden
            return;
            case 22:
            
            #line 409 "..\..\MenuPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.not_available_Click);
            
            #line default
            #line hidden
            return;
            case 23:
            this.kb_background = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 24:
            this.kb = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

