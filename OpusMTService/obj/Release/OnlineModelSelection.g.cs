﻿#pragma checksum "..\..\OnlineModelSelection.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D3762E05B6B6C2D8C2C4F4F3131266F11D6E1C14D92A75E6E6A5229B5D63369B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FiskmoMTEngine;
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


namespace FiskmoMTEngine {
    
    
    /// <summary>
    /// OnlineModelSelection
    /// </summary>
    public partial class OnlineModelSelection : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\OnlineModelSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFilter;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\OnlineModelSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFilter1;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\OnlineModelSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFilter2;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\OnlineModelSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button install;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\OnlineModelSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ModelListView;
        
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
            System.Uri resourceLocater = new System.Uri("/FiskmoMTEngine;component/onlinemodelselection.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\OnlineModelSelection.xaml"
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
            this.txtFilter = ((System.Windows.Controls.TextBox)(target));
            
            #line 34 "..\..\OnlineModelSelection.xaml"
            this.txtFilter.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.sourceLangFilter_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtFilter1 = ((System.Windows.Controls.TextBox)(target));
            
            #line 35 "..\..\OnlineModelSelection.xaml"
            this.txtFilter1.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.targetLangFilter_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtFilter2 = ((System.Windows.Controls.TextBox)(target));
            
            #line 36 "..\..\OnlineModelSelection.xaml"
            this.txtFilter2.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.nameFilter_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.install = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\OnlineModelSelection.xaml"
            this.install.Click += new System.Windows.RoutedEventHandler(this.btnInstall_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ModelListView = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

