using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsWorkers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Worker> listaWorkers = new List<Worker>()
            {
                new Worker("Adrian","adrian",230,10),
                new Worker("Marius"),
                new Worker("Alex","alex",300,6),
                new Worker("Zorro","zoro",400,6),
                new Worker("Bogdan","bogdan",500,6),
                new Worker("David","zoro",600,9),
                new Worker("David","alex",700,10),
                new Worker("Ana","maria",300,6),
                new Worker("Maria","ana",300,6),
                new Worker("Carmen")
            };
            List<Student> listaStudenti = new List<Student>()
            {
                new Student("Andrei","andrei",6),
                new Student("Mihai"),
                new Student("Mihai","mihai",6),
                new Student("Maria","mihai",8),
                new Student("Luciana","Ana",7),
                new Student("Marian","ion",4),
                new Student("Ionut","zoro",8),
                new Student("Ionut","alin",10),
                new Student("Lucian","ionut",8),
                new Student("Pavel"),
            };

            StudentWorker.SortStudentsByGrade(listaStudenti);
            StudentWorker.SortWorkersByMoneyPerHour(listaWorkers);
            StudentWorker.MergeLists(listaStudenti,listaWorkers);
            Console.ReadKey();

        }
    }

    class StudentWorker
    {
       public static void SortStudentsByGrade(List<Student> students)
        {
            Console.WriteLine("\nLista Studenti sortata dupa Grade :");
            var sortedStudents = from student in students
                                 orderby student.Grade ascending
                                 select student;
            foreach (var student in sortedStudents)
            {
                Console.WriteLine("FName: {0} , LName: {1} ,grade: {2}",
                    student.FirstName, student.LastName, student.Grade);
            }

        }

        public static void SortWorkersByMoneyPerHour(List<Worker> workers)
        {

            Console.WriteLine("\nLista Workers sortata dupa MoneyPerHour :");
            var sortedWorkers = workers.OrderByDescending(x => x.MoneyPerHour());
            foreach (var worker in sortedWorkers)
            {
                Console.WriteLine("Fname: {0} , LName: {1} , weekSalary: {2} , hoursPerWeek: {3} , MoneyPerHour: {4}",
                    worker.FirstName, worker.LastName, worker.WeekSalary, worker.WorkHoursPerDay, worker.MoneyPerHour());
            }
        }
        public static void MergeLists(List<Student> studenti, List<Worker> workers)
        {
            Console.WriteLine("\nLista Studenti + workers sortate dupa nume :");
            List<Human> humenList = new List<Human>();
            humenList.AddRange(studenti);
            humenList.AddRange(workers);
            var sortedHumen = from human in humenList
                              orderby human.FirstName, human.LastName
                              select human;
            foreach (var human in sortedHumen)
            {
                Console.WriteLine($"Fname & Lname:  {human.FirstName} {human.LastName}");
            }
        }
    }
    public abstract class Human
    {
        internal string FirstName { get; set; }
        internal string LastName { get; set; }
        public Human(string fName) : this(fName, "NoLastName") { }
        public Human(string fname, string lname)
        {
            this.FirstName = fname;
            this.LastName = lname;
        }
        

    }
    public class Student : Human
    {
        public Student(string name) : base(name)
        {
            this.Grade = 5;
        }
        public Student(string fname, string lname, int grade) : base(fname, lname)
        {
            this.Grade = grade;
        }

        internal int Grade { get; set; }

    }
    public class Worker : Human
    {
        internal int WeekSalary { get; set; }
        internal int WorkHoursPerDay { get; set; }

        public Worker(string name) : base(name)
        {
            this.WeekSalary = 500;
            this.WorkHoursPerDay = 8;
        }
        public Worker(string fname, string lname, int salary, int program) : base(fname, lname)
        {
            this.WeekSalary = salary;
            this.WorkHoursPerDay = program;
        }


        public int MoneyPerHour()
        {
            return (this.WeekSalary / (WorkHoursPerDay * 5));
        }
    }

}
