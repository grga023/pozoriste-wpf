#pragma checksum "..\..\Pozorista.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "758077642E225F4F9B421BACBEE87790E7A3D8E1AD398C69A70553423F865843"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PozoristeSeminarski;
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


namespace PozoristeSeminarski {
    
    
    /// <summary>
    /// Pozorista
    /// </summary>
    public partial class Pozorista : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 65 "..\..\Pozorista.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button txtpredstave;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\Pozorista.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button txtizvodjenjePredstava;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\Pozorista.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button txtSale;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\Pozorista.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button txtSedista;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\Pozorista.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button txtLoout;
        
        #line default
        #line hidden
        
        
        #line 157 "..\..\Pozorista.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNaziv;
        
        #line default
        #line hidden
        
        
        #line 165 "..\..\Pozorista.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAdresa;
        
        #line default
        #line hidden
        
        
        #line 173 "..\..\Pozorista.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox PTT;
        
        #line default
        #line hidden
        
        
        #line 175 "..\..\Pozorista.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ID;
        
        #line default
        #line hidden
        
        
        #line 206 "..\..\Pozorista.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid PozoristaDataGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/PozoristeSeminarski;component/pozorista.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Pozorista.xaml"
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
            this.txtpredstave = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\Pozorista.xaml"
            this.txtpredstave.Click += new System.Windows.RoutedEventHandler(this.btnPredstave_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtizvodjenjePredstava = ((System.Windows.Controls.Button)(target));
            
            #line 79 "..\..\Pozorista.xaml"
            this.txtizvodjenjePredstava.Click += new System.Windows.RoutedEventHandler(this.btnIzvodjenjePredstava_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtSale = ((System.Windows.Controls.Button)(target));
            
            #line 90 "..\..\Pozorista.xaml"
            this.txtSale.Click += new System.Windows.RoutedEventHandler(this.btnSale_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtSedista = ((System.Windows.Controls.Button)(target));
            
            #line 101 "..\..\Pozorista.xaml"
            this.txtSedista.Click += new System.Windows.RoutedEventHandler(this.btnSedista_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtLoout = ((System.Windows.Controls.Button)(target));
            
            #line 112 "..\..\Pozorista.xaml"
            this.txtLoout.Click += new System.Windows.RoutedEventHandler(this.txtLoout_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtNaziv = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtAdresa = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.PTT = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.ID = ((System.Windows.Controls.ComboBox)(target));
            
            #line 175 "..\..\Pozorista.xaml"
            this.ID.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ID_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 182 "..\..\Pozorista.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnDodaj_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 191 "..\..\Pozorista.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnIzmeni_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 200 "..\..\Pozorista.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnObrisi_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.PozoristaDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

