namespace Week05Part01
{
    class Student : People
    {
        private int classNumber;

        public int ClassNumber { get; set; }

        public Student(string name, int numar) : base(name)
        {
            this.classNumber = numar;
        }



    }
}
