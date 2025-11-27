using System;
class HelloWorld {
  static void Main() {
      Console.WriteLine("Teste contagem mais 5")
      int i = int.Parse(Console.ReadLine());
      int N = 0;
      
      while(N < i){
          Console.WriteLine(N);
          N = N + 5;
      }
      
   }
