using RecipeManagement.Ingredient.Contracts;
using RecipeManagement.Ingredient.Implementations;
using RecipeManagement.Recipe.Contracts;

namespace RecipeManagement.Recipe.Implementations;

//[LEARN]
//Interface is abstraction
//Interfaces define the properties and methods that the classes must implement, but not their implementation details

//Allows the ManagementOptions class to interact with the Recipe and Ingredient objects through the interfaces,
//without having to know the specific implementation details of the classes
public class BaseRecipe : IBaseRecipe
{
    //Encapsulation
    //Practice of hiding the internal implementation details of an object from the outside world

    //Encapsulate their data by making their properties private and providing public methods to access & modify that data
    public BaseRecipe(string name, List<BaseIngredient> ingredients, string instructions)
    {
        Name = name;
        Ingredients = ingredients;
        Instructions = instructions;
    }

    public int? Rating { get; set; }
    
    public string Name { get; set; }

    public List<BaseIngredient> Ingredients { get; set; }

    public string Instructions { get; set; }
    
    //Polymorphism is the ability of an object to take on many forms
    //polymorphism can be used to treat objects of different classes as if they were of the same type
    //using virtual and override
    public virtual string GetInstructions()
    {
        return Instructions;
    }

}