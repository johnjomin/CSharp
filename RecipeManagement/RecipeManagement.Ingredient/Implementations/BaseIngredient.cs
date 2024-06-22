using RecipeManagement.Ingredient.Contracts;

namespace RecipeManagement.Ingredient.Implementations;

public class BaseIngredient : IBaseIngredient
{
    public BaseIngredient(string name, string quantity)
    {
        Name = name;
        Quantity = quantity;
    }

    public string Name { get; set; }

    public string Quantity { get; set; }

    public virtual string GetDescription()
    {
        return $"{Name} - {Quantity}";
    }
}