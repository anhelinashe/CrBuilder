using System;

class Croissant
{
    public string EmptyCroissant { get; set; }
    public string Sauce { get; set; }
    public string Topping { get; set; }

    public void Show() => Console.WriteLine($"Croissant with: EmptyCroissant - {EmptyCroissant}, Sauce - {Sauce}, Topping - {Topping}");
}
interface ICroissantBuilder
{
    void AddEmptyCroissant();
    void AddSauce();
    void AddTopping();
    Croissant GetCroissant();
}
class CroissantBuilder : ICroissantBuilder
{
    private Croissant _croissant = new Croissant();

    public void AddEmptyCroissant() => _croissant.EmptyCroissant = "Fluffy bun";
    public void AddSauce() => _croissant.Sauce = "Chocolate cream";
    public void AddTopping() => _croissant.Topping = "Banana";

    public Croissant GetCroissant() => _croissant;
}

class Program
{
    static void Main(string[] args)
    {
        ICroissantBuilder builder = new CroissantBuilder();
        builder.AddEmptyCroissant();
        builder.AddSauce();
        builder.AddTopping();

        Croissant croissant = builder.GetCroissant();
        croissant.Show();
    }
}

