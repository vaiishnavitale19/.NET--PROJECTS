abstract class FileStorage
{
    public abstract void Upload(string file);

    public void ValidateFile()
    {
        Console.WriteLine("File validated");
    }
}