using RecipeManagement.Rating.Contracts;

namespace RecipeManagement.Rating.Implementations;

public class RecipeRating : IRecipeRating
{
    public string RecipeName { get; set; }
    public int Rating { get; set; }
}