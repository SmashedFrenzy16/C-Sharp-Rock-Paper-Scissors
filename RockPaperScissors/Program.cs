// See https://aka.ms/new-console-template for more information

Console.ForegroundColor = ConsoleColor.DarkRed;


string playAgain = "Y";

string[] outcomes = { "Computer: Rock", "Computer: Paper", "Computer: Scissors" };

Random random = new Random();

int r = random.Next(0, outcomes.Length);

string cAscii = "";

do
{
    r = random.Next(0, outcomes.Length);

    if (outcomes[r] == "Computer: Rock")
    {
        cAscii = "Computer: Rock\n    _______\r\n---'   ____)\r\n      (_____)\r\n      (_____)\r\n      (____)\r\n---.__(___)";
    }
    else if (outcomes[r] == "Computer: Paper")
    {
        cAscii = "Computer: Paper\n     _______\r\n---'    ____)____\r\n           ______)\r\n          _______)\r\n         _______)\r\n---.__________)";
    }
    else if (outcomes[r] == "Computer: Scissors")
    {
        cAscii = "Computer: Scissors\n    _______\r\n---'   ____)____\r\n          ______)\r\n       __________)\r\n      (____)\r\n---.__(___)";
    }

    Console.Write("Rock (r), Paper (p), or Scissors (s)?: ");

    string choice = Console.ReadLine();

    if (choice == "R" || choice == "r")
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("You: Rock\n    _______\r\n---'   ____)\r\n      (_____)\r\n      (_____)\r\n      (____)\r\n---.__(___)");

        Console.WriteLine(cAscii);

        if (outcomes[r] == "Computer: Scissors")
        {
            Console.WriteLine("You won!");
        }
        else if (outcomes[r] == "Computer: Paper")
        {
            Console.WriteLine("You lost!");
        }
        else if (outcomes[r] == "Computer: Rock")
        {
            Console.WriteLine("You drew!");
        }

        Console.ForegroundColor = ConsoleColor.DarkRed;
    }
    else if (choice == "P" || choice == "p")
    {
        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine("You: Paper\n     _______\r\n---'    ____)____\r\n           ______)\r\n          _______)\r\n         _______)\r\n---.__________)");

        Console.WriteLine(cAscii);

        if (outcomes[r] == "Computer: Scissors")
        {
            Console.WriteLine("You lost!");
        }
        else if (outcomes[r] == "Computer: Paper")
        {
            Console.WriteLine("You drew!");
        }
        else if (outcomes[r] == "Computer: Rock")
        {
            Console.WriteLine("You lost!");
        }

        Console.ForegroundColor = ConsoleColor.DarkRed;
    }
    else if (choice == "S" || choice == "s")
    {

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("You: Scissors\n    _______\r\n---'   ____)____\r\n          ______)\r\n       __________)\r\n      (____)\r\n---.__(___)");

        Console.WriteLine(cAscii);

        if (outcomes[r] == "Computer: Scissors")
        {
            Console.WriteLine("You drew!");
        }
        else if (outcomes[r] == "Computer: Paper")
        {
            Console.WriteLine("You won!");
        }
        else if (outcomes[r] == "Computer: Rock")
        {
            Console.WriteLine("You lost!");
        }

        Console.ForegroundColor = ConsoleColor.DarkRed;
    }

    Console.Write("Do you want to play again (y/n)?: ");

    playAgain = Console.ReadLine();

} while (playAgain == "Y" || playAgain == "y");

