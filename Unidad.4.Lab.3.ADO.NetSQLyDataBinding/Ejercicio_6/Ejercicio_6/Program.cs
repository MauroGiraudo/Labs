using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Ejercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataTable dtEmpresas = new DataTable();
            dtEmpresas.Columns.Add("CustomerID", typeof(string));
            dtEmpresas.Columns.Add("CompanyName", typeof(string));
            SqlConnection myconn = new SqlConnection();
            myconn.ConnectionString = "Data Source=LOCALHOST;Initial Catalog=Northwind; User ID=sa;Pwd=123";
            SqlDataAdapter myAdap = new SqlDataAdapter("SELECT CustomerID, CompanyName FROM Customers", myconn);

            myconn.Open();
            myAdap.Fill(dtEmpresas);
            myconn.Close();

            Console.WriteLine("Escribe el CustomerID que desee modificar: ");
            string custId = Console.ReadLine();
            DataRow[] rowEmpresas = dtEmpresas.Select("CustomerID = '" + custId + "'");
            if(rowEmpresas.Length != 1)
            {
                Console.WriteLine("CustomerID no encontrado");
                Console.ReadLine();
                return;
            }

            DataRow rowMiEmpresa = rowEmpresas[0];
            string nombreActual = rowMiEmpresa["CompanyName"].ToString();
            Console.WriteLine("Nombre actual de la empresa: " + nombreActual);
            Console.WriteLine("Escriba el nuevo nombre: ");
            string nombreNuevo = Console.ReadLine();
            rowMiEmpresa.BeginEdit();
            rowMiEmpresa["CompanyName"] = nombreNuevo;
            rowMiEmpresa.EndEdit();

            SqlCommand upCommand = new SqlCommand();
            upCommand.Connection = myconn;
            upCommand.CommandText = "UPDATE Customers SET CompanyName = @CompanyName WHERE CustomerID = @CustomerID";
            upCommand.Parameters.Add("@CompanyName", SqlDbType.NVarChar, 50, "CompanyName");
            upCommand.Parameters.Add("@CustomerID", SqlDbType.NVarChar, 5, "CustomerID");
            myAdap.UpdateCommand = upCommand;
            myAdap.Update(dtEmpresas);
        }
    }
}