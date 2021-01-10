using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqlite1
{
    class Tests
    {
        //poco
        public int Id { get; set; }
        public int Car_ID { get; set; }
        public bool IsPassed { get; set; }
        public int Date { get; set; }
        public object ID { get; private set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Tests t = obj as Tests;
            if (t == null)
                return false;
            else
            {
                return this.ID == t.ID;
            }
        }

        public override int GetHashCode()
        {
            return this.Id;
        }
        public static bool operator ==(Tests t1, Tests t2)
        {
            if (t1 == null && t2 == null)
                return true;
            if (t1 == null || t2 == null)
                return false;
            else
            {
                return t1.ID == t2.ID;
            }

        }
        public static bool operator !=(Tests t1, Tests t2)
        {
            return !(t1 == t2);
        }
        public override string ToString()
        {
            return $"{ID} {Car_ID} {IsPassed} {Date}";
        }

    }
}
