using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowAnimals();
            Console.ReadKey();
        }
        public static void ShowAnimals()
        {
            Frog myFrog1 = new Frog("broscuta", 2, SexOfAnimal.Male, "doar saritoare");
            Frog myFrog2 = new Frog("broscuta", 3, SexOfAnimal.Female);
            Frog myFrog3 = new Frog("broscuta", 4);
            Frog[] frogs = new Frog[] { myFrog1, myFrog2, myFrog3 };

            Dog[] dogs = new Dog[]
            {
            new Dog("Rex",12,SexOfAnimal.Male,"bulldog"),
            new Dog("Giant", 1, SexOfAnimal.Female, "pudel"),
            new Dog("Cutu", 3, SexOfAnimal.Male, "ciobanesc"),
            new Dog("Cutu", 3, SexOfAnimal.Male),
            new Dog("Wolfy", 5),
            };

            Cat cat1 = new Cat("Miti",5,SexOfAnimal.Female,"negru");
            Cat cat2 = new Cat("Boss", 6, SexOfAnimal.Male);
            Cat cat3 = new Cat("Mya", 4);
            Cat[] cats = new Cat[] { cat1,cat2,cat3};

            Tomcat[] tomcats = new Tomcat[]
            {
                new Tomcat("Tom1",5,SexOfAnimal.Male,"albastru"),
                new Tomcat("Tom2",8,SexOfAnimal.Female),
                new Tomcat("Tom3",17)
            };

            Kitten[] kittens = new Kitten[]
           {
                new Kitten("kitty1",20,SexOfAnimal.Male,"alb"),
                new Kitten("kitty2",10,SexOfAnimal.Male),
                new Kitten("kitty3",15)
           };

            Console.WriteLine( " - " + Animal.calculateAverageAge(kittens));
            
            List<Animal[]> listaZoo=new List<Animal[]>() { frogs, dogs, cats, tomcats, kittens };
            foreach (var animalzoo in listaZoo)
            {
                Animal.PrintAnimals(animalzoo);
            }
        }

        }
    }



