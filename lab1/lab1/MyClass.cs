using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class MyClass<T> where T : new()
    {
        static T FactoryMethod()
        {
            return new T();
        }
    }
}
