using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement
{
    public class DB{

        static string server;
        static string userid;
        static string pass;
        static string database;

        static DB()
        {
            server = "localhost";
            userid = "root";
            pass = "1234";
            database = "hotel";
        }

        public string getConnString()
        {
            
            return (@"server=" + server + ";userid=" + userid + ";password=" + pass 
                +";database="+ database);
        }
    }
    
}
