using System;

namespace AnimalHierarchy
{
    class Cat : Animal
    {
        private string color;
        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public Cat(string name, int age) : this(name, age, SexOfAnimal.NotVerified, "black&white") { }
        public Cat(string name, int age, SexOfAnimal sex) : this(name, age, sex, "black&white") { }
        public Cat(string name, int age, SexOfAnimal sex, string color) : base(name, age, sex)
        {
            this.color = color;
        }

        public override void ProduceSound()
        {
            Console.WriteLine($"Cat {this.Name} makes sound: Miiiiiaaauuuu");
        }

    }
    class Kitten : Cat
    {
        public Kitten(string name, int age) : this(name, age, SexOfAnimal.Female, "pink") { }
        public Kitten(string name, int age, SexOfAnimal sex) : this(name, age, SexOfAnimal.Female, "pink") { }
        public Kitten(string name, int age, SexOfAnimal sex, string color) : base(name, age, SexOfAnimal.Female, "pink") { }

        public override void ProduceSound()
        {
            //base.ProduceSound();
            //Console.WriteLine("a kitten is still a cat!");
            Console.WriteLine($"Kitty {this.Name} makes sound: Miiiiiaaauuuu");
        }

    }
    class Tomcat : Cat
    {
        public Tomcat(string name, int age) : this(name, age, SexOfAnimal.Male, "orange") { }
        public Tomcat(string name, int age, SexOfAnimal sex) : this(name, age, SexOfAnimal.Male, "orange") { }
        public Tomcat(string name, int age, SexOfAnimal sex, string color) : base(name, age, SexOfAnimal.Male, "orange") { }

        public override void ProduceSound()
        {
            // base.ProduceSound();
            // Console.WriteLine("a Tomcat is still a cat!");
            Console.WriteLine($"Tomcat {this.Name} makes sound: Miiiiiaaauuuu");
        }

    }
}
