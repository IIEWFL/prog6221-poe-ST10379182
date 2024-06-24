// Updated by XamlIntelliSenseFileGenerator 6/24/2024 6:59:29 PM
#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "13DE72AAC0E9BE5E0A071B95817ECBED1319703FF2FF262E19D7F1ABFEF212A1"
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


namespace RecipeApp
{


    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/RecipeApp;component/mainwindow.xaml", System.UriKind.Relative);

#line 1 "..\..\MainWindow.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.RecipeNameTextBox = ((System.Windows.Controls.TextBox)(target));

#line 6 "..\..\MainWindow.xaml"
                    this.RecipeNameTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.RemovePlaceholderText);

#line default
#line hidden

#line 6 "..\..\MainWindow.xaml"
                    this.RecipeNameTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.ShowPlaceholderText);

#line default
#line hidden
                    return;
                case 2:
                    this.IngredientsTextBox = ((System.Windows.Controls.TextBox)(target));

#line 9 "..\..\MainWindow.xaml"
                    this.IngredientsTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.RemovePlaceholderText);

#line default
#line hidden

#line 9 "..\..\MainWindow.xaml"
                    this.IngredientsTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.ShowPlaceholderText);

#line default
#line hidden
                    return;
                case 3:
                    this.StepsTextBox = ((System.Windows.Controls.TextBox)(target));

#line 12 "..\..\MainWindow.xaml"
                    this.StepsTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.RemovePlaceholderText);

#line default
#line hidden

#line 12 "..\..\MainWindow.xaml"
                    this.StepsTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.ShowPlaceholderText);

#line default
#line hidden
                    return;
                case 4:
                    this.AddRecipeButton = ((System.Windows.Controls.Button)(target));

#line 15 "..\..\MainWindow.xaml"
                    this.AddRecipeButton.Click += new System.Windows.RoutedEventHandler(this.AddRecipeButton_Click);

#line default
#line hidden
                    return;
                case 5:
                    this.FilterTextBox = ((System.Windows.Controls.TextBox)(target));

#line 17 "..\..\MainWindow.xaml"
                    this.FilterTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.RemovePlaceholderText);

#line default
#line hidden

#line 17 "..\..\MainWindow.xaml"
                    this.FilterTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.ShowPlaceholderText);

#line default
#line hidden

#line 17 "..\..\MainWindow.xaml"
                    this.FilterTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.FilterTextBox_TextChanged);

#line default
#line hidden
                    return;
                case 6:
                    this.RecipeListBox = ((System.Windows.Controls.ListBox)(target));

#line 20 "..\..\MainWindow.xaml"
                    this.RecipeListBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.RecipeListBox_SelectionChanged);

#line default
#line hidden
                    return;
                case 7:
                    this.RecipeDetailsTextBlock = ((System.Windows.Controls.TextBlock)(target));
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.TextBox RecipeNameTextBox;
        internal System.Windows.Controls.TextBox IngredientsTextBox;
    }
}

