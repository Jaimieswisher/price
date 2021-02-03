using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter name of Item");
    String Item = Console.ReadLine();
    
    Console.WriteLine ("Enter the quantity");
    Int quantity = ConvertToInt32(Console.ReadLine());

    Console.WriteLine ("Enter the cost");
    Double cost = ConvertTo.Double(Console.ReadLine);

    

    Console.WriteLine (Total price of item is $(quantity*cost);

  }
}