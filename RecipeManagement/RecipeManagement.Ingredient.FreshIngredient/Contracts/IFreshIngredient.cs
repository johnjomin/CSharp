namespace RecipeManagement.FreshIngredient.Contracts;

public interface IFreshIngredient
{
    public DateTime ExpirationDate { get; set; }
}