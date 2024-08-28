using RevisaoRetangulo;
class Program
{
    static void Main(string[] args)
    {
        Retangulo retangulo = new Retangulo(24.24, 3.32);

        Console.WriteLine("Hello, World!");

        Console.WriteLine("Perímetro: " + retangulo.CalcularPerimetro());

        Console.WriteLine("Área: " + retangulo.CalcularArea());

        Console.WriteLine("Diagonal: " + retangulo.CalcularDiagonal());
    }
}

