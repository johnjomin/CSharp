using RecipeManagement.Ingredient.Implementations;
using RecipeManagement.Recipe.AdvancedRecipe.Contracts;
using RecipeManagement.Recipe.Implementations;

namespace RecipeManagement.Recipe.AdvancedRecipe.Implementations;

public class AdvancedRecipe : BaseRecipe, IAdvancedRecipe, IUpdateRecipe
{
    public string Category { get; set; }
    public string Cuisine { get; set; }

    public void Update(string propertyName, object newValue)
    {
        switch (propertyName)
        {
            case "Name":
                Name = (string)newValue;
                break;
            case "Ingredients":
                Ingredients = (List<BaseIngredient>)newValue;
                break;
            case "Instructions":
                Instructions = (string)newValue;
                break;
            case "Category":
                Category = (string)newValue;
                break;
            case "Cuisine":
                Cuisine = (string)newValue;
                break;
            default:
                throw new ArgumentException($"Unknown property name: {propertyName}");
        }
    }

    public AdvancedRecipe(string name, List<BaseIngredient> ingredients, string instructions) : base(name, ingredients, instructions)
    {
    }
}