using RecipeManagement.Ingredient.Implementations;
using RecipeManagement.Recipe.Implementations;
using RecipeManagement.Recipe.VegetarianRecipe.Contracts;

namespace RecipeManagement.Recipe.VegetarianRecipe.Implementations;

public class VegetarianRecipe : BaseRecipe, IVegetarianRecipe
{
    public bool HasMorePlants { get; set; }

    public override string GetInstructions()
    {
        return $"{Instructions} - Don't forget to not include meat items!";
    }

    public VegetarianRecipe(string name, List<BaseIngredient> ingredients, string instructions) : base(name, ingredients, instructions)
    {
    }
}