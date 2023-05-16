using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement
{
    public class DB{

        static string server = "localhost";
        static string userid = "root";
        static string pass = "1234";
        static string database = "hotel";

        public string getConnString()
        {
            string connString = @"server=" + server + ";userid=" + userid + ";password=" + pass 
                +";database="+ database;
            return (connString);
        }
    }
    
}
