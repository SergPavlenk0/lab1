﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public static class MyListExtension
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            return list.list;
        }
    }
}
