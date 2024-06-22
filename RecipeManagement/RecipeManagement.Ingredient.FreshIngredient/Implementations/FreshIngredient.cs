using RecipeManagement.FreshIngredient.Contracts;
using RecipeManagement.Ingredient.Implementations;

namespace RecipeManagement.FreshIngredient.Implementations;

public class FreshIngredient : BaseIngredient, IFreshIngredient
{
    public DateTime ExpirationDate { get; set; }

    public override string GetDescription()
    {
        return $"{Name} - {Quantity} (Expires {ExpirationDate})";
    }

    public FreshIngredient(string name, string quantity) : base(name, quantity)
    {
    }
}