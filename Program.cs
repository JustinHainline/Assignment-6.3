namespace Assignment_6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Dequeue();
            q.Dequeue();
            q.Enqueue(3);   
            q.Enqueue(4);
            q.Enqueue(5);
            q.Enqueue(6);
            q.Enqueue(7);
            q.Dequeue();
            q.Dequeue();
            q.Enqueue(8);
            q.Enqueue(9);
            q.Enqueue(10);

            Console.WriteLine("Queue Front: " + (q.front != null ? q.front.Data.ToString() : "-1"));
            Console.WriteLine("Queue Rear: " + (q.rear != null ? q.rear.Data.ToString() : "-1"));
        }


        class QueueNode
        {
            public int Data { get; set; }
            public QueueNode Next { get; set; }

            public QueueNode(int data)
            {
                Data = data;
                Next = null;
            }
        }

        class Queue
        {
            public QueueNode front;
            public QueueNode rear;

            public Queue()
            {
                front = rear = null;
            }

            public void Enqueue(int x)
            {
                QueueNode temp = new QueueNode(x);

                if (rear == null)
                {
                    front = rear = temp;
                    return;
                }
                rear.Next = temp;
                rear = temp;
            }

            public void Dequeue()
            {
                if (front == null)
                {
                    Console.WriteLine("Queue is empty.");
                    return;
                }

                QueueNode temp = front;
                front = front.Next;

                if (front == null)
                {
                    rear = null;
                }
                
                //delete old front node
               // temp = null;
            }
        }
    }
}
