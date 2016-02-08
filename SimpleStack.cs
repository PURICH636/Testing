using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApplication2
{
    public class SimpleStack
    {
        private int stackSize;
        private int top;
        private Object[] stack;

        public SimpleStack(int size)
        {
            stackSize = size;
            top = 0;
            stack = new Object[stackSize];
        }

        public void push(object data)
        {
            if(top + 1 < stackSize){
                top++;
                stack[top] = data;
            }
            else {
                throw new Exception("Stack Overflow");
            }
        }

        public Object pop()
        {
            if(top > 0)
            {
                Object data = stack[top];
                top--;
                return data;
            }
            else
            {
                throw new Exception("Stack Underflow");
            }
        }

        public int count()
        {
            if (top > 0)
            {
                return top;
            }
            if(top < 1)
            {
                return 0;
            }
            else
            {
                throw new Exception("Stack Underflow");
            }
        }
    }
}
