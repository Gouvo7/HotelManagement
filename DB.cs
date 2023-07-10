﻿using System;
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
        static string charset;

        static DB()
        {
            server = "localhost";
            dbuser = "root";
            pass = "1234";
            database = "hotel";
            //charset = "utf8mb4_unicode_ci";
            charset = "utf8mb4";
        }

        public string getConnString()
        {
            
            return (@"server=" + server + ";userid=" + dbuser + ";password=" + pass 
                +";database="+ database + ";charset=" + charset);
        }
    }
    
}
