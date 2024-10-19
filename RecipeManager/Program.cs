class Program
{
    static void Main(string[] args)
    {
        RecipeManager manager = new RecipeManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Recipe Manager");
            Console.WriteLine("1. Add a Recipe");
            Console.WriteLine("2. View All Recipes");
            Console.WriteLine("3. Remove a Recipe");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddRecipe(manager);
                    break;
                case "2":
                    manager.DisplayRecipes();
                    break;
                case "3":
                    RemoveRecipe(manager);
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }

    static void AddRecipe(RecipeManager manager)
    {
        Console.Write("Enter the recipe name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Enter the ingredients (comma separated): ");
        string ingredientInput = Console.ReadLine();
        List<string> ingredients = ingredientInput.Split(',').Select(i => i.Trim()).ToList();

        Console.WriteLine("Enter the instructions: ");
        string instructions = Console.ReadLine();

        Recipe newRecipe = new Recipe(name, ingredients, instructions);
        manager.AddRecipe(newRecipe);
    }

    static void RemoveRecipe(RecipeManager manager)
    {
        Console.Write("Enter the name of the recipe to remove: ");
        string name = Console.ReadLine();
        manager.RemoveRecipe(name);
    }
}
