using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MiLibreria;


namespace WindowsFormsApp81
{
    public partial class principala : Form
    {
        public principala()
        {
            InitializeComponent();

            
        }

        public void Principala_Load(object sender, EventArgs e)
        {





        }

        public static bool ValidaEmail(string Email)
        {

            String expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)\\w+([-.]\\w+)*";
            if (Regex.IsMatch(Email, expresion))
            {
                if (Regex.Replace(Email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else { return false; }
            }
            else { return false; }
        }
        public static bool ValidaEmail(string Email, string proveedor)
        {

            String expresion = " \\w+([-+.']\\w+)*@\\w+([-.]\\w+)\\w+([-.]\\w+)*  ";
            if (Regex.IsMatch(Email, expresion))
            {
                if (Regex.Replace(Email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else { return false; }
            }
            else { return false; }
        }

        public static  AutoCompleteStringCollection cargar(string h, DataSet DS)
        {
            AutoCompleteStringCollection datos = new AutoCompleteStringCollection();

            int n = DS.Tables[0].Rows.Count;
            int i;
            for (i = 0; i < n; i++)
            {
                datos.Add(DS.Tables[0].Rows[i][$"{h}"].ToString().Trim());
            }

            return datos;
        }

        public static void ValidaTEX( KeyPressEventArgs E)

        { if (char.IsLetter(E.KeyChar))
            {
                E.Handled = false;
            }
            else if (char.IsControl(E.KeyChar))
            {
                E.Handled = false;

            }
            else if (char.IsSeparator(E.KeyChar))
            {
                E.Handled = false;
            }
            else
            {
                E.Handled = true;
                MessageBox.Show("EL NOMBRE O APELLIDO NO DEBE CONTENER NUMEROS");
         }  }




        
    }

   
}


