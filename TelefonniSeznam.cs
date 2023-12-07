using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekce9
{
    internal class TelefonniSeznam
    {
        public const int policie = 158;
        public const int zachranka = 155;
        public const int hasici = 150;
        public readonly int mojeCislo;
        public TelefonniSeznam(int mojeCislo)
        {
            this.mojeCislo = mojeCislo;
        }
    }
}
