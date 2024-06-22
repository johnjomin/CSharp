namespace RecipeManagement.Recipe.AdvancedRecipe.Contracts;

public interface IUpdateRecipe
{
    public void Update(string propertyName, object newValue);
}