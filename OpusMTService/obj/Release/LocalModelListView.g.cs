﻿#pragma checksum "..\..\LocalModelListView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C50A6F642A1313A37D32ACAD52DD855237C9953B30A1BDB98B949B31F440D09F"
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
    /// LocalModelListView
    /// </summary>
    public partial class LocalModelListView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\LocalModelListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addOnlineModel;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\LocalModelListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addZipModel;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\LocalModelListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deleteModel;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\LocalModelListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button translateWithModel;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\LocalModelListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addModelTag;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\LocalModelListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button openModelDir;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\LocalModelListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LocalModelList;
        
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
            System.Uri resourceLocater = new System.Uri("/FiskmoMTEngine;component/localmodellistview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\LocalModelListView.xaml"
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
            this.addOnlineModel = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\LocalModelListView.xaml"
            this.addOnlineModel.Click += new System.Windows.RoutedEventHandler(this.btnAddOnlineModel_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.addZipModel = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\LocalModelListView.xaml"
            this.addZipModel.Click += new System.Windows.RoutedEventHandler(this.btnAddZipModel_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.deleteModel = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\LocalModelListView.xaml"
            this.deleteModel.Click += new System.Windows.RoutedEventHandler(this.btnDeleteModel_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.translateWithModel = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\LocalModelListView.xaml"
            this.translateWithModel.Click += new System.Windows.RoutedEventHandler(this.btnTranslateWithModel_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.addModelTag = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\LocalModelListView.xaml"
            this.addModelTag.Click += new System.Windows.RoutedEventHandler(this.btnEditModelTags_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.openModelDir = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\LocalModelListView.xaml"
            this.openModelDir.Click += new System.Windows.RoutedEventHandler(this.btnOpenModelDir_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.LocalModelList = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

