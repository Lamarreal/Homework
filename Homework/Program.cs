// First 

using System;
using System.Diagnostics;

float combinedNumber = 0;
float MaxDigits = 4;

for (float i = 1; i < MaxDigits + 1; i++) // we will receive four numbers from user and combine them to one
{
    Console.Write($"Enter number {i} : ");
    string? Input = Console.ReadLine();

    if (Input != null)
    {
        int toInt = Convert.ToInt32(Input); // converting input message to int
        float pow = MathF.Pow(10, MaxDigits - i); // power function for math calculations
        combinedNumber += toInt * pow; // calculating final number
    }
}
Console.WriteLine("Your number is :" +  combinedNumber.ToString());

Console.WriteLine("Reverse? : Y|N");

string? Input2 = Console.ReadLine();


if (Input2 != null)
{
    if (Input2.ToUpper() == "Y")
    {
        int num = Convert.ToInt32(combinedNumber);
        int result = 0;

        while (num != 0)
        { 
            int a = num % 10;
            result = result * 10 + a;
            num = num / 10;
        }

        Console.WriteLine("Your number is : " + result.ToString());
    }
}
