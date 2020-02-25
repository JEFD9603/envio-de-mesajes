using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using MiLibreria;



namespace WindowsFormsApp81
{
    
    public partial class Form1 : principala
    {
        Utilidades E = new Utilidades();
        DataSet DS;
        User user = new User();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {   string CMD = $"SELECT * FROM Usuario WHERE correo_U ='{txtAccount.Text.Trim()}' AND contraseña_A = '{txtPassword.Text.Trim() }'";
                
                DS = Utilidades.Ejecutar(CMD);                
                user.correo = DS.Tables[0].Rows[0]["correo_U"].ToString().Trim();
                user.contrasenaA = DS.Tables[0].Rows[0]["contraseña_A"].ToString().Trim();
                user.admin = DS.Tables[0].Rows[0]["admini"].ToString().Trim();
                user.apellido = DS.Tables[0].Rows[0]["apellido_U"].ToString().Trim();
                user.user_ID = DS.Tables[0].Rows[0]["ID_usuario"].ToString().Trim();
                user.nombre = DS.Tables[0].Rows[0]["nombre_U"].ToString().Trim();
                user.contrasenaC = DS.Tables[0].Rows[0]["contraseña_C"].ToString().Trim();
                if (user.correo == txtAccount.Text.Trim() && user.contrasenaA == txtPassword.Text.Trim())
                { 

                        Admin admin1 = new Admin(user);
                        this.Hide();
                        admin1.Show();
                    
                }

            } catch ( Exception )
            {
                MessageBox.Show("USUARIO O CONTRASENA INCORRECTA");
                


            }

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtAccount_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string CMD = $"SELECT correo_U FROM Usuario";
                DS = Utilidades.Ejecutar(CMD);
                txtAccount.AutoCompleteCustomSource = cargar("correo_U",DS);
                txtAccount.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtAccount.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch { MessageBox.Show("hell"); }

        }

        





        
            private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void TxtAccount_Leave(object sender, EventArgs e)
        {
            
            if ( ValidaEmail(txtAccount.Text)) { }
            else
            {
                MessageBox.Show("EMAIL INVALIDO");
                txtAccount.SelectAll();
                txtAccount.Focus();
            }






      
        }

    }
}
