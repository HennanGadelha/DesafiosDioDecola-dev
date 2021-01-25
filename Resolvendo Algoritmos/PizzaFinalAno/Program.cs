using System;

class PizzaAntesDoFinalDoAno 
{
    static void Main()
    {  
        string[] line = Console.ReadLine().Split(" ");
        
        int n = int.Parse(line[0]);
        int d = int.Parse(line[1]);
        
        string data = "";
        
        int quantidade = 0;
        bool found = false;

        for (int dt=0; dt<d; dt++) 
        {
          quantidade = 0;

          string[] dados = Console.ReadLine().Split(" ");
          
          data =  dados[0];
          
          for (int p=1; p<n+1; p++)
          {
              quantidade += int.Parse( dados[p] );
          }

          found = ( quantidade == n);
          
          if (found) 
          { 
              break; 
          }
        } 
        
        if (found)
        { 
            Console.Write(data); 
        }
        else 
        { 
            Console.Write("Pizza antes de FdA"); 
        }
    }
}