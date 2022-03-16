using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Create_Tabel
{
    class Program
    {
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=LAPTOP-GK6AO77T;database=ProdiTI; Integrated Security = True");
                con.Open();


            }
        }
        static void Main(string[] args)
        {
        }
    }
}
