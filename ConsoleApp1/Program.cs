using System;
using Characters.Warriors;
using Characters.Spellcasters;
using Enumerations;

public class EntryPoint
    {
        static void Main()
        {
        Warrior theGoodGuy = new Warrior(190, 80, "Good Guy Name", Faction.GoodGuy);
        //theGoodGuy.Age = 25;
        //theGoodGuy.Height = 190;
        //theGoodGuy.Weight = 80;
        //theGoodGuy.Name = "Good Guy";

        Warrior theBadGuy = new Warrior(170, 70, "Bad Guy Name", Faction.BadGuy);
        //theBadGuy.Age = 15;
        //theBadGuy.Height = 170;
        //theBadGuy.Weight = 70;
        //theBadGuy.Name = "Bad Guy";

        Warrior youngWarrior = new Warrior(100, 50);
        youngWarrior.Age = 18;

        Console.WriteLine($@"blOOp {youngWarrior.Age}");
        try
        {
            theGoodGuy.Age = 25;
            theBadGuy.Age = 15;
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }


        theGoodGuy.Greetings(theBadGuy);
        theBadGuy.Greetings(theGoodGuy);

        Console.WriteLine($@"The warrior {theGoodGuy.Name} is {theGoodGuy.Age}");
        Console.WriteLine($@"The warrior {theBadGuy.Name} is {theBadGuy.Age}");

        Console.WriteLine(theBadGuy.Height);
        Console.WriteLine($@"The damage from the sword of the warrior {theGoodGuy.Name} is {theGoodGuy.SwordWeapon.Damage}!");
        Console.WriteLine(theGoodGuy.SwordWeapon.Damage);

        Warrior firstWarrior = new Warrior();
        
        Console.WriteLine(Warrior.idCounter);

        Warrior secondWarrior = new Warrior(150, 50);
        
        Console.WriteLine(Warrior.idCounter);

        Warrior thirdWarrior = new Warrior(140, 78, "I am the third warrior", Faction.GoodGuy);

        Warrior fourthWarrior = new Warrior(100, 100, "fourth warrior", Faction.BadGuy);
      
        Console.WriteLine(Warrior.idCounter);


        Console.WriteLine($"FourthWarrior health points: {fourthWarrior.HealthPoints}");


        Console.WriteLine(secondWarrior.ID);

        Warrior.GetDefaultValues(firstWarrior);

        Tools.ColorfulWriteLine(firstWarrior.ID.ToString(), ConsoleColor.Cyan);
        Tools.ColorfulWriteLine(secondWarrior.ID.ToString(), ConsoleColor.Red);
        Tools.ColorfulWriteLine(thirdWarrior.ID.ToString(), ConsoleColor.DarkYellow);

        firstWarrior.Move(500);

        Mage firstMage = new Mage();
        firstMage.Move(200);

        try
        {
        firstMage.Age = 25;
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }



        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
        


    }
    }


