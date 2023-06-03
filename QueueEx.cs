using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueTest
{
    internal class QueueEx
    {
        Node front;
        Node rear;

        public void Enqueue(int data)
        {
            Node newnode = new Node(data);
            if(front == null)
            {
                rear = newnode;
                front = rear;
            }
            else
            {
                rear.Next = newnode;
                rear = rear.Next;
            }
        }

        public void Display()
        {
            if (front == null)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Node temp = front;
                while (temp != null)
                {
                    Console.Write("| " + temp.Data + " |");
                    temp = temp.Next;
                }
            }
        }
    }
}
