using System;
namespace TestProject.sorting
{
    public class QuickSortLinkedList
    {
        Node head;
        public void Sort()
        {
            while(head != null)
            {
                Console.WriteLine("Current node value {0}", head.Data);
                head = head.Next;
            }
        }

        public void AddNode(int data)
        {
            if(head == null)
            {
                head = new Node(data);
                return;
            }

            Node curr = head;
            while(curr.Next != null)
            {
                curr = curr.Next;
            }

            //Create a new node
            Node newNode = new Node(data);
            curr.Next = newNode;

        }
    }

    public class Node
    {
        public int Data;
        public Node Next;

        public Node(int data)
        {
            this.Data = data;
            this.Next = null;
        }
    }

}
