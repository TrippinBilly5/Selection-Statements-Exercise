//var r = new Random();
//var favNumber = r.Next(1, 1000);
//int guess;

//do
//{
//    Console.WriteLine("Guess my favorite number, between 1 and 1000");
//    guess = int.Parse(Console.ReadLine());
//}
//while (!checkGuess(guess));

//bool checkGuess(int guess)
//{
//    bool isCorrect = false;
//    if (guess < favNumber)
//    {
//        Console.WriteLine("Too low!");
//    }
//    else if (guess > favNumber)
//    {
//        Console.WriteLine("Too high");
//    }
//    else if (guess == favNumber)
//    {
//        Console.WriteLine($"You got it! My favorite number is {favNumber}");
//        isCorrect = true;
//    }
//    return isCorrect;
//}


Console.WriteLine("What is your favorite school subject?");
string subject = Console.ReadLine();

switch (subject.ToLower())
{
    case "pe":
    case "physical education":
        Console.WriteLine("There's an easy A");
        break;
    case "english":
        Console.WriteLine("So you like to write");
        break;
    case "math":
        Console.WriteLine("I like numbers, too");
        break;
    case "literature":
        Console.WriteLine("A reader, I see");
        break;
    case "history":
        Console.WriteLine("The past is interesting");
        break;
    default:
        Console.WriteLine("I don't know that subject");
        break;
}

