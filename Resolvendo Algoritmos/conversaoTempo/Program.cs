using System;

namespace ConversaoDeTempo
{  
    class ConversaoDeTempo 
    {  
        static void Main(string[] args) 
        {
          var tempo = int.Parse(Console.ReadLine());

          var horas = (tempo / 3600); 
          var minutos = (tempo % 3600) / 60; 
          var segundos =  (tempo % 3600) % 60;

          Console.WriteLine($"{horas}:{minutos}:{segundos}");
        }
    }
}