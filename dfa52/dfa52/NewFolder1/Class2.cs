using System;

namespace ConsoleApp7.Queues
{
    public class QueueLinkedList
    {
        private class Node
        {
            public int Data;
            public Node Next;
        }

        private Node front;
        private Node rear;

        public void Enqueue(int item)
        {
            Node newNode = new Node() { Data = item };
            if (rear == null)
                front = rear = newNode;
            else
            {
                rear.Next = newNode;
                rear = newNode;
            }
        }

        public int Dequeue()
        {
            if (front == null)
                throw new InvalidOperationException("Queue is empty.");

            int item = front.Data;
            front = front.Next;
            if (front == null)
                rear = null;

            return item;
        }

        public int Peek()
        {
            if (front == null)
                throw new InvalidOperationException("Queue is empty.");
            return front.Data;
        }
    }
}