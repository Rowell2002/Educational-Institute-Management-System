using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalproject
{
    internal class dbConnection
    {
        public string MyConnection()
        {
            string con = "Data Source=DESKTOP-MILEE7;Initial Catalog=education;Integrated Security=True";
            return con;
        }
    }
}
