using System;

namespace Week05Part01
{
    class Comment
    {
        private string comments;
        public Comment()
        {
            this.comments = string.Empty;
        }
        public string Comments
        {
            get { return this.comments; }
            set { this.SetComment(ref this.comments, value); }
        }
        public void SetComment(ref string textInitial, string textToAdd)
        {
            textInitial = String.Concat(textInitial, "\n");
            textInitial = String.Concat(textInitial, textToAdd);
        }
        public void SetComment(string newText)
        {
            SetComment(ref this.comments, newText);
        }
        public void PrintComment()
        {
            Console.WriteLine("comments are: " + this.comments);
        }
    }
}
