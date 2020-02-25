using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;



namespace MiLibreria
{
    public class Utilidades 
    {
        public static DataSet Ejecutar(string cmd)
        {

            SqlConnection coneccion = new SqlConnection("Data Source=.;Initial Catalog=Administracion1;Integrated Security=True");
            coneccion.Open();

            DataSet DS = new DataSet();
            SqlDataAdapter DP = new SqlDataAdapter(cmd, coneccion);

            DP.Fill(DS);
            coneccion.Close();

            return DS;

        }
           
    }
    }









