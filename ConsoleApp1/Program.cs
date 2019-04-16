using System;
using Characters.Warriors;
using Characters.Spellcasters;
using Enumerations;
using Characters;
using System.Collections.Generic;
using Interfaces;

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

        firstWarrior.Addition(12, 12);
        firstMage.Addition(200, 200);

        Console.WriteLine($"first warrior health points before attack{firstWarrior.HealthPoints}");
        Console.WriteLine($"first mage Mana points before attack{firstMage.Mana}");

        firstMage.CastSpell(firstWarrior);

        Console.WriteLine($"first warrior health points after attack{firstWarrior.HealthPoints}");
        Console.WriteLine($"first mage Mana points after attack{firstMage.Mana}");

        //Polymorphism
        //Character seventhWarrior = new Warrior();
        //Warrior tempWarrior = (Warrior)seventhWarrior;
        

        List<Character> theCharacters = new List<Character>();

        
        //Warrior tempWarrior = (Warrior)theCharacters[0];

        // way #1... Foreach loop to get specific details of a type of character from a list
        //foreach (var character in theCharacters)
        //{
        //    if (character.GetType().Name == "Warrior")
        //    {
        //        Warrior tempWarrior = (Warrior)character;
        //        Console.WriteLine(tempWarrior.SwordWeapon.Damage);
        //    }
        //}

        // way #2...ForEach loop to get specific details of a type of character from a list
        foreach (var character in theCharacters)
        {
            if (character is Warrior)
            {
                Warrior tempWarrior = character as Warrior;
                Console.WriteLine(tempWarrior.SwordWeapon.Damage);
            }
        }

        List<ICalculator> calculators = new List<ICalculator>();

        theCharacters.Add(firstWarrior);
        theCharacters.Add(firstMage);

        PerformGreeting(theCharacters);
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
        public static void PerformGreeting(IEnumerable<Character> characters)
        {
            foreach (var item in characters)
            {
                item.Greetings("Tod");
            }
        }
    }


