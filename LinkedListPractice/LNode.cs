using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListPractice
{
    public class LNode
    {
        //private string _storedData;
        public string storedData;
        public LNode nextNode;

        public LNode(string data)
        {
            storedData = data;
            nextNode = null;

        }


    }
}
