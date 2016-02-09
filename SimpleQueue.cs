using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class SimpleQueue
    {
        private int queueSize;
        public int head;
        public int tail;
        private Object[] queue;

        public SimpleQueue(int size){
            queueSize = size;
            head = 0;
            tail = 0;
            queue = new Object[size];        
        }

        public void enqueue(Object data)
        {
            if(tail +1 < queueSize)
            {
                tail++;
                queue[tail] = data;
                if(head == 0)
                {
                    head = 1;
                }
            }
            else
            {
                throw new Exception("Queue Overflow");
            }
        }

        public Object dequeue()
        {
            if(head > 0)
            {
                Object data = queue[head];
                for(int i = head; i < tail; i++)
                {
                    queue[i] = queue[i + 1];
                }
                tail--;
                if(tail == 0)
                {
                    head = 0;
                }
                return data;
            }
            else
            {
                throw new Exception("Queue Underflow");
            }
        }
    }
}
