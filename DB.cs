using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement
{
    public class DB{

        static string server;
        static string dbuser;
        static string pass;
        static string database;

        static DB()
        {
            server = "localhost";
            dbuser = "root";
            pass = "1234";
            database = "hotel";
        }

        public string getConnString()
        {
            
            return (@"server=" + server + ";userid=" + dbuser + ";password=" + pass 
                +";database="+ database);
        }
    }
    
}
