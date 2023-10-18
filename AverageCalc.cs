// See https://aka.ms/new-console-template for more information
double num01; 
double num02;
double num03;

Console.Write("Input first number: "); 

num01 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input second number: ");

num02 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input third number: "); 

num03 = Convert.ToDouble(Console.ReadLine());

double result = (num01 + num02 + num03)/3; 
Console.Write("The average is: " + result);