using System;

namespace Heron
{
    class Program
    {
        static void Main(string[] args)
        {
            double A;
            double B;
            double C;
            double ResultPerimetro;
            double ResultArea;

            Console.Write("Digite o Valor de A: ");
            A = double.Parse(Console.ReadLine());

            Console.Write ("Digite o Valor de B: ");
            B = double.Parse(Console.ReadLine());

            Console.Write("Digite o Valor de C: ");
            C = double.Parse(Console.ReadLine());
            Console.Write("\n");

            ResultPerimetro = (A + B  + C) / 2;
            ResultArea = Math.Sqrt (ResultPerimetro * (ResultPerimetro - A) * (ResultPerimetro - B ) * (ResultPerimetro - C));

            Console.WriteLine ("Semiperímetro = {0} " ,ResultPerimetro);
            Console.WriteLine ("Área = {0} (cm²)" ,ResultArea);
            Console.Write("\n");

            Console.WriteLine ("Pressione ENTER para sair!");
            Console.ReadKey();
        }
    }
}
