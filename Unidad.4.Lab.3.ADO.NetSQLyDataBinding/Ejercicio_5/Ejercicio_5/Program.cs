using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataTable dtEmpresas = new DataTable();
            dtEmpresas.Columns.Add("CustomerID", typeof(string));
            dtEmpresas.Columns.Add("CompanyName", typeof(string));
            SqlConnection myconn = new SqlConnection();
            myconn.ConnectionString = "Data Source=MAUROG;Initial Catalog=Academia;Integrated Security=true;Trusted_Connection=true";
            SqlDataAdapter myAdap = new SqlDataAdapter("SELECT CustomerID, CompanyName FROM Customers", myconn);

            myconn.Open();
            myAdap.Fill(dtEmpresas);
            myconn.Close();


        }
    }
}
