using System;

namespace CalculadoraNamespace
{
    class Calculadora
    {
        // Atributos
        public double n1;
        public double n2;
        
        
        // Método para realizar a soma
        public void somar()
        {

            Console.WriteLine("\nA soma é: " + (n1 + n2));
        }

        public void subritrair()
        {

            Console.WriteLine("\nA Subtração é: " + (n1 - n2));
        }

        public void multiplicar()
        {
        
            Console.WriteLine("\nA Multiplicação é: " + (n1 * n2));
        }

        public void dividir()
        {

            Console.WriteLine("\nA Divisão é: " + (n1 / n2));
        }



        static void Main(string[] args)
        {


            Calculadora c1 = new Calculadora();
            c1.n1 = 2;
            c1.n2 = 3;
       

            c1.somar();
            c1.subritrair();
            c1.multiplicar();
            c1.dividir();

            Calculadora c2 = new Calculadora();
            c2.n1 = 6;
            c2.n2 = 3; 
            c2.somar();
            c2.subritrair();
            c2.multiplicar();
            c2.dividir();

        }
        }
}