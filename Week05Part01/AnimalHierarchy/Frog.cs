using System;

namespace AnimalHierarchy
{
    class Frog : Animal
    {
        private string jucausa;
        public string Jucausa
        {
            get { return this.jucausa; }
            set { this.jucausa = value; }
           
        }
        public Frog(string name, int age) : this(name, age, SexOfAnimal.NotVerified, "putin jucausa") { }
        public Frog(string name, int age, SexOfAnimal sex) : this(name, age, sex, "prea jucausa") { }
        public Frog(string name, int age, SexOfAnimal sex, string jucausa) : base(name, age, sex)
        {
            this.jucausa = jucausa;
        }

        public override void ProduceSound()
        {
            Console.WriteLine($"Broasca {this.Name} makes sound: OOaaccc- OOaaakkk");
        }

    }
}
