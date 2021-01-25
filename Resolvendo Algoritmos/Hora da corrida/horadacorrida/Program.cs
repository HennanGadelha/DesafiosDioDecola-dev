using System;

namespace HoraDaCorrida 
{
    class Program 
    {
        static void Main(string[] args) 
        {    
            string[] vet = Console.ReadLine().Split(" ");
            
            int a = int.Parse(vet[0]);
            int n = int.Parse(vet[1]);
            
            int NumeroPlacas = a * n;

            for (int i = 10; i <= 90; i += 10) 
            {
                double total = (double)NumeroPlacas / 100 * i;
                Console.Write(Math.Ceiling(total) + " ");
            }
        }
    }
}