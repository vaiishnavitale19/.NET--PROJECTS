class Abstracteg : FileStorage
{
    public override void Upload(string file)
    {
        Console.WriteLine(file + " uploaded successfully");
    }
}