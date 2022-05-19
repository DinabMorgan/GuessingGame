// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Welcome to the guessing game!");
// adding a variable 1-10
int num = 5;
Console.WriteLine("guess a number 1 -10");
   string input =  Console.ReadLine();
int num2 = Int32.Parse(input);
if (num ==num2)
{
    Console.WriteLine("great job, you guessed correctly!");
}
else if (num2 >= 10) {
    Console.WriteLine("You have the choice of 1 through 10");
}
else {
    Console.WriteLine("You guessed wrong :(");

}