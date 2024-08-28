using RevisaoRetangulo;
using System;

namespace RevisaoRetangulo
{
    public class Retangulo
    {
        public double Altura;
        public double Largura;

        // Construtor dentro da classe
        public Retangulo(double altura, double largura)
        {
            Altura = altura;
            Largura = largura;
        }

        public double CalcularPerimetro() // Nome consistente
        {
            return (Largura + Altura) * 2;
        }

        public double CalcularArea() // Nome consistente
        {
            return Largura * Altura;
        }

        public double CalcularDiagonal() // Nome consistente
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }
    }
}
