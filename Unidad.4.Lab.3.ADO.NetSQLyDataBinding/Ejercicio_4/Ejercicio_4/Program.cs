using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataTable dtEmpresas = new DataTable();
            DataColumn colCustomerId = new DataColumn("CustomerID", typeof(string));
            DataColumn colCompanyName = new DataColumn("CompanyName", typeof(string));
            dtEmpresas.Columns.Add(colCustomerId);
            dtEmpresas.Columns.Add(colCompanyName);

            SqlConnection myconn = new SqlConnection();
            myconn.ConnectionString = "Data Source=LOCALHOST;Initial Catalog=Northwind; User ID=sa;Pwd=123";

            SqlCommand myCommand = new SqlCommand();
            myCommand.CommandText = "SELECT CustomerID, CompanyName FROM Customers";
            myCommand.Connection = myconn;

            SqlDataAdapter myAdapt = new SqlDataAdapter("SELECT CustomerID, CompanyName FROM Customers", myconn);

            myconn.Open();
            SqlDataReader myDr = myCommand.ExecuteReader();
            dtEmpresas.Load(myDr);
            myconn.Close();

            Console.WriteLine("Listado de Empresas: ");
            foreach(DataRow rowEmp in dtEmpresas.Rows)
            {
                string idEmp = rowEmp["CustomerID"].ToString();
                string nomEmp = rowEmp["CompanyName"].ToString();
                Console.WriteLine(idEmp + " - " + nomEmp);
            }
            Console.Read();
        }
    }
}
