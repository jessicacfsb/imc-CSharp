using System;
using System.Globalization;

namespace imc {
    class Program {
        static void Main(string[] args) {

            double peso, altura, imc;

            Console.Write("Digite o peso: ");
            peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite a altura: ");
            altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            imc = peso / Math.Pow(altura, 2);

            if (imc < 18.5) {
                Console.WriteLine("\nAbaixo do peso!");
            }
            else if (imc >= 18.5 && imc < 24.9 ) {
                Console.WriteLine("\nPeso Normal!");
            }
            else if (imc >= 25 && imc < 29.9) {
                Console.WriteLine("\nSobrepeso!");
            }
            else if (imc >= 30 && imc < 34.9) {
                Console.WriteLine("\nObesidade grau 1!");
            }
            else if (imc >= 35 && imc < 39.9) {
                Console.WriteLine("\nObesidade grau 2!");
            }
            else {
                Console.WriteLine("\nObesidade Grau 3!");
            }
        }
    }
}
