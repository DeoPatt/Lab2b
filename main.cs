using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Enter a number"); 
    double num1 = Convert.ToDouble(Console.ReadLine());
    
    Console.WriteLine("Enter Another Number");
    double num2 = Convert.ToDouble(Console.ReadLine());
    double sum = num1 + num2;
    Console.WriteLine("sum = " +  sum);
    double diff = num1 - num2;
    Console.WriteLine("Diff = " + diff);
    double pro = num1 * num2;
    Console.WriteLine("Product = " + pro);
    double quo = num1 / num2;
    Console.WriteLine("Quotient = " + quo);
    double remain = num1 % num2;
    Console.WriteLine("Remainder = " + remain);
  }
}