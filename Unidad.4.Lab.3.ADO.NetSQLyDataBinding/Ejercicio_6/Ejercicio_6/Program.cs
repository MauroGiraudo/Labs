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
            DataRow dr1 = dtEmpresas.NewRow();
            dr1["CustomerID"] = "1";
            dr1["CompanyName"] = "Coto";
            dtEmpresas.Rows.Add(dr1);
            DataRow dr2 = dtEmpresas.NewRow();
            dr2["CustomerID"] = "2";
            dr2["CompanyName"] = "Molinos";
            dtEmpresas.Rows.Add(dr2);
            SqlConnection myconn = new SqlConnection();
            myconn.ConnectionString = "Data Source=MAUROG;Initial Catalog=Academia;Integrated Security=true;Trusted_Connection=true";
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
            upCommand.Parameters.Add("@CompanyName", SqlDbType.VarChar, 50, "CompanyName");
            upCommand.Parameters.Add("@CustomerID", SqlDbType.VarChar, 50, "CustomerID");
            myAdap.UpdateCommand = upCommand;
            myAdap.Update(dtEmpresas);
        }
    }
}