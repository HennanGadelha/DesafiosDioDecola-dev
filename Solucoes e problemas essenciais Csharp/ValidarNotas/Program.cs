using System;

class ValidacaoDeNota 
{  
    public static void Main() 
    {
      
      double somaNotas = 0;
      int cc = 0;
      
      do
      {
        double notaEntradaConsole = double.Parse(Console.ReadLine());
        
        if (notaEntradaConsole < 0 || notaEntradaConsole > 10)
        {
          Console.WriteLine("nota invalida");
        } 
        else 
        {
          cc++;
          
          somaNotas += notaEntradaConsole; 
        }    
      } 
      while (cc < 2);
      
      Console.WriteLine("media = " + (somaNotas / 2).ToString("N2"));
    }
}
