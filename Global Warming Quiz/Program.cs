using static System.Formats.Asn1.AsnWriter;

class GlobalWarmingQuiz
{
    static void Main(string[] args)
    {
        // declaring variables
        int correctAnswers = 0;

        Console.WriteLine("Global Warming Facts Quiz");

        Console.WriteLine();    // just for spacing purpose

        // Question 1
        Console.WriteLine("1. What is the primary cause of global warming?");
        Console.WriteLine("   1. Human activity");
        Console.WriteLine("   2. Natural cycles");
        Console.WriteLine("   3. Solar radiation");
        Console.WriteLine("   4. Volcanic eruptions");

        Console.Write("\nEnter You Answer (1, 2, 3 or 4): ");
        int answerOne = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();    // just for spacing purpose

        if (answerOne == 1)
        {
            Console.WriteLine("Correct!");
            correctAnswers++;
        }
        else
        {
            Console.WriteLine("Incorrect!");
        }

        Console.WriteLine();    // just for spacing purpose

        // Question 2
        Console.WriteLine("2. What is the greenhouse effect?");
        Console.WriteLine("   1. The trapping of heat by Earth's atmosphere");
        Console.WriteLine("   2. The cooling of Earth's atmosphere by water vapor");
        Console.WriteLine("   3. The depletion of Earth's ozone layer");
        Console.WriteLine("   4. The warming of Earth's atmosphere by cosmic rays");

        Console.Write("\nEnter You Answer (1, 2, 3 or 4): ");
        int answerTwo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();    // just for spacing purpose

        if (answerTwo == 1)
        {
            Console.WriteLine("Correct!");
            correctAnswers++;
        }
        else
        {
            Console.WriteLine("Incorrect!");
        }

        Console.WriteLine();    // just for spacing purpose

        // Question 3
        Console.WriteLine("3. How much has Earth's temperature increased since the Industrial Revolution?");
        Console.WriteLine("   1. 1 degree Fahrenheit");
        Console.WriteLine("   2. 5 degrees Fahrenheit");
        Console.WriteLine("   3. 10 degrees Fahrenheit");
        Console.WriteLine("   4. 15 degrees Fahrenheit");

        Console.Write("\nEnter You Answer (1, 2, 3 or 4): ");
        int answerThree = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();    // just for spacing purpose

        if (answerThree == 1)
        {
            Console.WriteLine("Correct!");
            correctAnswers++;
        }
        else
        {
            Console.WriteLine("Incorrect!");
        }

        Console.WriteLine();    // just for spacing purpose

        // Question 4
        Console.WriteLine("4. How do greenhouse gases contribute to global warming?");
        Console.WriteLine("   1. By reflecting solar radiation back to space");
        Console.WriteLine("   2. By absorbing heat in the atmosphere");
        Console.WriteLine("   3. By blocking heat from reaching Earth's surface");
        Console.WriteLine("   4. By causing volcanic eruptions");

        Console.Write("\nEnter You Answer (1, 2, 3 or 4): ");
        int answerFour = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();    // just for spacing purpose

        if (answerFour == 2)
        {
            Console.WriteLine("Correct!");
            correctAnswers++;
        }
        else
        {
            Console.WriteLine("Incorrect!");
        }

        Console.WriteLine();    // just for spacing purpose

        // Question 5
        Console.WriteLine("5. What are some of the consequences of global warming?");
        Console.WriteLine("   1. Melting ice caps");
        Console.WriteLine("   2. Rising sea levels");
        Console.WriteLine("   3. More frequent and severe weather events");
        Console.WriteLine("   4. All of the above");

        Console.Write("\nEnter You Answer (1, 2, 3 or 4): ");
        int answerFive = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();    // just for spacing purpose

        if (answerFive == 4)
        {
            Console.WriteLine("Correct!");
            correctAnswers++;
        }
        else
        {
            Console.WriteLine("Incorrect!");
        }

        Console.WriteLine();    // just for spacing purpose

        if (correctAnswers == 5)
        {
            Console.WriteLine("Excellent");
        }

        else if (correctAnswers == 4)
        {
            Console.WriteLine("Very Good");
        }

        else
        {
            Console.WriteLine("Time to brush up on your knowledge of global warming.");
            Console.WriteLine("For more information, visit www.epa.gov/climatechange, www.nationalgeographic.com/environment/global-warming, or www.skepticalscience.com.");
        }
    }
}
