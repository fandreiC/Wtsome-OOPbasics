using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week05Part01
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolManager.ShowSchool();
            Console.ReadKey();
        }
    }
    class SchoolManager
    {
        public static void ShowSchool()
        {
            Student SAndrei = new Student("Andrei", 2);
            SAndrei.SetComment("Andrei is a good student!");
            Student SGeorge = new Student("George", 3);
            SGeorge.SetComment("George is a decent student!");
            Student SAlina = new Student("Alina", 4);
            SAlina.SetComment("Alina is a nice student!");

            Discipline DIstorie = new Discipline("istorie", 4, 3);
            DIstorie.SetComment("Obiectul Istorie este fabulos!");
            Discipline DInformatics = new Discipline("Informatica", 8, 5);
            DInformatics.SetComment("Obiectul Informatica este frumos!");
            Discipline DGrammar = new Discipline("Gramatica", 6, 2);
            DInformatics.SetComment("Obiectul Gramatica este greu!");
            var listaDiscipline = new List<Discipline>() { DIstorie, DInformatics ,DGrammar};

            var disciplineAlex = new List<Discipline>() { DInformatics,DGrammar };
            Teacher TAlex = new Teacher("Alex", disciplineAlex);
            TAlex.SetComment("Alex is a perfect teacher");
            var disciplineBogdan = new List<Discipline>() { DIstorie,DGrammar };
            Teacher TBogdan = new Teacher("Bogdan", disciplineBogdan);
            TBogdan.SetComment("Bogdan is a great teacher");

            var listaProfesori1 = new List<Teacher>() { TAlex};
            var listaStudenti1 = new List<Student>() { SAndrei};
            Clasa clasa1 = new Clasa(listaProfesori1,listaStudenti1,"A1");
            var listaProfesori2 = new List<Teacher>() { TBogdan };
            var listaStudenti2 = new List<Student>() { SGeorge };
            Clasa clasa2 = new Clasa(listaProfesori2, listaStudenti2, "A2");

            var listaClase = new List<Clasa>() { clasa1, clasa2 };
            School scoalanr2 = new School("scoala2", 2,listaClase);

            SAndrei.PrintComment();
            Console.WriteLine("# # # # ");
            TAlex.Teaches();
            Console.WriteLine("# # # # ");
            DIstorie.PrintComment();
            Console.WriteLine("# # # # ");
            TBogdan.PrintComment();
            Console.WriteLine("# # # # ");
            clasa1.PrintClass();
            Console.WriteLine("# # # # ");
            scoalanr2.PrintSchool();
            Console.WriteLine("# # # # ");
            SAndrei.SetComment("la fel in fiecare an de studiu!");
            SAndrei.PrintComment();
            Console.WriteLine("# # # # ");
            clasa2.PrintClass();
            

        }
    }
}
