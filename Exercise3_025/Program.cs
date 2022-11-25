using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_025
{
    //create class for Node
    class Node
    {
        /*creates Nodes for the circular nexted list*/
        public int rollNumber;
        public string name;
        public Node next;
    }
    //create class for Circularlist
    class Circularlist
    {
        // Initialize the Nodes.
        Node LAST;

        public Circularlist()
        {
            LAST = null;
        }

        public bool Search(int rollNo, ref Node previous, ref Node current) /*Searches for the specified node*/
        {
            for(previous = current = LAST.next; current != LAST; previous = current, current = current.next)
            {
                if(rollNo == current.rollNumber)
                    return (true); /*return true if the node is found*/

            }
            if (rollNo == LAST.rollNumber) /*If the node is present at the end*/
                return true;
            else
                return (false); /*return false if the node is not found*/
        }
        public bool listEmpty()
        {
            if (LAST == null) /*if the node has reached the end and the data is declared null 
                               * then the node will return to the initial data*/
                return true;
            else
                return false;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
