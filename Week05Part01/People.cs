using System;

namespace Week05Part01
{
    class People : Comment
    {
        private string name;
        public string Name
        {
            get { return this.name; }
            set
            {
                if (value == null)
                    Console.WriteLine("Person must have a name!! ");
                else
                    this.name = value;
            }
        }

        public People(string name)
        {
            this.name = name;
        }

    }
}
