using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqlite1
{
    class Program
    {
        static void Main(string[] args)
        {
            string myconfig = ConfigurationManager.AppSettings[" sqlite "];
            ICarsDAO dao = new CarsDAO();
            var result = dao.GetFirstCarAndIsTest();
        }
    }
}
