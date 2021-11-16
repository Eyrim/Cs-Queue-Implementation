using System;

namespace LinearQueue
{
    public class QueueUnderflowException : Exception
    {
        public QueueUnderflowException(string message = "Queue Underflow") : base(message)
        {
            
        }

        public QueueUnderflowException(Exception inner, string message = "Queue Underflow") : base(message, inner)
        {
            
        }
   }
}