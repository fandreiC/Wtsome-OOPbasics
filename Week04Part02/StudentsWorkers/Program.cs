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
            //impletenting in progress
        }
    }
    public abstract class Human
    {
        internal string FirstName { get; set; }
        internal string LastName { get; set; }
        public Human(string fName) : this(fName, "NoLastName") { }
        public Human(string fname,string lname)
        {
            this.FirstName = fname;
            this.LastName = lname;
        }


    }
    public class Student : Human
    {
        public Student(string name) : base(name) { }
        public Student(string fname,string lname,int grade) : base(fname, lname)
        {
            this.Grade = grade;
        }
        
        internal int Grade { get; set; }

    }
    public class Worker : Human
    {
        internal int WeekSalary { get; set; }
        internal int WorkHoursPerDay { get; set; }

        public Worker(string name) : base(name) { }
        public Worker(string fname, string lname, int salary,int program) : base(fname, lname)
        {
            this.WeekSalary = salary;
            this.WorkHoursPerDay = program;
        }
       

        public int MoneyPerHour()
        {
            return 12;
        }
    }
    
}
