using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverList
{
    class RoverList : RoverListBase
    {
        // Add any variables you need here

        public RoverList()
        {

        }

        private int count = 0;
        public override int Count => count;

        public override void Add(object data)
        {
            if (head == null)
                head = new Node(data);
            else
                add(data, head);
            count++;
        }
        
        private void add(object data, Node n)
        {
            if (n.Next == null)
                n.Next = new Node(data);
            else
                add(data, n.Next);
        }
        

        public override void Add(int Position, object data)
        {
            Node n = ElementAt(Position);

            Node currentTarget = n.Next;

            Node insert = new Node(data);
            n.Next = insert;
            insert.Next = currentTarget;

            count++;

        }

        public override void Clear()
        {
            head = null;
            count = 0;
        }

        public override Node ElementAt(int Position)
        {
            Node n = head;
            for (int i = 0; i < Position; i++)
                n = n.Next;

            return n;
        }

        public override void ListNodes()
        {
            Node n = head;
            for (int i = 0; i < count; i++)
            {
                Console.Write((string)n.Data+" ");
                n = n.Next;                
            }
        }
        

        public override bool RemoveAt(int Position)
        {
            if (Position >= count || Position < 0) return false;
            
            if (Position == 0)
                head = head.Next;
            else
            {
                Node n = ElementAt(Position - 1);
                n.Next = n.Next.Next ?? null;
            }

            count--;
            return true;
        }
    }
}
