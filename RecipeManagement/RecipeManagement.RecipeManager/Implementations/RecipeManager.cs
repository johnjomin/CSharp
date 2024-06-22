using RecipeManagement.Ingredient.Implementations;
using RecipeManagement.Kiosk.Contracts;
using RecipeManagement.Rating.Implementations;
using RecipeManagement.Recipe.Implementations;

namespace RecipeManagement.Kiosk.Implementations;

public class RecipeManager : IRecipeManager
{
    private readonly List<BaseRecipe> listofRecipes;
    private readonly List<RecipeRating> ratings;

    public RecipeManager()
    {
        listofRecipes = new List<BaseRecipe>();
        ratings = new List<RecipeRating>();
    }

    #region Remove Recipe

    public void RemoveRecipe(BaseRecipe recipe)
    {
        try
        {
            listofRecipes.Remove(recipe);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unable to remove Recipe due to: {ex.Message}");
        }
    }

    #endregion

    #region Add Recipe

    public void AddRecipe(BaseRecipe recipe)
    {
        try
        {
            listofRecipes.Add(recipe);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unable to add recipe due to: {ex.Message}");
        }
    }

    //[LEARN] 
    //optional parameters
    public BaseRecipe AddRecipe(string name, List<BaseIngredient> ingredients = null, string instructions = null)
    {
        try
        {
            var addRecipe = new BaseRecipe(name, ingredients, instructions);

            if (ingredients != null)
                addRecipe.Ingredients = ingredients;
            else
                throw new NullReferenceException();

            if (instructions != null)
                addRecipe.Instructions = instructions;
            else
                throw new NullReferenceException();

            listofRecipes.Add(addRecipe);
            return addRecipe;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unable to add recipe due to : {ex.Message}");
        }

        return null;
    }

    #endregion

    #region Get and Find Recipe

    public BaseRecipe FindRecipe(string recipeName)
    {
        return listofRecipes.FirstOrDefault(r => r.Name == recipeName);
    }

    public List<BaseRecipe> GetRecipesWithRating(int rating)
    {
        return listofRecipes.Join(ratings, r => r.Name, r => r.RecipeName, (r, s) => r).Where(r => r.Rating == rating).ToList();
    }

    public bool AllRecipesHaveRating()
    {
        return listofRecipes.All(r => r.Rating != null);
    }

    public bool AnyRecipeHasRating()
    {
        return listofRecipes.Any(r => r.Rating != null);
    }

    public List<BaseRecipe> GetRecipesWithinRatingRange(int minRating, int maxRating)
    {
        return listofRecipes.Join(ratings, r => r.Name, r => r.RecipeName, (r, s) => r).Where(r => r.Rating >= minRating && r.Rating <= maxRating).ToList();
    }

    public List<BaseRecipe> GetRecipesWithoutRating()
    {
        return listofRecipes.Except(GetRecipesWithRating(default)).ToList();
    }

    public List<BaseRecipe> GetRecipesWithRatingGreaterThan(int rating)
    {
        return listofRecipes.Join(ratings, r => r.Name, r => r.RecipeName, (r, s) => r).Where(r => r.Rating > rating).ToList();
    }

    public List<BaseRecipe> GetRecipesWithRatingLessThan(int rating)
    {
        return listofRecipes.Join(ratings, r => r.Name, r => r.RecipeName, (r, s) => r).Where(r => r.Rating < rating).ToList();
    }

    public int MinRating()
    {
        return ratings.Min(r => r.Rating);
    }

    public int MaxRating()
    {
        return ratings.Max(r => r.Rating);
    }

    public List<BaseRecipe> GetRecipesSortedByRating()
    {
        return listofRecipes.Join(ratings, r => r.Name, r => r.RecipeName, (r, s) => r).OrderBy(r => r.Rating).ToList();
    }

    public List<BaseRecipe> GetRecipesWithIngredient(string ingredientName)
    {
        return listofRecipes.Where(r => r.Ingredients.Any(i => i.Name == ingredientName)).ToList();
    }

    public IEnumerable<BaseRecipe> GetRecipesByIngredientCount(int count)
    {
        return listofRecipes.Where(r => r.Ingredients.Count == count);
    }

    public IEnumerable<BaseRecipe> GetRecipesSortedByName()
    {
        return listofRecipes.OrderBy(r => r.Name);
    }

    public IEnumerable<BaseRecipe> GetRecipesSortedByIngredientCount()
    {
        return listofRecipes.OrderBy(r => r.Ingredients.Count);
    }

    public List<BaseRecipe> GetAllRecipes()
    {
        try
        {
            return listofRecipes;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unable to Get All Recipes due to {ex.Message}");
        }

        return new List<BaseRecipe>();
    }



    public List<BaseRecipe> FindRecipeByName(List<string> names)
    {
        try
        {
            var foundRecipes = new List<BaseRecipe>();

            foreach (var name in names)
            {
                foundRecipes.Add(listofRecipes.Find(recipe => recipe.Name == name));
            }

            return foundRecipes;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unable to Find Recipe by Name due to {ex.Message}");
        }

        return new List<BaseRecipe>();
    }

    public void DisplayRecipeInstructions(BaseRecipe recipe)
    {
        try
        {
            Console.WriteLine(recipe.GetInstructions());
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unable to Display Recipe By Instructions due to {ex.Message}");
        }
    }

    #endregion



    #region Print Recipe

    //[LEARN]
    //expression bodied method using =>
    public void PrintRecipe(BaseRecipe recipe)
    {
        Console.WriteLine($"Recipe: {recipe.Name}\nIngredients:\n{string.Join("\n", recipe.Ingredients.Select(i => $"  {i.Name}: {i.Quantity}"))}\nInstructions: {recipe.Instructions}");
    }

    public void PrintAllRecipes()
    {
        try
        {
            foreach (var recipe in listofRecipes)
            {
                Console.WriteLine($"Recipe: {recipe.Name}\nIngredients:\n{string.Join("\n", recipe.Ingredients.Select((i, index) => $"{index + 1}. {i.Name}: {i.Quantity}"))}\nInstructions: {recipe.Instructions}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unable to print out all recipe due to {ex.Message}");
        }
    }

    #endregion
}