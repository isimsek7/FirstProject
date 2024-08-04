using System;
//We define a bool "back" to loop the opening segment unless user chooses not to.
bool back = true;
while (back)
{
    // We get the user input and assign it to the "chooser" variable to use as an input to switch cases below.
    Console.WriteLine("Game of Guess:1\nCalculator:2\nGrade Result:3\nEnter the corresponding numbers " +
    "and press enter to choose any of the programs specified.");
    int chooser = Convert.ToInt32(Console.ReadLine());
    //Then the user chooses which program to trigger.
    switch (chooser)
    {
        case 1:
            GameOfGuess();
            break;
        case 2:
            Calculator();
            break;
        case 3:
            Grade();
            break;
    }
    //After the choosen method ends, we jump to another while loop, which asks whetever to continue or not.
    while (back)
    {
        try
        {
            Console.WriteLine("Do you want to continue ?\nY/N:");
            char x = Convert.ToChar(Console.ReadLine().ToUpper());
            if (x == 'Y')
                break;
            else if (x == 'N')
                back = !back;
                continue;
        }
        //We catch here and since there is no other function this catcher has, it just loops back to ask continue or not again and again.
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);                      
        }
    }
}
    

     

//We define our method.
static void GameOfGuess()
{
    try
    {
        //We first create a random number between 1-100
        Random rnd = new Random();
        int random = rnd.Next(1, 100);
        int totalHealth = 5;
        Console.WriteLine("Guess a number between 1-100");
        double guess = Convert.ToDouble(Console.ReadLine());
        //We use totalHealth as a counter, and everytime the while loop triggers, user loses 1 hp.
        while (totalHealth >= 1)
        {
            //Then, we have set of if statements, we first check whetever the user has enough hp left, if not we display Game Over.
            //Then we warn the user if input is out of range.
            totalHealth--;
            if (totalHealth == 0)
            {
                Console.WriteLine("Gave Over.");
                Console.WriteLine("Random number was:{0}.", random);
            }
            else if (guess < 1 || guess > 100)
            {
                Console.WriteLine("Input was out of range! Remember that you need a number between 1 and 100.");
                Console.Write("Guess again:");
                guess = Convert.ToDouble(Console.ReadLine());
                totalHealth++;
                //We add one hp here, so the user doesn't lose unncesary hp.

            }
            //Then we check if the number is smaller or bigger than the random number
            else if (guess < random && totalHealth >= 1)
            {
                Console.WriteLine("You need a bigger number...");
                Console.WriteLine("You got {0} chances left.", totalHealth);
                Console.Write("Guess again:");
                guess = Convert.ToDouble(Console.ReadLine());
            }
            else if (guess > random && totalHealth >= 1)
            {
                Console.WriteLine("You need a smaller number...");
                Console.WriteLine("You got {0} chances left.", totalHealth);
                Console.Write("Guess again:");
                guess = Convert.ToDouble(Console.ReadLine());
            }
            //Again, an if statement that checks if the user won.
            else if (guess == random)
            {
                Console.WriteLine("Congratulations you've Won !");
            }

        }

    }
    //catches format exception
    catch (FormatException)
    {
        Console.WriteLine("You should only use numbers.");
    }
}
static void Calculator()
{
    //Calculator
    //Pretty straight forward.
    try
    {
        Console.WriteLine("==========Calculator==========");
        Console.WriteLine("Please enter the first number.");
        int firstNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter the second number.");
        int secondNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please specify the operator (i.e, +,-,*,/");
        char operate = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Calculating...");
        //We use, operate variable for the switch cases.
        switch (operate)
        {
            case '+':
                Console.WriteLine("Result={0}", firstNumber + secondNumber);
                break;
            case '-':
                Console.WriteLine("Result={0}", firstNumber - secondNumber);
                break;
            case '*':
                Console.WriteLine("Result={0}", firstNumber * secondNumber);
                break;
            case '/':
                Console.WriteLine("Result={0}", firstNumber / secondNumber);
                break;
        }
        //Here are our exception handlers.
    }
    catch (DivideByZeroException e)
    {
        Console.WriteLine(e.Message);
    }
    catch (FormatException e)
    {
        Console.WriteLine(e.Message);
    }
}
static void Grade()
{

    try
    {
        // I also wrapped the code in a meaningless do while loop to be able to break out of if statements.
        do
        {
            Console.WriteLine("==========Grade==========");
            Console.WriteLine("Please enter the result of your first exam.");
            int firstResult = Convert.ToInt32(Console.ReadLine());
            //These if statements checks if the inputs are valid or not
            if (firstResult < 0 || firstResult > 100)
            {
                Console.WriteLine("You've entered an invalid number.");
                break;

            }
            Console.WriteLine("Please enter the result of your second exam.");
            int secondResult = Convert.ToInt32(Console.ReadLine());
            if (secondResult < 0 || secondResult > 100)
            {
                Console.WriteLine("You've entered an invalid number.");
                break;
            }
            Console.WriteLine("Please enter the result of your third exam.");
            int thirdResult = Convert.ToInt32(Console.ReadLine());
            if (thirdResult < 0 || thirdResult > 100)
            {
                Console.WriteLine("You've entered an invalid number.");
                break;
            }
            double avarageGrade = (firstResult + secondResult + thirdResult) / 3;
            //There is possibly a better way to write these codes below but i didn't want to mess it up by chance
            //I will try to find a cleaner way with lesser code.
            if (avarageGrade >= 90)
                Console.WriteLine("Your grade is, AA={0}", avarageGrade);
            else if (avarageGrade >= 85 && avarageGrade < 90)
                Console.WriteLine("Your grade is, BA={0}", avarageGrade);
            else if (avarageGrade >= 80 && avarageGrade < 85)
                Console.WriteLine("Your grade is, BB={0}", avarageGrade);
            else if (avarageGrade >= 75 && avarageGrade < 80)
                Console.WriteLine("Your grade is, CB={0}", avarageGrade);
            else if (avarageGrade >= 70 && avarageGrade < 75)
                Console.WriteLine("Your grade is, CC={0}", avarageGrade);
            else if (avarageGrade >= 65 && avarageGrade < 70)
                Console.WriteLine("Your grade is, DC={0}", avarageGrade);
            else if (avarageGrade >= 60 && avarageGrade < 65)
                Console.WriteLine("Your grade is, DD={0}", avarageGrade);
            else if (avarageGrade >= 55 && avarageGrade < 60)
                Console.WriteLine("Your grade is, FD={0}", avarageGrade);
            else if (avarageGrade >= 0 && avarageGrade < 55)
                Console.WriteLine("Your grade is, FF={0}", avarageGrade);
        }
        //Since 0 is always 0, code just runs once anyway because this is how do/while operates.
        while (0!=0);
    }
    //Handler again.
    catch (FormatException e)
    {
        Console.WriteLine(e.Message);
    }
}
