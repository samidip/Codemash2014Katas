﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tea_Party_Kata
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsKnighted { get; set; }
        public GenderDefinition Gender { get; set; }
        public DateTime Birthday { get; set; }
    }

    public enum GenderDefinition
    {
        Male,
        Female
    }
}
