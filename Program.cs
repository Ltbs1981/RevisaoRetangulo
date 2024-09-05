using RevisaoRetangulo;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a altura");
        double altura = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a largura");
        double largura = double.Parse(Console.ReadLine());

        Retangulo retangulo = new Retangulo(altura, largura);
        



        Console.WriteLine("Perímetro: " + retangulo.CalcularPerimetro());

        Console.WriteLine("Área: " + retangulo.CalcularArea());

        Console.WriteLine("Diagonal: " + retangulo.CalcularDiagonal());
    }
}

