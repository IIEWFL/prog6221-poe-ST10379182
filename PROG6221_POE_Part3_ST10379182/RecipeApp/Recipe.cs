// Recipe.cs
using System.Collections.Generic;

namespace RecipeApp
{

    public class Recipe
    {
        public string Name { get; set; }
        public List<string> Ingredients { get; set; }
        public string Steps { get; set; }

        public Recipe(string name, List<string> ingredients, string steps)

// https://learn.microsoft.com/en-us/dotnet/csharp/linq/ //
