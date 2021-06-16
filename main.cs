using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Enter a number"); 
    int num1 = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Enter Another Number");
    int num2 = Convert.ToInt32(Console.ReadLine());
    int sum = num1 + num2;
    Console.WriteLine("sum = " +  sum);
    int diff = num1 - num2;
    Console.WriteLine("Diff = " + diff);
    int pro = num1 * num2;
    Console.WriteLine("Product = " + pro);
    int quo = num1 / num2;
    Console.WriteLine("Quotient = " + quo);
    int remain = num1 % num2;
    Console.WriteLine("Remainder = " + remain);
  }
}