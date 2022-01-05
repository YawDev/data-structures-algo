namespace DataStructures
{
    public class Node
    {
        public int data;
        public Node Link;
        public Node(int data)
        {
            this.data=data;
        }
    }

    public class DoublyNode : Node
    {
         public Node PreviousLink;
        public DoublyNode(int data) : base(data)
        {
            
        }
    }
}