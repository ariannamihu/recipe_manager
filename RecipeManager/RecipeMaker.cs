public class RecipeManager
{
    private List<Recipe> recipes = new List<Recipe>();

    public void AddRecipe(Recipe recipe)
    {
        recipes.Add(recipe);
        Console.WriteLine($"{recipe.Name} added.");
    }

    public void DisplayRecipes()
    {
        if (recipes.Count == 0)
        {
            Console.WriteLine("No recipes available.");
        }
        else
        {
            foreach (var recipe in recipes)
            {
                recipe.DisplayRecipe();
                Console.WriteLine();
            }
        }
    }

    public void RemoveRecipe(string name)
    {
        var recipeToRemove = recipes.Find(r => r.Name == name);
        if (recipeToRemove != null)
        {
            recipes.Remove(recipeToRemove);
            Console.WriteLine($"{name} removed.");
        }
        else
        {
            Console.WriteLine($"Recipe {name} not found.");
        }
    }
}
