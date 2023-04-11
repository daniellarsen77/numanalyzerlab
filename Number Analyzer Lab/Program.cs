Console.WriteLine("Please enter your name");
string name = Console.ReadLine();

Console.WriteLine($"Hello {name}! Please enter a number between 1 and 100");
int num = int.Parse( Console.ReadLine() );

if ( num >= 1 && num <= 100)
{

}
else
{
    Console.WriteLine($"Number is invalid please try again {name}.");
}

if (num % 2 == 0)
{
    if (num >= 2 && num <= 24)
    {
        Console.WriteLine($"{num} Is Even and less than 25.");
    }
    else if (num >= 26 && num <= 60)
    {
        Console.WriteLine($"{num} Is Even and between 26 and 60 inclusive.");
    }
    else
    {
        Console.WriteLine($"{num} Is Even and greater than 60.");
    }
}
else
{
    if (num < 60)
    {
        Console.WriteLine($"{num} Is Odd and less than 60.");
    }
    else
    {
        Console.WriteLine($"{num} Is Odd and greater than 60.");
    }
}
    