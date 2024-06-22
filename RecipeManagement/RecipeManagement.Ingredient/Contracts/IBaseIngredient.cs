namespace RecipeManagement.Ingredient.Contracts;

public interface IBaseIngredient
{
    string Name { get; set; }
    string Quantity { get; set; }
    string GetDescription();
}