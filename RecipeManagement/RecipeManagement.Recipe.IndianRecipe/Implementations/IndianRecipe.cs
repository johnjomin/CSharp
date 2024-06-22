using RecipeManagement.Ingredient.Implementations;
using RecipeManagement.Recipe.Implementations;
using RecipeManagement.Recipe.VeganRecipe.Contracts;

namespace RecipeManagement.Recipe.VeganRecipe.Implementations;

public class IndianRecipe : BaseRecipe, IIndianRecipe
{
    public bool HasSpices { get; set; }

    public override string GetInstructions()
    {
        return $"{Instructions} - Don't forget to add spices!";
    }

    public IndianRecipe(string name, List<BaseIngredient> ingredients, string instructions) : base(name, ingredients, instructions)
    {
    }
}