using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollectionsPractice
{
    public class OverwatchLinkedList
    {
        public Node head; //The "head" or top node of the list
        public Node current; //The current node
        public Node tail; //The last node

        public OverwatchLinkedList() //LinkedList constructor that will hold the properties
        {
        head = new Node(); //The "head" represents a new Node (which would be on top = head)
        current = head; //Current resembles the current Node which would be "head"
        }


        //BELOW WILL BE METHODS TO NAVIGATE THE LINKEDLIST
        
        public void addNode(string data) //Method to add a Node
        {
            Node newNode = new Node(); //Creates a new Node which will be the next Node
            newNode.Value = data;
            current.Next = newNode;
            current = newNode;
        }

        public void removeNode() //Method to remove a Node
        {
            
        }
    }
}