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
        private void UpdateRecipeList()
        {
            RecipeListBox.ItemsSource = null;
            RecipeListBox.ItemsSource = recipes.OrderBy(r => r.Name).ToList();
        }

        private void RecipeListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (RecipeListBox.SelectedItem is Recipe selectedRecipe)
            {
                RecipeDetailsTextBlock.Text = $"Name: {selectedRecipe.Name}\n\nIngredients:\n- {string.Join("\n- ", selectedRecipe.Ingredients)}\n\nSteps:\n{selectedRecipe.Steps}";
            }
        }

        private void FilterTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string filter = FilterTextBox.Text.ToLower();
            var filteredRecipes = recipes.Where(r => r.Ingredients.Any(i => i.ToLower().Contains(filter))).OrderBy(r => r.Name).ToList();
            RecipeListBox.ItemsSource = null;
            RecipeListBox.ItemsSource = filteredRecipes;
        }

        private void RemovePlaceholderText(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text == "Enter Recipe Name" || textBox.Text == "Enter Ingredients (comma-separated)" || textBox.Text == "Enter Steps" || textBox.Text == "Filter by Ingredient")
            {
                textBox.Text = "";
                textBox.Foreground = System.Windows.Media.Brushes.Black;
            }
        }

        private void ShowPlaceholderText(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                if (textBox.Name == "RecipeNameTextBox")
                    textBox.Text = "Enter Recipe Name";
                else if (textBox.Name == "IngredientsTextBox")
                    textBox.Text = "Enter Ingredients (comma-separated)";
                else if (textBox.Name == "StepsTextBox")
                    textBox.Text = "Enter Steps";
                else if (textBox.Name == "FilterTextBox")
                    textBox.Text = "Filter by Ingredient";

                textBox.Foreground = System.Windows.Media.Brushes.Gray;
            }
        }
    }
}

    }




















//https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.textblock?view=windowsdesktop-8.0 // 
//https://stackoverflow.com/questions/833943/watermark-hint-placeholder-text-in-textbox //
// https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-8.0 //
// https://learn.microsoft.com/en-us/dotnet/desktop/wpf/data/?view=netdesktop-7.0 //