using System;
class QuadradoEAoCubo 
{
    static void Main() 
    {
        var n = Int32.Parse(Console.ReadLine());
        
        if(n != null)
        {
          for(int i = 1; i <= n; i++)
          {
            var qtdLinhas = $"{i} {i * i} {i * i * i}";
            Console.WriteLine(qtdLinhas);
          }
        }
        else 
        {
          Console.WriteLine("Insira um número!");
        }
    }
}