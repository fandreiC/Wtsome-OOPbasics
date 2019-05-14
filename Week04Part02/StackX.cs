using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04Part02
{
    class StackX
    {

        XNode top;
        public StackX()
        {
            this.top = null;
        }

        internal void push(int data)
        {
            XNode nodnou = new XNode(data);
            if (top==null)
            {
                nodnou.XNext = null;
                
            }
            else
            {
                nodnou.XNext = top;
            }
            
            top = nodnou;
            
            Console.WriteLine($"{data} pushed to stackList");
            
        }
        internal void pop()
        {
            if (top==null)
            {
                Console.WriteLine("StackList is empty;");
                return;
            }
            Console.WriteLine("Data ce a fost scoasa : "+top.XData);
            top = top.XNext;
        }
        internal void getTopElement()
        {
            if (top==null)
            {
                Console.WriteLine("StackList is empty ");
                return;
            }
            Console.WriteLine("In capatul listei Stack se afla: "+this.top.XData);
        }
        internal void PrintStack()
        {
            if (top==null)
            {
                Console.WriteLine("Stack List is empty");
                return;
            }
            XNode temp = this.top;
            while (temp!=null)
            {
                Console.WriteLine(" : "+temp.XData);
                temp = temp.XNext;
            }
            Console.WriteLine("End of stackList");
        }

    }
}
