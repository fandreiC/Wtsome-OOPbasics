using System;
using System.Collections.Generic;

namespace Week05Part01
{
    class Clasa
    {
        private string textIdentifier;
        private List<Teacher> teachersList;
        private List<Student> studentsList;
        public Clasa(List<Teacher> teachers, List<Student> students, string textID)
        {
            this.textIdentifier = textID;
            this.teachersList = teachers;
            this.studentsList = students;
        }

        public List<Teacher> TeacherList
        {
            get { return this.teachersList; }
            set { this.teachersList = value; }
        }
        public List<Student> StudentsList
        {
            get { return this.studentsList; }
            set { this.studentsList = value; }
        }
        public string TextIdentifier
        {
            get { return this.textIdentifier; }
            set
            {
                if (value == null)
                    Console.WriteLine("Class identification TExt must have a value !");
                else
                    this.textIdentifier = value;
            }
        }
        public void PrintClass()
        {
            Console.WriteLine("Clasa {0} are urmaorii profesori:", this.TextIdentifier);
            foreach (var teacher in TeacherList)
            {
                Console.WriteLine($" Nume: {teacher.Name} preda disciplinele: ");
                foreach (var disciplina in teacher.DisciplineToTeach)
                {
                    Console.WriteLine("- Nume disciplina : {0} , Numar Lecturi: {1} , numar exercitii {2}",
                        disciplina.Name, disciplina.NrOfLectures, disciplina.NrOfExercises);
                }
            }
        }

    }
}
