using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
    public class Node
    {
        //member variables (HAS A)
        int dataType;
        public Node rightLink;
        public Node leftLink;
        public int DataType
        {
            get
            { return dataType; }
        }
        //constructor (SPAWNER)
        public Node()
        {
            dataType = 0;
            rightLink = null;
            leftLink = null;
        }
        //member methods (CAN DO)
    }
}
