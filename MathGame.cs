using System;

class MathGame
{
  Random random = new Random();
  List<int> Scores = new List<int>();
  int score = 0;

  public void StartGame()
  {

    Console.WriteLine("What is your name?");
    string? name = Console.ReadLine();
    Console.WriteLine($"Hello, {name}! I look forward to playing with you!");

    bool quit = false;
    while (!quit)
    {


      Console.WriteLine("Choose the number of an operation:");
      Console.WriteLine("1. ADDITION");
      Console.WriteLine("2. SUBTRACTION");
      Console.WriteLine("3. MULTIPLICATION");
      Console.WriteLine("4. DIVISION");
      Console.WriteLine("5. HISTORY");

      int operation;
      while (!int.TryParse(Console.ReadLine(), out operation))
      {
        Console.WriteLine("Please enter a valid option.");
      }

      score = 0;
      switch (operation)
      {
        case 1:
          Console.WriteLine("YOU CHOSE ADDITION");
          score = AdditionGame();
          Console.WriteLine($"Your score is {score}");
          Scores.Add(score);
          break;
        case 2:
          Console.WriteLine("YOU CHOSE SUBTRACTION");
          score = SubtractionGame();
          Console.WriteLine($"Your score is {score}");
          Scores.Add(score);
          break;
        case 3:
          Console.WriteLine("YOU CHOSE MULTIPLICATION");
          score = MultiplicationGame();
          Console.WriteLine($"Your score is {score}");
          Scores.Add(score);
          break;
        case 4:
          Console.WriteLine("YOU CHOSE DIVISION");
          score = DivisionGame();
          Console.WriteLine($"Your score is {score}");
          Scores.Add(score);
          break;
        case 5:
          Console.WriteLine("You chose to view the history of scores.");
          foreach (int Score in Scores)
          {
            Console.WriteLine(Score);
          }
          break;
        default:
          Console.WriteLine("That is not a valid option. Please type in the number of the operation.");
          break;
      }
      Console.WriteLine("Would you like to play again? Yes or No?");
      string? play = Console.ReadLine();
      if (play.ToLower() == "no")
      {
        quit = true;
        Console.WriteLine("Thanks for playing. Goodbye!");
      }
      else if (play.ToLower() == "yes")
      {
        continue;
      }
      else
      {
        while (play.ToLower() != "yes" && play.ToLower() != "no")
          Console.WriteLine("That is not a valid option. Please try again.");
        play = Console.ReadLine();
      }

    }

  }



  public int AdditionGame()
  {

    for (int i = 0; i < 10; i++)
    {
      int randomNumber = random.Next(0, 100);
      int randomNumber2 = random.Next(0, 100);
      int sum = randomNumber + randomNumber2;

      Console.WriteLine($"{randomNumber} + {randomNumber2} = ?");


      int sumAnswer;
      while (!int.TryParse(Console.ReadLine(), out sumAnswer))
      {
        Console.WriteLine("Invalid option. Please enter a valid number.");
      }

      if (sumAnswer == sum)
      {
        Console.WriteLine($"The answer is {sum}. You are ");
        Console.WriteLine("CORRECT!");
        score++;
      }
      else
      {
        Console.WriteLine("WRONG!");
        Console.WriteLine("Maybe next time.");
      }
    }
    return score;
  }

  public int SubtractionGame()
  {
    for (int i = 0; i < 10; i++)
    {
      int randomNumber3 = random.Next(0, 100);
      int randomNumber4 = random.Next(0, 100);
      int difference = randomNumber3 - randomNumber4;

      Console.WriteLine($"{randomNumber3} - {randomNumber4} = ?");

      int diffAnswer;
      while (!int.TryParse(Console.ReadLine(), out diffAnswer))
      {
        Console.WriteLine("Invalid option. Please enter a valid number.");
      }


      if (diffAnswer == difference)
      {
        Console.WriteLine($"The correct answer is {difference}. You are ");
        Console.WriteLine("CORRECT!");
        score++;
      }
      else
      {
        Console.WriteLine($"The correct answer is {difference}. You are ");
        Console.WriteLine("Wrong!");
        Console.WriteLine("Maybe next time.");
      }
    }
    return score;
  }

  public int MultiplicationGame()
  {
    for (int i = 0; i < 10; i++)
    {
      int randomNumber5 = random.Next(0, 100);
      int randomNumber6 = random.Next(0, 100);
      int product = randomNumber5 * randomNumber6;

      Console.WriteLine($"{randomNumber5} * {randomNumber6} = ?");

      int prodAnswer;
      while (!int.TryParse(Console.ReadLine(), out prodAnswer))
      {
        Console.WriteLine("Invalid option. Please enter a valid number.");
      }


      if (prodAnswer == product)
      {
        Console.WriteLine($"The correct answer is {product}, You are ");
        Console.WriteLine("CORRECT!");
        score++;
      }
      else
      {
        Console.WriteLine($"The correct answer is {product}. You are ");
        Console.WriteLine("WRONG!");
        Console.WriteLine("Better luck next time.");
      }
    }
    return score;
  }

  public int DivisionGame()
  {
    for (int i = 0; i < 10; i++)
    {
      int total;
      int randomNumber7, randomNumber8;
      do
      {
        randomNumber7 = random.Next(0, 100);
        randomNumber8 = random.Next(1, 100);
        total = randomNumber7 % randomNumber8;

      } while (total != 0);

      int quotient = randomNumber7 / randomNumber8;

      Console.WriteLine($"{randomNumber7} / {randomNumber8} = ?");

      int quotientAnswer;
      while (!int.TryParse(Console.ReadLine(), out quotientAnswer))
      {
        Console.WriteLine("Invalid option. Please enter a valid number.");
      }


      if (quotientAnswer == quotient)
      {
        Console.WriteLine($"The correct answer is {quotient}. You are ");
        Console.WriteLine("CORRECT!");
        score++;
      }
      else
      {
        Console.WriteLine($"The correct answer is {quotient}. You are ");
        Console.WriteLine("WRONG!");
        Console.WriteLine("Better luck next time.");
      }

    }
    return score;
  }
}



