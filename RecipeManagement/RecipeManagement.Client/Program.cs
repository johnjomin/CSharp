using RecipeManagement.DessertRecipe.Implementations;
using RecipeManagement.Ingredient.Implementations;
using RecipeManagement.Kiosk.Implementations;
using RecipeManagement.Recipe.Implementations;

var recipeManager = new RecipeManager();

while (true)
{
    Console.WriteLine("\n\n1. Add Recipe");
    Console.WriteLine("2. Remove Recipe");
    Console.WriteLine("3. Find Recipe");
    Console.WriteLine("4. Get Recipes with Rating");
    Console.WriteLine("5. Get Recipes within Rating Range");
    Console.WriteLine("6. Get Recipes without Rating");
    Console.WriteLine("7. Get Recipes with Rating Greater Than");
    Console.WriteLine("8. Get Recipes with Rating Less Than");
    Console.WriteLine("9. Get Minimum Rating");
    Console.WriteLine("10. Get Maximum Rating");
    Console.WriteLine("11. Get Recipes Sorted by Rating");
    Console.WriteLine("12. Get Recipes with Ingredient");
    Console.WriteLine("13. Get Recipes by Ingredient Count");
    Console.WriteLine("14. Get Recipes Sorted by Name");
    Console.WriteLine("15. Get Recipes Sorted by Ingredient Count");
    Console.WriteLine("16. Find Recipe by Name");
    Console.WriteLine("17. Get All Recipes");
    Console.WriteLine("18. Display Recipe Instructions");
    Console.WriteLine("19. Print All Recipe");
    Console.WriteLine("20. Write All Recipes");
    Console.WriteLine("21. Exit");

    var option = Convert.ToInt32(Console.ReadLine());

    try
    {
        switch (option)
        {
            case 1:
                AddRecipe();
                break;
            case 2:
                RemoveRecipe();
                break;
            case 3:
                FindRecipe();
                break;
            case 4:
                GetRecipesWithRating();
                break;
            case 5:
                GetRecipesWithinRatingRange();
                break;
            case 6:
                GetRecipesWithoutRating();
                break;
            case 7:
                GetRecipesWithRatingGreaterThan();
                break;
            case 8:
                GetRecipesWithRatingLessThan();
                break;
            case 9:
                GetMinimumRating();
                break;
            case 10:
                GetMaximumRating();
                break;
            case 11:
                GetRecipesSortedByRating();
                break;
            case 12:
                GetRecipesWithIngredient();
                break;
            case 13:
                GetRecipesWithIngredientCount();
                break;
            case 14:
                GetRecipesSortedByName();
                break;
            case 15:
                GetRecipesSortedByIngredientCount();
                break;
            case 16:
                FindRecipeByName();
                break;
            case 17:
                GetAllRecipes();
                break;
            case 18:
                DisplayRecipeInstructions();
                break;
            case 19:
                PrintAllRecipes();
                break;
            case 20:
                WriteAllRecipes();
                break;
            case 21:
                return;
            default:
                Console.WriteLine("\n\nInvalid option, please try again.");
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An error occurred: {ex.Message}");
    }
}

void AddRecipe()
{
    Console.WriteLine("Enter recipe name:");
    var recipeName = Console.ReadLine();

    Console.WriteLine("Enter recipe ingredients (name and quantity separated by comma, e.g. 'Spaghetti, 1 lb', 'Garlic, 2 cloves'):");
    var recipeIngredients = Console.ReadLine();
    var ingredientStrings = recipeIngredients.Split(',').Select(i => i.Trim()).ToList();
    var ingredients = new List<BaseIngredient>();

    foreach (var ingredientString in ingredientStrings)
    {
        var ingredientParts = ingredientString.Split(' ');
        var ingredientName = ingredientParts[0];
        var ingredientQuantity = string.Join(" ", ingredientParts.Skip(1));

        var ingredient = new BaseIngredient(ingredientName, ingredientQuantity);
        ingredients.Add(ingredient);
    }

    Console.WriteLine("Enter recipe instructions:");
    var recipeInstructions = Console.ReadLine();

    Console.WriteLine("Enter recipe type (Main or Dessert):");
    var recipeType = Console.ReadLine();

    if (recipeType.ToLower() == "dessert")
    {
        Console.WriteLine("Does this recipe have chocolate? (y/n):");
        var hasChocolate = Console.ReadLine();

        var hasChocolateBool = hasChocolate.ToLower() == "y";

        recipeManager.AddRecipe(new DessertRecipe(recipeName, ingredients, recipeInstructions)
        {
            HasChocolate = hasChocolateBool
        });
    }
    else
    {
        recipeManager.AddRecipe(new BaseRecipe(recipeName, ingredients, recipeInstructions));
    }

    Console.WriteLine("\n\tRecipe Added");
}

void RemoveRecipe()
{
    Console.WriteLine("Enter recipe name to remove:");
    var recipeNameToRemove = Console.ReadLine();

    var recipeToRemove = recipeManager.FindRecipe(recipeNameToRemove);
    recipeManager.RemoveRecipe(recipeToRemove);
}

void FindRecipe()
{
    Console.WriteLine("Enter recipe name to find:");
    var recipeNameToFind = Console.ReadLine();

    var foundRecipe = recipeManager.FindRecipe(recipeNameToFind);
    Console.WriteLine(foundRecipe.Name);
}

void GetRecipesWithRating()
{
    Console.WriteLine("Enter rating:");
    var rating = Convert.ToInt32(Console.ReadLine());

    var recipesWithRating = recipeManager.GetRecipesWithRating(rating);
    foreach (var recipe in recipesWithRating)
    {
        Console.WriteLine(recipe.Name);
    }
}

void GetRecipesWithinRatingRange()
{
    Console.WriteLine("Enter minimum rating:");
    var minRating = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter maximum rating:");
    var maxRating = Convert.ToInt32(Console.ReadLine());

    var recipesWithinRatingRange = recipeManager.GetRecipesWithinRatingRange(minRating, maxRating);
    foreach (var recipe in recipesWithinRatingRange)
    {
        Console.WriteLine(recipe.Name);
    }
}

void GetRecipesWithoutRating()
{
    var recipesWithoutRating = recipeManager.GetRecipesWithoutRating();
    foreach (var recipe in recipesWithoutRating)
    {
        Console.WriteLine(recipe.Name);
    }
}

void GetRecipesWithRatingGreaterThan()
{
    Console.WriteLine("Enter rating:");
    var ratingGreaterThan = Convert.ToInt32(Console.ReadLine());

    var recipesWithRatingGreaterThan = recipeManager.GetRecipesWithRatingGreaterThan(ratingGreaterThan);
    foreach (var recipe in recipesWithRatingGreaterThan)
    {
        Console.WriteLine(recipe.Name);
    }
}

void GetRecipesWithRatingLessThan()
{
    Console.WriteLine("Enter rating:");
    var ratingLessThan = Convert.ToInt32(Console.ReadLine());

    var recipesWithRatingLessThan = recipeManager.GetRecipesWithRatingLessThan(ratingLessThan);
    foreach (var recipe in recipesWithRatingLessThan)
    {
        Console.WriteLine(recipe.Name);
    }
}

void GetMinimumRating()
{
    var minRating = recipeManager.MinRating();
    Console.WriteLine(minRating);
}

void GetMaximumRating()
{
    var maxRating = recipeManager.MaxRating();
    Console.WriteLine(maxRating);
}

void GetRecipesSortedByRating()
{
    var recipesSortedByRating = recipeManager.GetRecipesSortedByRating();
    foreach (var recipe in recipesSortedByRating)
    {
        Console.WriteLine(recipe.Name);
    }
}

void GetRecipesWithIngredient()
{
    Console.WriteLine("Enter ingredient name:");
    var ingredientName = Console.ReadLine();

    var recipesWithIngredient = recipeManager.GetRecipesWithIngredient(ingredientName);
    foreach (var recipe in recipesWithIngredient)
    {
        Console.WriteLine(recipe.Name);
    }
}

void GetRecipesWithIngredientCount()
{
    Console.WriteLine("Enter ingredient count:");
    var ingredientCount = Convert.ToInt32(Console.ReadLine());

    var recipesByIngredientCount = recipeManager.GetRecipesByIngredientCount(ingredientCount);
    foreach (var recipe in recipesByIngredientCount)
    {
        Console.WriteLine(recipe.Name);
    }
}

void GetRecipesSortedByName()
{
    var recipesSortedByName = recipeManager.GetRecipesSortedByName();
    foreach (var recipe in recipesSortedByName)
    {
        Console.WriteLine(recipe.Name);
    }
}

void GetRecipesSortedByIngredientCount()
{
    var recipesSortedByIngredientCount = recipeManager.GetRecipesSortedByIngredientCount();
    foreach (var recipe in recipesSortedByIngredientCount)
    {
        Console.WriteLine(recipe.Name);
    }
}

void GetAllRecipes()
{
    var allRecipes = recipeManager.GetAllRecipes();
    foreach (var recipe in allRecipes)
    {
        Console.WriteLine(recipe.Name);
    }
}

void FindRecipeByName()
{
    Console.WriteLine("Enter recipe name to display instructions:");
    var recipeNameToDisplayInstructions = Console.ReadLine();

    var recipeToDisplayInstructions = recipeManager.FindRecipe(recipeNameToDisplayInstructions);
    recipeManager.DisplayRecipeInstructions(recipeToDisplayInstructions);
}

void DisplayRecipeInstructions()
{
    Console.WriteLine("Enter recipe name to print:");
    var recipeNameToPrint = Console.ReadLine();

    var recipeToPrint = recipeManager.FindRecipe(recipeNameToPrint);
    recipeManager.PrintRecipe(recipeToPrint);
}

void PrintAllRecipes()
{
    recipeManager.PrintAllRecipes();
}

void WriteAllRecipes()
{
    var recipesDirectory = @"..\..\..\..\RecipeManagement.Resources\Files";

    if (!Directory.Exists(recipesDirectory))
    {
        Directory.CreateDirectory(recipesDirectory);
    }

    var recipesFilePath = Path.Combine(recipesDirectory, "Recipes.txt");

    try
    {
        using (var writer = new StreamWriter(recipesFilePath))
        {
            foreach (var recipe in recipeManager.GetAllRecipes())
            {
                writer.WriteLine(recipe.Name);

                foreach (var ingredient in recipe.Ingredients)
                {
                    writer.WriteLine($"  {ingredient.Name}: {ingredient.Quantity}");
                }

                writer.WriteLine(recipe.Instructions);
            }
        }

        Console.WriteLine("\n\tRecipe written to text file");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Unable to write to file due to {ex.Message}");
    }
}