namespace RecipeManagement.Rating.Contracts;

public interface IRecipeRating
{
    public string RecipeName { get; set; }
    public int Rating { get; set; }
}