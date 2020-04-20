using System;

class MainClass {
  public static void Main (string[] args) {
    string[] pedidos = {"B123","C234","A345","C15", "B177","G3003","C235","B179"};
    foreach (string pedidos2 in pedidos)
    {if (pedidos2.StartsWith("B"))
      {
       Console.WriteLine(pedidos2);
      }
    }
  }
}