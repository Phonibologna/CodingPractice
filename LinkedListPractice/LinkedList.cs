using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListPractice
{
    class LinkedList
    {
        LNode Header;
        public LinkedList(LNode starter)
        {
            Header = starter;
        }

        public void insertInFront(string newData)
        {
            LNode newHead = new LNode(newData);
            newHead.nextNode = this.Header;
            this.Header = newHead;
        }

        public void insertInBack(string newData)
        {
            LNode newBack = new LNode(newData);
            
            if (this.Header == null)
            {
                this.Header = newBack;
                return;
            }
            LNode temp = this.getLastNode();
            temp.nextNode = newBack;           
        }

        public LNode getLastNode()
        {
            LNode temp = this.Header;
            while(temp.nextNode != null)
            {
                temp = temp.nextNode;
            }
            return temp;
        }

        public void insertAfterNode(LNode previousNode, string newData)
        {
            LNode toInsert = new LNode(newData);
            toInsert.nextNode = previousNode.nextNode;
            previousNode.nextNode = toInsert;
        }

        public void deleteNode(LNode previousNode, string key)
        {
            LNode temp = this.Header;
            LNode prev = null;

            if(temp != null && temp.storedData == key)
            {
                this.Header = temp.nextNode;
                return;
            }
            while(temp != null && temp.storedData != key)
            {
                prev = temp;
                temp = temp.nextNode;
            }
            if(temp == null)
            {
                return;
            }
            prev.nextNode = temp.nextNode;


        }

    }
}
