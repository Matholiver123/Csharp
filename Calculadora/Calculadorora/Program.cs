using System;

namespace CalculadoraNamespace
{
    class Calculadora
    {
        // Atributos
        public double n1;
        public double n2;
        public double soma;
        public double subtracao;
        public double multiplcacao;
        public double divisao;

        // Método para realizar a soma
        public void realizarOperacoes()
        {
            soma = n1 + n2;
            subtracao = n1 - n2;
            multiplcacao = n1 * n2;
            divisao = n1 / n2;

            Console.WriteLine("A soma é: " + soma);
            Console.WriteLine("A soma é: " + subtracao);
            Console.WriteLine("A soma é: " + multiplcacao);
            Console.WriteLine("A soma é: " + divisao);
        }

        static void Main(string[] args)
        {

            Calculadora c1 = new Calculadora();

            c1.n1 = 2000;
            c1.n2 = 100;

            c1.realizarOperacoes();



        }
    }
}