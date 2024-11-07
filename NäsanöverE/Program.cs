int i_guess;
string guess;
int RandomNumber;
bool righguess = false;

Random generator = new Random();

RandomNumber = Random.Shared.Next(1, 10);

Console.WriteLine("Gissa på ett number mellan 1-10");
while (righguess == false)
{
    Console.WriteLine("Guess a number");
    guess = Console.ReadLine();

    bool righguess2 = int.TryParse(guess, out i_guess);
    if (righguess2 == false)
    {
        Console.WriteLine("Det där är inte en siffta");
    }
    else if (righguess2 == true)
    {
        if (i_guess > RandomNumber)
        {
            Console.WriteLine("Du gissade för stort ");
        }
        else if (i_guess < RandomNumber)
        {
            Console.WriteLine("Du gissade för litet");
        }
        else if (i_guess == RandomNumber)
        {
            Console.WriteLine("Du gissade rätt");
            righguess = true;
        }
    }
}
Console.ReadLine();




