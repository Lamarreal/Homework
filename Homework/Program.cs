// First 

float combinedNumber = 0;
float MaxDigits = 4;

for (float i = 0; i < MaxDigits; i++) // we will receive four numbers from user and combine them to one
{
    Console.Write($"Enter number {i} : ");
    string? Input = Console.ReadLine();

    if (Input != null)
    {
        int toInt = Convert.ToInt32(Input);

        float pow = MathF.Pow(10, MaxDigits);

        combinedNumber += toInt * pow;
    }

}

Console.WriteLine(combinedNumber.ToString());