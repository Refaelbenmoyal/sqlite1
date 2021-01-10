using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqlite1
{
    class Cars
    {
        //poco
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public object ID { get; private set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Cars c = obj as Cars;
            if (c == null)
                return false;
            else
            {
                return this.ID == c.ID;
            }
        }

        public override int GetHashCode()
        {
            return this.Id;
        }
        public static bool operator ==(Cars c1, Cars c2)
        {
            if (c1 == null && c2 == null)
                return true;
            if (c1 == null || c2 == null)
                return false;
            else
            {
                return c1.ID == c2.ID;
            }
    
        }
        public static bool operator !=(Cars c1, Cars c2)
        {
            return !(c1 == c2);
        }

       

        public override string ToString()
        {
            return $"{ID} {Manufacturer} {Model} {Year}";
        }




    }
}
