using RecipeManagement.Ingredient.Implementations;
using RecipeManagement.Recipe.Contracts;
using RecipeManagement.Recipe.Implementations;

namespace ClassLibrary1RecipeManagement.Recipe.Food.MadrasCurry.Implementations;

public class MadrasCurry : BaseRecipe, IEditable, IPrintable, ISaveable, IDisplayable
{
public MadrasCurry() : base("Chicken Madras", new List<BaseIngredient> { new BaseIngredient("Chicken", "Dozen")}, "Eat Well")
{
}
//Work in progress. 
//Not sure how to implement this but something to try with multiple inheritance
public void Edit()
{
    // Implementation for editing recipe
}

public void Print()
{
    // Implementation for printing recipe
}

public void Save()
{
    // Implementation for saving recipe
}

public void Load()
{
    // Implementation for loading recipe
}

public void Display()
{
    // Implementation for displaying recipe
}
}