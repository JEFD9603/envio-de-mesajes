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



namespace WindowsFormsApp81
{
    public partial class Admin :principala
    {   User m = new User ();
        public Admin(User user)
        { 
            m = user;
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            lbcorreo.Text = m.correo;
            lbnombre.Text = m.nombre+" "+m.apellido;;
            
            
            

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro(m);
            this.Hide();
            registro.Show();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Btnuser_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios(m);
            usuarios.Show();
            this.Hide();
                
                
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            contactos contactos = new contactos(m);
            this.Hide();
            contactos.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Agregar_C agregar = new Agregar_C(m);
            this.Hide();
            agregar.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            mensages mensages = new mensages(m);
            mensages.Show();
            this.Hide();

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            reporte reporte = new reporte(m);
            reporte.Show();
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }
    }
}
