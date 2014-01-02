using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tea_Party_Kata
{
    interface ITeaPartyWelcome
    {
        string Welcome(string lastName, string gender, bool isKnighted);
    }
}
