using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace RecipeApp
{
    public partial class MainWindow : Window
    {
        private List<Recipe> recipes = new List<Recipe>();

        public MainWindow()
        {
            InitializeComponent();
        }
        private void AddRecipeButton_Click(object sender, RoutedEventArgs e)
        {
            string name = RecipeNameTextBox.Text;
            List<string> ingredients = IngredientsTextBox.Text.Split(',').Select(i => i.Trim()).ToList();
            string steps = StepsTextBox.Text;

            if (!string.IsNullOrEmpty(name) && ingredients.Any() && !string.IsNullOrEmpty(steps))
            {
                Recipe newRecipe = new Recipe(name, ingredients, steps);
                recipes.Add(newRecipe);
                UpdateRecipeList();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Please fill out all fields.");
            }
        }

        private void ClearForm()
        {
            RecipeNameTextBox.Clear();
            IngredientsTextBox.Clear();
            StepsTextBox.Clear();
        }

    }




















//https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.textblock?view=windowsdesktop-8.0 // 
//https://stackoverflow.com/questions/833943/watermark-hint-placeholder-text-in-textbox //
// https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-8.0 //
// https://learn.microsoft.com/en-us/dotnet/desktop/wpf/data/?view=netdesktop-7.0 //