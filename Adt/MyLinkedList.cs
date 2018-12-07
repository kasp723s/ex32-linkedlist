using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adt
{

    public class MyLinkedList
    {
        private class Node
        {
            private Node next;
            private Object data;
            public Node Next
            {
                get { return next; }
                set { next = value; }
            }
            public Object Data
            {
                get { return data; }
                set { data = value; }
            }

            public Node(object data)
            {

                Data = data;
            }
        }

        private Node Head;
        public int Count;


        public void Insert(Object data, int index)
        {
            if (index == 0)
            {
                Insert(data);
            }
            else
            {
                Node newNode = new Node(data);
                Node currentNode = NodeAt(index - 1);

                if (currentNode == null)
                {
                    newNode.Next = null;
                }
                else
                {
                    newNode.Next = currentNode.Next;
                }
                currentNode.Next = newNode;
                Count = Count + 1;
            }
        }
        public void Insert(Object data)
        {
            Node newNode = new Node(data);
            newNode.Next = Head; // newNode will have reference of head's next reference.
            Head = newNode; // Head will refer to new node.
            Count = Count + 1;
        }
        public void Delete() //fjerner det første element i listen.
        {
            if (Count > 0)
            {
                Head = Head.Next;
                Count = Count - 1;
            }
            else
            {
                Console.WriteLine("No element exists in this linked list");
            }

        }
        public void Delete(int index)
        {
            if (index == 0)
            {
                Insert(data);
            }
            else
            {
                Node currentNode = NodeAt(index - 1);

                if (currentNode == null)
                {
                    newNode.Next = null;
                }
                else
                {
                    newNode.Next = currentNode.Next;
                }
                currentNode.Next = ;
                Count = Count + 1;
            }
        }
        public Object ItemAt(int index)
        {
            return NodeAt(index).Data;
        }

        private Node NodeAt(int index)
        {
            Node pegepind = Head;
            for (int i = 0; i < index; i++)
            {
                pegepind = pegepind.Next;

            }

            return pegepind;
        }

        public override string ToString()
        {
            string result = "";
            Node pegepind = Head;
            while (pegepind != null)
            {
                result = result + pegepind.Data.ToString() + "\n";
                pegepind = pegepind.Next;

            }
            return result;
        }
    }

}
