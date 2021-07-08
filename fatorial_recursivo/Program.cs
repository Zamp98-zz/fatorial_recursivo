using System;
using System.Linq;

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
            //  minha ideia de integrar o linq ao programa de fatorial recursivo foi de
            //dada uma entrada n, o programa calcula o fatorial de zero a n e mostra somente os
            //que forem pares
            // The Three Parts of a LINQ Query:
            // 1. Data source.
            Console.WriteLine("entre com o valor do intervalo n:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];
            for (int a = 0; a < n; a++) {
                Fatorial fat = new Fatorial(a);
                numbers[a] = fat.getFatorial(a);    
            }
            
            // 2. Query creation.
            // numQuery is an IEnumerable<int>
            var numQuery =
                from num in numbers
                where (num % 2) == 0
                select num;

            // 3. Query execution.
            foreach (int num in numQuery) {
                Console.Write("{0,1} ", num);
            }
        }
    }
}
