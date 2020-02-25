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
    public partial class mensages : principala
    {
        User user = new User();
        DataSet DS;
        string CMD;
        public mensages(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void Mensages_Load(object sender, EventArgs e)
        {

            label4.Text = user.correo;
            
            try
            {
                if (user.admin == "True")
                {

                    CMD = $"SELECT * FROM Contactos_D";
                }
                else
                {
                    CMD = $" SELECT * FROM Contactos_D where C_IDdepen = {user.user_ID}";

                }



                DS = Utilidades.Ejecutar(CMD);
                txt_correoE.AutoCompleteCustomSource = cargar("C_correo", DS);
                txt_correoE.AutoCompleteMode = AutoCompleteMode.Suggest;
                txt_correoE.AutoCompleteSource = AutoCompleteSource.CustomSource;

                textBox1.AutoCompleteCustomSource = cargar("C_correo", DS);
                textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
                textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;


                textBox2.AutoCompleteCustomSource = cargar("C_correo", DS);
                textBox2.AutoCompleteMode = AutoCompleteMode.Suggest;
                textBox2.AutoCompleteSource = AutoCompleteSource.CustomSource;

          }
            catch { MessageBox.Show("hell"); }

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();


            mmsg.To.Add(txt_correoE.Text);
            mmsg.Subject = Txt_nombreE.Text;
            mmsg.SubjectEncoding = System.Text.Encoding.UTF8;
            mmsg.Bcc.Add(textBox1.Text);

            mmsg.Body = textBox3.Text;
            mmsg.BodyEncoding = System.Text.Encoding.UTF8;
            mmsg.IsBodyHtml = true;

            mmsg.From = new System.Net.Mail.MailAddress($"{user.correo}");



            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();


            cliente.Credentials = new System.Net.NetworkCredential($"{user.correo}", $"{user.contrasenaC}");

            
                MessageBox.Show("es el if");
                cliente.Port = 587;
                cliente.EnableSsl = true;

                cliente.Host = "smtp.gmail.com"; //"smtp.dominio.com"


                try
                { cliente.Send(mmsg);

                MessageBox.Show("MENSAGE ENVIADO CORRECTAMENTE ");

                this.Hide();
                        Admin admin = new Admin(user);
                        admin.Show();
                    }

                    catch (Exception E) {MessageBox.Show("Error al enviar " + E); MessageBox.Show("MENSAGE ENVIADO CORRECTAMENTE "+E);

                    this.Hide();
                    Admin admin = new Admin(user);
                    admin.Show();
                  }

            try
            {
                string CMD = $"INSERT dbo.mensa(ID_user,Correo_p,Cuerpo_m,fecha,nombre_E,Correo_E,Asunto,) VALUES('{user.user_ID}', '{txt_correoE.Text.Trim()}', '{textBox3.Text.Trim()}','{dateTimePicker1.Value.ToString()}','{user.nombre}','{user.correo}','{Txt_nombreE.Text}')";
                DataSet DS = Utilidades.Ejecutar(CMD);
                MessageBox.Show("Registro completado");
                Admin admin = new Admin(user);
                this.Hide();
                admin.Show();

            }
            catch (Exception) { MessageBox.Show("Error de registro"); }









        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            if (ValidaEmail(textBox1.Text)) { }
            else
            {
                MessageBox.Show("EMAIL INVALIDO");
                textBox1.SelectAll();
                textBox1.Focus();
            }
        }

        private void Txt_correoE_Leave(object sender, EventArgs e)
        {

            if (ValidaEmail(txt_correoE.Text)) { }
            else
            {
                MessageBox.Show("EMAIL INVALIDO");
                txt_correoE.SelectAll();
                txt_correoE.Focus();
            }
        }

        private void TextBox2_Leave(object sender, EventArgs e)
        {
            if (ValidaEmail(textBox2.Text)) { }
            else
            {
                MessageBox.Show("EMAIL INVALIDO");
                textBox2.SelectAll();
                textBox2.Focus();
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(user);
            admin.Show();
            this.Hide();

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Mensages_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
