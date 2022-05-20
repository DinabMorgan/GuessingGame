// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Welcome to the guessing game!");
// adding a variable 1-10
int num = 5;







/*for (int i = 0; i <= 3; i++)
{
    Console.WriteLine(" great guess! you are  " + (num - num2) + " far from the correct response.");

} */
int attempt = 1;
while (attempt <= 3)
{
    Console.WriteLine("guess a number 1 -10");
    string input = Console.ReadLine();

    int num2 = Int32.Parse(input);

   

    if (num == num2)
    {
        Console.WriteLine("great job, you guessed correctly!");
        attempt = 4;

    }
    else if (num2 >= 11 || num2 <= 0)
    {
        Console.WriteLine("You have the choice of 1 through 10");
    }
    else
    {
        Console.WriteLine("You guessed wrong :(");
        Console.WriteLine(" great guess! you are  " + (num - num2) + " far from the correct response.");
        attempt++;


    }
}

