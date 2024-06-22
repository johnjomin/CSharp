using RecipeManagement.Ingredient.Implementations;
using RecipeManagement.Recipe.Implementations;

namespace RecipeManagement.Recipe.GenericRecipe.Implementations;

//[LEARN] - generic #1
// GenericRecipe is a subclass of Recipe that takes a type parameter T that must inherit from the Ingredient class
public class GenericRecipe<T> : BaseRecipe where T : BaseIngredient
{
    // SpecialIngredients is a property of type List<T>, which allows to specify a list of ingredients that are specific to this recipe ie soup
    public List<T> SpecialIngredients { get; set; }

    // The constructor takes a name, a list of ingredients, instructions, and a list of special ingredients of type T
    public GenericRecipe(string name, List<BaseIngredient> ingredients, string instructions, List<T> specialIngredients) : base(name, ingredients, instructions)
    {
        SpecialIngredients = specialIngredients;
    }
}