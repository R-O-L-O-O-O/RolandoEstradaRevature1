namespace CollectionsPractice;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!\n");

        LinkedList lnklist = new LinkedList();
        lnklist.PrintAllNodes();
        Console.WriteLine();

        lnklist.AddAtLast(12);
        lnklist.AddAtLast("John");
        lnklist.AddAtLast("Peter");
        lnklist.AddAtLast(34);
        lnklist.PrintAllNodes();
        Console.WriteLine();

        lnklist.AddAtStart(55);
        lnklist.PrintAllNodes();
        Console.WriteLine();

        lnklist.RemoveFromStart();
        lnklist.PrintAllNodes();

        Console.ReadKey();
    }

    public class Node //Represents the actual Node
    {
        public Node Next; //This points to the next Node
        public object Value; //This represents the current Node's data
    }
        
    public class LinkedList
    {

        public void AddAtLast(object data) //Add Node after last element
        {
        Node newNode = new Node();
        newNode.Value = data;
        current.Next = newNode;
        current = newNode;
        Count++;
        }

        public void AddAtStart(object data) //Add Node as first element
        {
        Node newNode = new Node() { Value = data};
        newNode.Next = head.Next; //new node will have reference of head's next reference
        head.Next = newNode; //and now head will refer to new node
        Count++;
        }

        public void RemoveFromStart() //Remove node from start
        {
        if (Count > 0)
        {
            head.Next = head.Next.Next;
            Count--;
        }
        else
        {
            Console.WriteLine("No element exist in this linked list.");
        }
        }

        /// <summary>
        /// Traverse from head and print all nodes value
        /// </summary>

        public void PrintAllNodes()
        {
        //Traverse from head
        Console.Write("Head ->");
        Node curr = head;
        while (curr.Next != null)
        {
        curr = curr.Next;
        Console.Write(curr.Value);
        Console.Write("->");
        }
        Console.Write("NULL");
        }
    }


}