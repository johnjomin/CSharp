using RecipeManagement.Ingredient.Implementations;
using RecipeManagement.Recipe.GenericRecipe.Implementations;

namespace RecipeManagement.Ingredient.Vegetable;

//LEARN - generic #2
// Define a new class Vegetable that inherits from Ingredient
public abstract class Vegetable : BaseIngredient
{
    protected Vegetable(string name, string quantity) : base(name, quantity)
    {
    }
}

// Create a new subclass VegetableSoup of GenericRecipe that takes the Vegetable class as its type parameter
public class VegetableSoup : GenericRecipe<Vegetable>
{
    // The constructor takes a name, a list of ingredients, instructions, and a list of special vegetables
    public VegetableSoup(string name, List<BaseIngredient> ingredients, string instructions, List<Vegetable> specialIngredients) : base(name, ingredients, instructions, specialIngredients) { }
}