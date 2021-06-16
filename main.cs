using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Enter a number"); 
    int num1 = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Enter Another Number");
    int num2 = Convert.ToInt32(Console.ReadLine());
    int sum = num1 + num2;
    Console.WriteLine()
  }
}