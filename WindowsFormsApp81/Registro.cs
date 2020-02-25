using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiLibreria;
namespace WindowsFormsApp81
{
    public partial class Registro : principala
    {
        User user = new User();
        public Registro(User user )
        {this.user= user;
             
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Registro_Load(object sender, EventArgs e)
        {
          
                if (txtApellido.Text == "" && comboBox1.Text == "operador " && txtNombre.Text == " " && datenacimiento.Text.Equals("1/01/2000 ") && rbadminSI.Checked == true || rbAdminNO.Checked == true || txtcontraseñaA.Text == ""|| txtContraseñaC.Text == "")
                {
                    if (txtCoreoE.Text.Contains(comboBox1.Text))
                    { button1.Visible = true; }

                }

                if (user.admin != "True")
                {
                     rbAdminNO.Visible = false;
                     rbadminSI.Visible = false;
                     lbadmin.Visible = false;


                }



        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registro ");

            try
            {
                string CMD = $"INSERT dbo.Usuario(nombre_U, apellido_U, correo_U, contraseña_C, contraseña_A, fecha_N, admini) VALUES('{txtNombre.Text.Trim()}', '{txtApellido.Text.Trim()}', '{txtCoreoE.Text.Trim()}', '{txtContraseñaC.Text.Trim()}', '{txtcontraseñaA.Text.Trim()}', '{datenacimiento.Text.Trim()}','{rbadminSI.Checked}')";
                DataSet DS = Utilidades.Ejecutar(CMD);
                MessageBox.Show("Registro completado");
                Admin admin = new Admin(user);
                this.Hide();
                admin.Show();

            }   
            catch (Exception)
            {
                MessageBox.Show("Error de registro");
            }
        }

        private void Registro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(user);
            this.Hide();
            admin.Show();

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            string correo = txtCoreoE.Text + comboBox1.Text;

            if (ValidaEmail(correo))
            {
              



                try
                {
                    string CMD = $"INSERT dbo.Usuario(nombre_U, apellido_U, correo_U, contraseña_C, contraseña_A, fecha_N, admini) VALUES('{txtNombre.Text.Trim()}', '{txtApellido.Text.Trim()}', '{txtCoreoE.Text.Trim()}', '{txtContraseñaC.Text.Trim()}', '{txtcontraseñaA.Text.Trim()}', '{datenacimiento.Text.Trim()}','{rbadminSI.Checked}')";
                    DataSet DS = Utilidades.Ejecutar(CMD);
                    MessageBox.Show("Registro completado");
                    Admin admin = new Admin(user);
                    this.Hide();
                    admin.Show();

                }
                catch (Exception)
                {
                    MessageBox.Show("Error de registro");
                }
            
            }else
             {  MessageBox.Show("EMAIL INVALIDO");
                txtCoreoE.SelectAll();}
}

        private void RbAdminNO_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RbadminSI_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Lbadmin_Click(object sender, EventArgs e)
        {

        }

        private void Datenacimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TxtcontraseñaA_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtContraseñaC_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCoreoE_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {

            ValidaTEX(e);
            txtNombre.CharacterCasing = CharacterCasing.Upper;
            txtNombre.CharacterCasing = CharacterCasing.Lower;
        }

        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {

            ValidaTEX(e);
            txtApellido.CharacterCasing = CharacterCasing.Upper;
            txtApellido.CharacterCasing = CharacterCasing.Lower;
        }
    }
}
