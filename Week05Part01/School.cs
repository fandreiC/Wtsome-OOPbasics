using System;
using System.Collections.Generic;

namespace Week05Part01
{
    class School
    {
        private string name;
        private int schoolID;
        private List<Clasa> clase;
        public string Name
        {
            get { return this.name; }
            set
            {
                if (value == null) Console.WriteLine("Scoala are nevoie de un nume");
                else this.name = value;
            }
        }
        public int SchoolID
        {
            get { return schoolID; }
            set
            {
                if (value <= 0)
                    Console.WriteLine("scoala nun poate avea numar negativ !");
                else this.schoolID = value;
            }
        }
        public List<Clasa> Clase { get; set; }
        public School(string nume,int nr, List<Clasa> clase)
        {
            this.name = nume;
            this.schoolID = nr;
            this.clase = clase;
        }
        public void PrintSchool()
        {
            Console.WriteLine("Scoala {0} nr {1} , are clasele: ",this.Name,this.SchoolID);
            foreach (var clasa in clase)
            {
                Console.WriteLine($"- {clasa.TextIdentifier} --");
            }
        }

    }
}
