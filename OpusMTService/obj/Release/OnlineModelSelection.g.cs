﻿#pragma checksum "..\..\OnlineModelSelection.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9F37BB50E72DEED8AACD4F31A35DB1CE6EC6E28A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using OpusMTService;
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


namespace OpusMTService {
    
    
    /// <summary>
    /// OnlineModelSelection
    /// </summary>
    public partial class OnlineModelSelection : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\OnlineModelSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button install;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\OnlineModelSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFilter;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\OnlineModelSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFilter1;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\OnlineModelSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFilter2;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\OnlineModelSelection.xaml"
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
            System.Uri resourceLocater = new System.Uri("/OpusMTService;component/onlinemodelselection.xaml", System.UriKind.Relative);
            
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
            this.install = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\OnlineModelSelection.xaml"
            this.install.Click += new System.Windows.RoutedEventHandler(this.btnInstall_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtFilter = ((System.Windows.Controls.TextBox)(target));
            
            #line 25 "..\..\OnlineModelSelection.xaml"
            this.txtFilter.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.sourceLangFilter_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtFilter1 = ((System.Windows.Controls.TextBox)(target));
            
            #line 26 "..\..\OnlineModelSelection.xaml"
            this.txtFilter1.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.targetLangFilter_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtFilter2 = ((System.Windows.Controls.TextBox)(target));
            
            #line 27 "..\..\OnlineModelSelection.xaml"
            this.txtFilter2.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.nameFilter_TextChanged);
            
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

