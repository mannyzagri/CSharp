﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class PersonCompareByHeight : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            if (x.Height > y.Height)
                return 1;
            if (x.Height == y.Height)
                return 0;
            else
            {
                return -1;
            }
        }
    }
}
