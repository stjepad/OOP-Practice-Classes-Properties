using Interfaces;
using System;
using System.Threading;

namespace Characters
{
    public abstract class Character
    {
        protected int healthPoints;
        protected int weight;
        protected int age;
        protected string name;



        public int HealthPoints
        {
            get
            {
                return healthPoints;
            }
            set
            {
                this.healthPoints = value;
            }
        }

        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                this.weight = value;
            }
        }

        public virtual int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value >= 18 && value <= 45)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $@"Please use age between 18 and 45");
                    //Console.WriteLine($@"The warrior {name} is too young to fight");
                }
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        //Custoructor for base inheritance for errors to go away
        public Character()
        {

        }
        // constructor for base inheritance
        public Character(int healthPoints, int weight, int age)
        {
            this.HealthPoints = healthPoints;
            this.Weight = weight;
            this.Age = age;
        }

        public void Greetings(string name)
        {
            Console.WriteLine($@"!!!!!!!!!!!!!!{this.name} greets {name}!");
        }


        public virtual void Move(int PauseBetweenMovements)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("I am moving ");
                Thread.Sleep(PauseBetweenMovements);
            }
        }

        public virtual void Addition(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber + secondNumber);
        }
    }
}
