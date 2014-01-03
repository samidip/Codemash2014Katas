using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Lists_Kata
{
    public class DoubleLinkedList
    {
        private string Item { get; set; }
        private DoubleLinkedList Next { get; set; }
        private DoubleLinkedList Previous { get; set; }
    }
}
