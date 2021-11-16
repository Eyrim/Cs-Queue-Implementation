using System;
using System.ComponentModel;

namespace LinearQueue
{
    public class QueueOverflowException : Exception
    {
        public QueueOverflowException(string message = "Queue Overflow") : base(message)
        {
            
        }

        public QueueOverflowException(Exception inner, string message = "Queue Overflow") : base(message, inner)
        {
            
        }
    }
}