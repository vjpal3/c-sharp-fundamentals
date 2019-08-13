public enum Guesses { low, high }

public static string ProcessRound(int current_card, string strGuess)
{
    int min = 2;
    int max = 14;

    Random rand = new Random();
    int next_card = rand.Next(min, max); ;
    Console.WriteLine("next card: " + next_card);

    var guess = (int)(Guesses)Enum.Parse(typeof(Guesses), strGuess.ToLower());

    switch (guess)
    {
        case 0:
            if (next_card < current_card)
                return "Win";
            else if (next_card > current_card)
                return "Loss";
            else
                return "draw";
        case 1:
            if (next_card > current_card)
                return "Win";
            else if (next_card < current_card)
                return "Loss";
            else
                return "draw";

    }
    return "Error";
}