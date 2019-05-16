using System;

namespace Week05Part01
{
    class Discipline : Comment
    {
        private string name;
        private int nrOfLectures;
        private int nrOfExercises;

        public string Name { get { return name; } set { this.name = value; } }
        public int NrOfLectures
        {
            get { return nrOfLectures; }
            set
            {
                if (value < 0)
                    Console.WriteLine("No of Lectures must be positive ");
                else
                    this.nrOfLectures = value;
            }
        }
        public int NrOfExercises
        {
            get { return nrOfExercises; }
            set
            {
                if (value < 0)
                    Console.WriteLine("No of Exercises must be positive ");
                else
                    this.nrOfExercises = value;
            }
        }
        public Discipline(string disciplineName, int NrLectures, int nrExercises)
        {
            this.name = disciplineName;
            this.nrOfExercises = nrExercises;
            this.nrOfLectures = NrLectures;
        }


    }
}
