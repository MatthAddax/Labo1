using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo1
{
    class PersonComparer : IEqualityComparer<Person>
    {
        public bool Equals(Person x, Person y)
        {
            return (x.Equals(y) || x.Age == y.Age);
        }

        public int GetHashCode(Person obj)
        {
            return obj.Name.GetHashCode() + obj.Age.GetHashCode();
        }
    }
}
