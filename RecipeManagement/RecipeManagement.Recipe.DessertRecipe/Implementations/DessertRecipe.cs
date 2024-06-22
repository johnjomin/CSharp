using RecipeManagement.DessertRecipe.Contracts;
using RecipeManagement.Ingredient.Implementations;
using RecipeManagement.Recipe.Implementations;

namespace RecipeManagement.DessertRecipe.Implementations;

//[LEARN]
//DessertRecipe class inherits the properties and methods of the Recipe class

//inherit the properties and methods of the Ingredient and Recipe classes.
public class DessertRecipe : BaseRecipe, IDessertRecipe
{
    public bool HasChocolate { get; set; }

    public override string GetInstructions()
    {
        return $"{Instructions} - Don't forget to add chocolate!";
    }

    public DessertRecipe(string name, List<BaseIngredient> ingredients, string instructions) : base(name, ingredients, instructions)
    {
    }
}