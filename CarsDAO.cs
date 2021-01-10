using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqlite1
{
    class CarsDAO : ICarsDAO
    {
        public Cars Cars_ID { get; private set; }


        public object GetFirstCarAndIsTest()
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source = c:\\Users\\refae\\sqlite1.db; Version = 3;"))
            {
                conn.Open();

                using (SQLiteCommand select_query = new SQLiteCommand("SELECT * from Cars", conn))
                {
                    using (SQLiteDataReader reader = select_query.ExecuteReader())
                    {
                        while (reader.Read() == true)
                        {
                            Cars c = new Cars()
                            {
                                Id = (int)reader["Cars_ID"],
                                Manufacturer = (string)reader["Manufacturer"],
                                Model = (string)reader["Model"],
                                Year = (int)reader["Year"]
                            };
                            var t = new Tests()
                            {
                                Id = (int)reader["Tests.ID"],
                                Car_ID = (int)reader["Cars_ID"],
                                IsPassed = (bool)reader["IsPassed"],
                                Date = (int)reader["Date"],
                            };
                            var result = new { c, t };
                        }
                        
                    }
                }
            }
        }
    }
}
