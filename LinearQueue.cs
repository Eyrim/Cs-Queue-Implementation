namespace LinearQueue
{
    public class LinearQueue<T>
    {
        private int BackPointerPos = -1;
        private int FrontPointerPos = 0;
        private T[] Queue;

        public LinearQueue(int MaxSize)
        {
            // Instantiate a new array of MaxSize
            this.Queue = new T[MaxSize];
        }

        /// <summary>
        /// Push a value to the queue
        /// </summary>
        /// <param name="Value">The value to add to the queue</param>
        public void PushValue(T Value)
        {
            // Queue.Length; Doesn't count from 0
            if (BackPointerPos == Queue.Length - 1)
            {
                throw new QueueOverflowException();
            }
            
            // Increment the element the back pointer is on
            BackPointerPos++;

            // Add the value to the queue
            Queue[BackPointerPos] = Value;
        }
        
        /// <summary>
        /// Pop a value from the queue
        /// </summary>
        /// <returns>T</returns>
        public T PopValue()
        {
            // If the element at the front pointer position is null
            if (Queue[FrontPointerPos] == null)
            {
                throw new QueueUnderflowException();
            }
            
            // Record the element the front pointer is on in order to return it later
            T elementAtFrontPointer = Queue[FrontPointerPos];

            // Remove the value
            Queue.SetValue(value:null, index:FrontPointerPos);

            // Increment the front pointer to the new position
            ++FrontPointerPos;
            
            return elementAtFrontPointer;
        }
    }
}
