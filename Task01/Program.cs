// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.

System.Console.WriteLine("Enter first number: ");
string strnumber1 = Console.ReadLine();
int number1 = Convert.ToInt32(strnumber1);

System.Console.WriteLine("Enter second number: ");
string strnumber2 = Console.ReadLine();
int number2 = Convert.ToInt32(strnumber2);

if (number1 > number2)
{
    System.Console.Write(number1);
    System.Console.Write(" is greater than ");
    System.Console.Write(number2);

}
else
{
    System.Console.Write(number2);
    System.Console.Write(" is greater than ");
    System.Console.Write(number1);
}