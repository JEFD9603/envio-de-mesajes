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
    public partial class Agregar_C : principala
    {
        User user = new User();
        User user2 = new User();
        public Agregar_C(User m)
        {
            user = m;
            InitializeComponent();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string correo = txtCore.Text + comboBox1.Text;

            if (ValidaEmail(correo))
            {           
                string h;
                if (rbmasculino.Checked == true)
                {
                    h = "MASCULINO";
                }
                else { h = "FEMENINO"; }

                try
                {
                    string CMD = $"INSERT dbo.Contactos_D(C_nombre, C_apellido, C_correo, C_fecha, C_sexo, C_IDdepen) VALUES('{txtNom.Text.Trim()}', '{txtApel.Text.Trim()}', '{txtCore.Text.Trim()}','{datenaci.Text.Trim()}','{h}','{user.user_ID}')";
                    DataSet DS = Utilidades.Ejecutar(CMD);
                    MessageBox.Show("Registro completado");
                    Admin admin = new Admin(user);
                    this.Hide();
                    admin.Show();

                }
                catch (Exception){MessageBox.Show("Error de registro");}
            }else
             {  MessageBox.Show("EMAIL INVALIDO");
                txtCore.SelectAll();}
        }

        private void Button2_Click(object sender, EventArgs e)
        {   Admin admin = new Admin(user);
            this.Hide();
            admin.Show();}

        private void Agregar_C_Load(object sender, EventArgs e)
        { if (txtApel.Text == "" && comboBox1.Text == " " && txtNom.Text == " " && datenaci.Text.Equals("1/01/2000 ") && rbmasculino.Checked == true || rbAdminNO.Checked == true)
            {
                if (txtCore.Text.Contains(comboBox1.Text))
                {btnagrega_c.Visible = true;}
                else{ MessageBox.Show("SU CORREO NO COINCIDE CON EL OPERADOR");}
            }        
        }
        private void TxtCore_Leave(object sender, EventArgs e)
        {
        }

        private void TxtCore_TextChanged(object sender, EventArgs e)
        {
        }

        private void TxtNom_Leave(object sender, EventArgs e)
        {
        }

        private void Agregar_C_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TxtNom_KeyPress(object sender, KeyPressEventArgs e)
        {

            ValidaTEX(e);
            txtNom.CharacterCasing = CharacterCasing.Upper;
            txtNom.CharacterCasing = CharacterCasing.Lower;

        }

        private void TxtApel_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaTEX(e);
            txtApel.CharacterCasing = CharacterCasing.Upper;
            txtApel.CharacterCasing = CharacterCasing.Lower;

        }
    }
}
