using System;
using Characters.Warriors;


    public class EntryPoint
    {
        static void Main()
        {
            Warrior theGoodGuy = new Warrior(190, 80, "Good Guy");
        theGoodGuy.Age = 25;
            //theGoodGuy.Height = 190;
            //theGoodGuy.Weight = 80;
            //theGoodGuy.Name = "Good Guy";

            Warrior theBadGuy = new Warrior(170, 70, "Bad Guy");
        theBadGuy.Age = 15;
            //theBadGuy.Height = 170;
            //theBadGuy.Weight = 70;
            //theBadGuy.Name = "Bad Guy";

            theGoodGuy.Greetings(theBadGuy);
            theBadGuy.Greetings(theGoodGuy);

        Console.WriteLine($@"The warrior {theGoodGuy.Name} is {theGoodGuy.Age}");
        Console.WriteLine($@"The warrior {theBadGuy.Name} is {theBadGuy.Age}");

        Console.WriteLine(theBadGuy.Height);
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        try
        {
            theGoodGuy.Age = 25;
            theBadGuy.Age = 15;
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    }


