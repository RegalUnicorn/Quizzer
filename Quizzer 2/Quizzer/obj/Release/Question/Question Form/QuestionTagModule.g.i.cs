﻿#pragma checksum "..\..\..\..\Question\Question Form\QuestionTagModule.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D9E6007F7C3295A8E0D87A8360144AA6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
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
using System.Windows.Forms.Integration;
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


namespace Quizzer_Classes {
    
    
    /// <summary>
    /// QuestionTagModule
    /// </summary>
    public partial class QuestionTagModule : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\..\Question\Question Form\QuestionTagModule.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTagSearch;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Question\Question Form\QuestionTagModule.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddTag;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\Question\Question Form\QuestionTagModule.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstSelectedTags;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Question\Question Form\QuestionTagModule.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstTags;
        
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
            System.Uri resourceLocater = new System.Uri("/Quizzer_Classes;component/question/question%20form/questiontagmodule.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Question\Question Form\QuestionTagModule.xaml"
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
            this.txtTagSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 22 "..\..\..\..\Question\Question Form\QuestionTagModule.xaml"
            this.txtTagSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnAddTag = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\..\Question\Question Form\QuestionTagModule.xaml"
            this.btnAddTag.Click += new System.Windows.RoutedEventHandler(this.btnAddTag_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lstSelectedTags = ((System.Windows.Controls.ListBox)(target));
            return;
            case 4:
            this.lstTags = ((System.Windows.Controls.ListBox)(target));
            
            #line 27 "..\..\..\..\Question\Question Form\QuestionTagModule.xaml"
            this.lstTags.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lstTags_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

