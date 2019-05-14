using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04Part02
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowStack();
            Console.WriteLine("*****************************************************************************\n");
            ShowQueue();
            Console.ReadKey();
        }
        static void ShowStack()
        {
            StackX stackNou = new StackX();
            stackNou.push(5);
            stackNou.push(2);
            stackNou.push(56);
            stackNou.push(7);
            stackNou.push(89);
            stackNou.push(10);
            stackNou.PrintStack();
            stackNou.getTopElement();
            stackNou.pop();
            stackNou.getTopElement();
            stackNou.pop();
            stackNou.PrintStack();
            
        }
        static void ShowQueue()
        {
            QueueX queueNou = new QueueX();
            queueNou.QnqueueX(15);
            queueNou.QnqueueX(10);
            queueNou.QnqueueX(66);
            queueNou.PrintQueue();
            queueNou.QnqueueX(7);
            queueNou.PrintQueue();
            Console.WriteLine("Am scos: "+queueNou.DenqueueX().ToString());
            queueNou.PrintQueue();
            Console.WriteLine("Am scos: " + queueNou.DenqueueX().ToString());
            queueNou.PrintQueue();
        }
    }
   
    
}
