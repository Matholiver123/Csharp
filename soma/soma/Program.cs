using System;

namespace CalculadoraNamespace
{
    class Calculadora
    {
        // Atributos
        public double n1;
        public double n2;
        public double soma;


        // Método para realizar a soma
        public void somar()
        {
            soma = n1 + n2;

            Console.WriteLine("A soma é: " + soma);
        }

        static void Main(string[] args)
        {

            Calculadora c1 = new Calculadora();

            c1.n1 = 2000;
            c1.n2 = 100;

            c1.somar();


            Calculadora c2 = new Calculadora();

            c2.n1 = 200;
            c2.n2 = 100;

            c2.somar();



        }
    }
}