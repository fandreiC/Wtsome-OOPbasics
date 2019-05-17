using System;
using System.Collections.Generic;

namespace AnimalHierarchy
{
    enum SexOfAnimal
    {
        Male, Female, NotVerified
    }
    abstract class Animal : ISound
    {
        private string name;
        private int age;
        private SexOfAnimal sex;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                    Console.WriteLine("Age can't be negative!");
                else
                    this.age = value;
            }
        }
        public SexOfAnimal Sex
        {
            get { return this.sex; }
            set { this.sex = value; }
        }
        public Animal(string name, int age, SexOfAnimal sex)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
        }

        public abstract void ProduceSound();

        public static double calculateAverageAge(Animal[] animale)
        {
            double sum = 0;
            foreach (var animal in animale)
            {
                sum += animal.Age;
            }
            sum = sum / animale.Length;
            return sum;
        }

        public static void PrintAnimals(Animal[] animals)
        {
            Console.WriteLine("\n animals are {0} , have an average age of: {1}",
                animals.GetType(), calculateAverageAge(animals));
            animals[0].ProduceSound();

            foreach (var animal in animals)
            {

                Console.Write(" Name: {0}, age: {1}, gender: {2} ",
                    animal.Name, animal.Age, animal.Sex);
                if (animal is Frog)
                    Console.WriteLine(" # jucausa: " + ((Frog)animal).Jucausa);
                if (animal is Dog)
                    Console.WriteLine(" # rasa: " + ((Dog)animal).Rasa);
                if (animal is Cat)
                    Console.WriteLine(" # culoare: " + ((Cat)animal).Color);
            }


        }

    }
}
