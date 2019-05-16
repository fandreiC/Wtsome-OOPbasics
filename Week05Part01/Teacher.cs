using System;
using System.Collections.Generic;

namespace Week05Part01
{
    class Teacher : People
    {
        private List<Discipline> disciplinesToTeach;
        public List<Discipline> DisciplineToTeach
        {
            get { return this.disciplinesToTeach; }
            set
            {
                if (value == null)
                    Console.WriteLine("Disciplina nu poate fi null");
                else this.disciplinesToTeach = value;
            }
        }
        public Teacher(string nume, List<Discipline> discipline) : base(nume)
        {
            this.disciplinesToTeach = discipline;
        }

        public void Teaches()
        {
            foreach (var discipline in disciplinesToTeach)
            {
                Console.WriteLine($"Teacher {this.Name} teaches {discipline.Name}");
            }
            Console.WriteLine();
        }
    }
}
