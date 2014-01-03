using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Lists_Kata
{
    public class SingleLinkedList
    {
        private string Item { get; set; }
        private SingleLinkedList Next { get; set; }

        public SingleLinkedList(string itemValue)
        {
            Item = itemValue;
        }

        protected SingleLinkedList Last
        {
            get
            {
                SingleLinkedList Target;

                for (Target = this; Target.Next != null; Target = Target.Next) { }

                return Target;
            }
        }

        public void Add(string newItemValue)
        {
            Last.Next = new SingleLinkedList(newItemValue);
        }

        public bool Find(string itemToFind)
        {
            SingleLinkedList Target = this;

            while(Target != Target.Last)
            {                
                if (Target.Item == itemToFind)
                {
                    return true;
                }

                Target = Target.Next;
            }

            // Account for last node.
            if (Target.Item == itemToFind)
                return true;

            return false;
        }

        public void Remove(string itemToRemove)
        {
            SingleLinkedList Target;
            SingleLinkedList OneBefore = null;

            for (Target = this; Target.Next != null; Target = Target.Next)
            {                
                if (Target.Item == itemToRemove)
                {
                    OneBefore.Next = Target.Next;
                    break;
                }
                OneBefore = Target;
            }
        }
    }
}
