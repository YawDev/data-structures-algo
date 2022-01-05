using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStructures
{
    public class DoublyLinkedList
    {
        DoublyNode Head;
        DoublyNode Tail;

        public void Insert(int data)
        {
            var temp = new DoublyNode(data);
            if(Head == null)
            {
                Tail = Head = temp;
                return;
            }
            temp.Link = Head;
            Head.PreviousLink = temp;
            Head = temp;
        }

        public void ShowNodes()
        {
            var sb = new StringBuilder();
            var temp = Head;
            while(temp != null)
            {
                if(HasNext(temp) && HasPrevious(temp))
                   sb.Append("> "+temp.data+" <-");
                if(HasNext(temp) && !HasPrevious(temp))
                   sb.Append(temp.data+" <-");
                else if(!HasNext(temp) && HasPrevious(temp))
                    sb.Append("-> "+temp.data);
              
                temp = (DoublyNode)temp.Link;
            }
            sb.Replace("<-->", "<->");
            System.Console.WriteLine(sb.ToString());

        }

        public bool HasPrevious(DoublyNode node)
        {
            return node.PreviousLink != null;
        }

         public bool HasNext(DoublyNode node)
        {
            return node.Link != null;
        }
    }
}