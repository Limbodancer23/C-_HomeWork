﻿System.Console.WriteLine("Enter number:");
string strnumber1 = Console.ReadLine();
int number1 = Convert.ToInt32(strnumber1);

if (number1 % 2 == 0) System.Console.WriteLine("It`s even number!");
else System.Console.WriteLine("It`s odd number!");

int StartNumber = 1;
while (StartNumber <= number1)
{
    if (StartNumber % 2 == 0)
    {
        System.Console.Write(StartNumber);
        System.Console.Write(", ");
        StartNumber++;
    }
    else
    {
        StartNumber++;
    }
}