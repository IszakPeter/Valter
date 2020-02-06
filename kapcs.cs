using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace _2020_01_17
{
    class kapcs
    {

       static SQLiteConnection kapcsolat;
       public static SQLiteCommand parancs_a;
        public static SQLiteCommand parancs_b;
        public static SQLiteDataReader eredmeny_a;
        public static SQLiteDataReader eredmeny_b;
        public static SQLiteDataAdapter adapter;
        public static void kapcsolodik(string database)
        {
            kapcsolat = new SQLiteConnection("data source = "+database);
            kapcsolat.Open();
            parancs_a = kapcsolat.CreateCommand();
            parancs_b = kapcsolat.CreateCommand();
        }
        public static void lecsatlakoik()
        {
            kapcsolat.Close();
        }
        public static void set_adapter(string s) {
            parancs_a.CommandText = s;
            adapter = new SQLiteDataAdapter(parancs_a);
        }
    }
}
