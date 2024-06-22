using RecipeManagement.Ingredient.Implementations;

namespace RecipeManagement.Recipe.Contracts;

public interface IBaseRecipe
{
    public string Name { get; set; }
    public List<BaseIngredient> Ingredients { get; set; }
    public string Instructions { get; set; }
}