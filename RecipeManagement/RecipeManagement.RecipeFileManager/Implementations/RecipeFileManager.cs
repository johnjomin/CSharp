using Newtonsoft.Json;
using RecipeManagement.Recipe.Implementations;

namespace RecipeManagement.RecipeFileManager.Implementations;

public class RecipeFileManager
{
    // Write a recipe to a file
    public void WriteRecipeToFile(BaseRecipe recipe, string filePath)
    {
        // Serialize the recipe to a string
        string recipeString = SerializeRecipe(recipe);

        // Write the recipe string to the file
        File.WriteAllText(filePath, recipeString);
    }

    // Serialize a recipe to a string
    private string SerializeRecipe(BaseRecipe recipe)
    {
        var json = JsonConvert.SerializeObject(recipe);

        return json;
    }

    // Check if a file exists
    public bool FileExists(string filePath)
    {
        return File.Exists(filePath);
    }

    // Check if a directory exists
    public bool DirectoryExists(string directoryPath)
    {
        return Directory.Exists(directoryPath);
    }

    // Create a new directory
    public void CreateDirectory(string directoryPath)
    {
        Directory.CreateDirectory(directoryPath);
    }

    // Copy a file
    public void CopyFile(string sourceFilePath, string destinationFilePath)
    {
        File.Copy(sourceFilePath, destinationFilePath);
    }

    // Move a file
    public void MoveFile(string sourceFilePath, string destinationFilePath)
    {
        File.Move(sourceFilePath, destinationFilePath);
    }

    // Change a file extension
    public void ChangeFileExtension(string filePath, string newExtension)
    {
        string newFilePath = Path.ChangeExtension(filePath, newExtension);
        File.Move(filePath, newFilePath);
    }

    // Delete a directory
    public void DeleteDirectory(string directoryPath)
    {
        Directory.Delete(directoryPath, true);
    }

    // Use FileSystemWatcher to automatically process created files
    public void ProcessCreatedFiles(string directoryPath, Action<string> processFile)
    {
        var watcher = new FileSystemWatcher(directoryPath);
        watcher.Created += (sender, e) =>
        {
            processFile(e.FullPath);
        };
        watcher.EnableRaisingEvents = true;
    }

    // Use FileSystemWatcher to automatically process changed files
    public void ProcessChangedFiles(string directoryPath, Action<string> processFile)
    {
        var watcher = new FileSystemWatcher(directoryPath);
        watcher.Changed += (sender, e) =>
        {
            processFile(e.FullPath);
        };
        watcher.EnableRaisingEvents = true;
    }
}