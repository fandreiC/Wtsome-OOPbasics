using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04Part02
{
    class QueueX
    {
        private XNode XHead;
        private XNode XTail;
        private int count = 0;
        public int Count
        {
            get { return this.count; }
        }
        public QueueX()
        {
            this.XHead = this.XTail = null;
        }

        public void QnqueueX(int data)
        {
            XNode nodNou = new XNode(data);
            if (XHead==null)
            {
                XHead = nodNou;
                XTail = XHead;
            }
            else
            {
                XTail.XNext = nodNou;
                XTail = XTail.XNext;
            }
            count++;
            Console.WriteLine("Am adaugat : "+data);
            
        }
        public int DenqueueX()
        {
            if (XHead==null)
            {
                Console.WriteLine("QList is empty;");
                return 0;
            }
            count--;
            int result = XHead.XData;
            XHead = XHead.XNext;
            return result;

        }
        public void PrintQueue()
        {
            Console.WriteLine("QueueList is .... ..");
            if (XHead==null)
            {
                Console.WriteLine("QueueList is empty");
            }
            XNode temp = this.XHead;
            while (temp!=null)
            {
                Console.WriteLine(" Q: "+temp.XData);
                temp = temp.XNext;
            }
            Console.WriteLine(".. ... End of Queue List");
        }

    }
}
