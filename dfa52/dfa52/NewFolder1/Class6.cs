using System;

namespace ConsoleApp7.Deques
{
    public class DequeArray
    {
        private int[] deque;
        private int front;
        private int rear;
        private int size;
        private int count;

        public DequeArray(int size)
        {
            this.size = size;
            deque = new int[size];
            front = -1;
            rear = 0;
            count = 0;
        }

        public bool IsFull() => count == size;
        public bool IsEmpty() => count == 0;

       
        public void AddFront(int item)
        {
            if (IsFull())
                throw new InvalidOperationException("Deque is full.");

            if (IsEmpty())
            {
                front = 0;
                rear = 0;
            }
            else
            {
                front = (front - 1 + size) % size; 
            }

            deque[front] = item;
            count++;
        }

        
        public void AddRear(int item)
        {
            if (IsFull())
                throw new InvalidOperationException("Deque is full.");

            if (IsEmpty())
            {
                front = 0;
                rear = 0;
            }
            else
            {
                rear = (rear + 1) % size; 
            }

            deque[rear] = item;
            count++;
        }

        
        public int RemoveFront()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Deque is empty.");

            int item = deque[front];
            front = (front + 1) % size; 
            count--;

            
            if (IsEmpty())
            {
                front = -1;
                rear = 0;
            }

            return item;
        }

        public int RemoveRear()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Deque is empty.");

            int item = deque[rear];
            rear = (rear - 1 + size) % size;
            count--;

            
            if (IsEmpty())
            {
                front = -1;
                rear = 0;
            }

            return item;
        }

       
        public int PeekFront()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Deque is empty.");
            return deque[front];
        }

       
        public int PeekRear()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Deque is empty.");
            return deque[rear];
        }
    }
}