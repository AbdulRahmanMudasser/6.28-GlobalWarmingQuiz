class GlobalWarmingQuiz
{
    static void Main(string[] args)
    {
        // declaring variables
        int correctAnswers = 0;

        // Question 1
        Console.WriteLine("1. What is the primary cause of global warming?");
        Console.WriteLine("   1. Human activity");
        Console.WriteLine("   2. Natural cycles");
        Console.WriteLine("   3. Solar radiation");
        Console.WriteLine("   4. Volcanic eruptions");
        int answerOne = Convert.ToInt32(Console.ReadLine());

        // Question 2
        Console.WriteLine("2. What is the greenhouse effect?");
        Console.WriteLine("   1. The trapping of heat by Earth's atmosphere");
        Console.WriteLine("   2. The cooling of Earth's atmosphere by water vapor");
        Console.WriteLine("   3. The depletion of Earth's ozone layer");
        Console.WriteLine("   4. The warming of Earth's atmosphere by cosmic rays");
        int answerTwo = Convert.ToInt32(Console.ReadLine());

        // Question 3
        Console.WriteLine("3. How much has Earth's temperature increased since the Industrial Revolution?");
        Console.WriteLine("   1. 1 degree Fahrenheit");
        Console.WriteLine("   2. 5 degrees Fahrenheit");
        Console.WriteLine("   3. 10 degrees Fahrenheit");
        Console.WriteLine("   4. 15 degrees Fahrenheit");
        int answerThree = Convert.ToInt32(Console.ReadLine());

        // Question 4
        Console.WriteLine("4. How do greenhouse gases contribute to global warming?");
        Console.WriteLine("   1. By reflecting solar radiation back to space");
        Console.WriteLine("   2. By absorbing heat in the atmosphere");
        Console.WriteLine("   3. By blocking heat from reaching Earth's surface");
        Console.WriteLine("   4. By causing volcanic eruptions");
        int answerFour = Convert.ToInt32(Console.ReadLine());

        // Question 5
        Console.WriteLine("5. What are some of the consequences of global warming?");
        Console.WriteLine("   1. Melting ice caps");
        Console.WriteLine("   2. Rising sea levels");
        Console.WriteLine("   3. More frequent and severe weather events");
        Console.WriteLine("   4. All of the above");
        int answerFive = Convert.ToInt32(Console.ReadLine());
    }
}
