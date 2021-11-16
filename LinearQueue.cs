using System;

namespace LinearQueue
{
    public class LinearQueue<T>
    {
        private int MAXSIZE;
        private int BackPointerPos = -1;
        private int FrontPointerPos = 0;
        private T[] Queue;

        public LinearQueue(int MaxSize)
        {
            this.MAXSIZE = MaxSize;
            this.Queue = new T[MaxSize];
        }

        public void AddValue(T Value)
        {
            if (BackPointerPos == MAXSIZE - 1)
            {
                throw new QueueOverflowException();
            }
            
            BackPointerPos++;
            Queue[BackPointerPos] = Value;
        }

        public T RemoveValue()
        {
            if (Queue[FrontPointerPos] == null)
            {
                throw new QueueUnderflowException();
            }
            
            T value = Queue[FrontPointerPos];
            Queue.SetValue(value:null, FrontPointerPos);
            ++FrontPointerPos;
            
            return value;
        }
    }
}