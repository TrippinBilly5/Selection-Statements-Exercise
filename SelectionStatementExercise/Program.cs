var r = new Random();
var favNumber = r.Next(1, 1000);
int guess;

do
{
    Console.WriteLine("Guess my favorite number, between 1 and 1000");
    guess = int.Parse(Console.ReadLine());
}
while (!checkGuess(guess));

bool checkGuess(int guess)
{
    bool isCorrect = false;
    if (guess < favNumber)
    {
        Console.WriteLine("Too low!");
    }
    else if (guess > favNumber)
    {
        Console.WriteLine("Too high");
    }
    else if (guess == favNumber)
    {
        Console.WriteLine($"You got it! My favorite number is {favNumber}");
        isCorrect = true;
    }
    return isCorrect;
}


