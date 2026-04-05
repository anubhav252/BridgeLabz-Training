using System;

class NumberGuessingGame{
    static void Main(string[] args){
        Console.WriteLine("Think of a number between 1 and 100.");
        Console.WriteLine("Respond with: high, low, or correct");

        int min = 1;
        int max = 100;
        bool guessedCorrectly = false;

        while (!guessedCorrectly){
            int guess = GenerateGuess(min, max);
            Console.WriteLine("you guessed: " + guess);

            string feedback = GetUserFeedback();

            int[] result = ProcessFeedback(feedback, guess, min, max);
            guessedCorrectly = result[0] == 1;
            min = result[1];
            max = result[2];
        }

        Console.WriteLine("guessed the number correctly!");
    }

    static int GenerateGuess(int min, int max){
        Random random = new Random();
        return random.Next(min, max + 1);
    }

    static string GetUserFeedback(){
        return Console.ReadLine().ToLower();
    }

    static int[] ProcessFeedback(string feedback, int guess, int min, int max){
        if (feedback == "correct"){
            return new int[] { 1, min, max };
        }
        else if (feedback == "high"){
            max = guess - 1;
        }
        else if (feedback == "low"){
            min = guess + 1;
        }
        else{
            Console.WriteLine("Invalid input");
        }

        return new int[] { 0, min, max };
    }
}
