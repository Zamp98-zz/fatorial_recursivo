using System;

namespace fatorial_recursivo
{
    class Fatorial
    {
        private int i; //numero a ser calculado o fatorial
        private int fat;//resultado do calculo
        private int pilha = -1;
        public Fatorial(int n)
        {
            Console.WriteLine("Calculando fatorial...");
            i = n;
            fat = getFatorial(i);
        }
        public void setNumero(int n)
        {
            i = n;
        }
        public int getFatorial(int n)
        {
            int temp = n;
            pilha++;
            if (n <= 1)
            {
                Console.WriteLine("chamada {0}, valor de temp {1}", pilha, temp);
                return 1;
            }
            else
            {
                Console.WriteLine("chamada {0}, valor de temp {1}", pilha, temp);
                temp = n * getFatorial(n - 1);
                
                return temp;
            }
        }
        public void mostrar()
        {
            Console.WriteLine("numero: {0}, fatorial: {1}\n", i, fat);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            
            int i = Convert.ToInt32(Console.ReadLine());
            Fatorial fat = new Fatorial(i);
            fat.mostrar();
        }
    }
}
