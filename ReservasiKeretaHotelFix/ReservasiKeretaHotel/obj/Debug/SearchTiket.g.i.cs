﻿#pragma checksum "..\..\SearchTiket.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ADCB1C0B28ABE2B317BC41931D30BB2F94A1C0A5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ReservasiKeretaHotel;
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


namespace ReservasiKeretaHotel {
    
    
    /// <summary>
    /// SearchTiket
    /// </summary>
    public partial class SearchTiket : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\SearchTiket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox combostasiunasal;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\SearchTiket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox combostasiuntujuan;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\SearchTiket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button reservation;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\SearchTiket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid jadwalGrid;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\SearchTiket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid tschedule;
        
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
            System.Uri resourceLocater = new System.Uri("/ReservasiKeretaHotel;component/searchtiket.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SearchTiket.xaml"
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
            
            #line 11 "..\..\SearchTiket.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.combostasiunasal = ((System.Windows.Controls.ComboBox)(target));
            
            #line 13 "..\..\SearchTiket.xaml"
            this.combostasiunasal.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.combostasiunasal_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.combostasiuntujuan = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.reservation = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.jadwalGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 20 "..\..\SearchTiket.xaml"
            this.jadwalGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.jadwalGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.tschedule = ((System.Windows.Controls.DataGrid)(target));
            
            #line 32 "..\..\SearchTiket.xaml"
            this.tschedule.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.tschedule_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

