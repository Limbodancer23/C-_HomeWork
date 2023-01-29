// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.

System.Console.WriteLine("Enter first number: ");
string strnumber1 = Console.ReadLine();
int number1 = Convert.ToInt32(strnumber1);

System.Console.WriteLine("Enter second number: ");
string strnumber2 = Console.ReadLine();
int number2 = Convert.ToInt32(strnumber2);

System.Console.WriteLine("Enter third number: ");
string strnumber3 = Console.ReadLine();
int number3 = Convert.ToInt32(strnumber3);

int max = 0;

if (number1 >= number2) max = number1;
else max = number2;
if (number3 >= max) max = number3;

System.Console.Write("Greater is: ");
System.Console.Write(max);
