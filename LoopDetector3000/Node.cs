using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopDetector3000
{

    class Node
    {
        private int Data { get; set; }
        public Node next { get; set; }

        public Node(int data, Node next)
        {
            Data = data;
            this.next = next;
        }

        public Node(int data)
        {
            Data = data;
            next = null;
        }

        public List<Node> ListNodes()
        {

            List<Node> nodes = new List<Node>();
            Node n = this;

            while (n != null)
            {
                nodes.Add(n);
                n = n.next;
            }

            return nodes;
        }

        public Boolean hasLoop()
        {
            Node slow = this;
            Node fast = next;

            while ( slow.next != null || fast.next != null )
            {

                slow = slow.next;
                if (fast.next.next != null)
                {
                    fast = fast.next.next;
                }

                if (slow == fast)
                {
                    return true;
                }

                return false;  
            }

            return false;
        }

        public override string ToString()
        {
            return "Node " + Data;
        }

    }
}
