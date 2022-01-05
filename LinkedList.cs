using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class LinkedList
    {
        Node Head;
        Node Tail;
        public void Insert(int data)
        {
            var temp = new Node(data);

            if(Head==null)
            {
                Tail = Head = temp;
                return;
            }
            temp.Link = Head;
            Head = temp;
        }

        public void ShowNodes()
        {
            var sb = new StringBuilder();
            var temp = Head;
            while(temp != null)
            {
                if(temp.Link != null)
                    sb.Append(temp.data+" -> ");
                else
                    sb.Append(temp.data);
                temp = temp.Link;
            }
            System.Console.WriteLine(sb.ToString());

        }
    }
}