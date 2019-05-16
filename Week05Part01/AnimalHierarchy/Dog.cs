using System;

namespace AnimalHierarchy
{
    class Dog : Animal
    {
        private string rasa;
        public string Rasa
        {
            get { return this.rasa; }
            set
            {
                if (value == null)
                {
                    Console.WriteLine("cainele trebuie sa aiba o rasa.vom seta Maidanez momentan!");
                    this.rasa = "Maidanez";
                }
                else
                    this.rasa = value;

            }
        }
        public Dog(string name, int age) : this(name, age, SexOfAnimal.NotVerified, "Labrador") { }
        public Dog(string name, int age, SexOfAnimal sex) : this(name, age, sex, "Labrador") { }
        public Dog(string name, int age, SexOfAnimal sex, string rasa) : base(name, age, sex)
        {
            this.rasa = rasa;
        }
        

        public override void ProduceSound()
        {
            Console.WriteLine($"Dog {this.Name} makes sound: Haaaam-Haamm");
        }

    }
}
