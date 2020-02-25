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
    public partial class contactos : principala
    {
        User user = new User();
        User DG = new User();
        string sex;
        public contactos(User user1)
        {
            user = user1;
            Usuarios Usuarios = new Usuarios(user);
            InitializeComponent();
        }

        private void Contactos_Load(object sender, EventArgs e)
        {
            string CMD;



            try
                
             {if (user.admin  == "True")
                {
                    
                     CMD = $"SELECT * FROM Contactos_D";
                }else {
                     CMD = $" SELECT * FROM Contactos_D where C_IDdepen = {user.user_ID}";
                    panel1.Visible = false;
                }

                DataSet DS = Utilidades.Ejecutar(CMD);

                int n = DS.Tables[0].Rows.Count;
                int i;
                for (i = 0; i < n; i++)
                {


                    DG.correo = DS.Tables[0].Rows[i]["C_correo"].ToString().Trim();
                    
                    DG.admin = DS.Tables[0].Rows[i]["C_IDdepen"].ToString().Trim();
                    DG.apellido = DS.Tables[0].Rows[i]["C_apellido"].ToString().Trim();
                    DG.user_ID = DS.Tables[0].Rows[i]["C_ID"].ToString().Trim();
                    DG.nombre = DS.Tables[0].Rows[i]["C_nombre"].ToString().Trim();
                    DG.fecha = DS.Tables[0].Rows[i]["C_fecha"].ToString().Trim();

                    i = TABLA_.Rows.Add();
                    TABLA_.Rows[i].Cells[0].Value = DG.user_ID;
                    TABLA_.Rows[i].Cells[1].Value = DG.nombre;
                    TABLA_.Rows[i].Cells[2].Value = DG.apellido;
                    TABLA_.Rows[i].Cells[3].Value = DG.fecha;
                    TABLA_.Rows[i].Cells[4].Value = DG.correo;
                    TABLA_.Rows[i].Cells[5].Value = DG.admin;
                    TABLA_.Rows[i].Cells[6].Value = "Eliminar";


                }


            }
            catch (Exception)
            { MessageBox.Show("Verifique los datos ingresados"); }


        }





        private void Button1_Click(object sender, EventArgs e)
        {

            if (txtB_ID.Text == "")
            {
                MessageBox.Show("INGRESE UN ID");
            }
            else
            {
                try
                {


                    string CMD = $"SELECT * FROM Contactos_D WHERE C_ID ='{txtB_ID.Text.Trim()}'";

                    DataSet DS = Utilidades.Ejecutar(CMD);

                    DG.contrasenaA = DS.Tables[0].Rows[0]["C_ID"].ToString().Trim();
                    DG.admin = DS.Tables[0].Rows[0]["C_IDdepen"].ToString().Trim();
                    DG.apellido = DS.Tables[0].Rows[0]["C_apellido"].ToString().Trim();
                    sex = DS.Tables[0].Rows[0]["C_sexo"].ToString().Trim();
                    DG.nombre = DS.Tables[0].Rows[0]["C_nombre"].ToString().Trim();
                    DG.correo = DS.Tables[0].Rows[0]["C_correo"].ToString().Trim();
                    DG.fecha = DS.Tables[0].Rows[0]["C_Fecha"].ToString().Trim();



                    txtIDdepen.Text = DG.admin;
                    txt_correoE.Text = DG.correo;
                    txt_apellidoE.Text = DG.apellido;
                    Txt_nombreE.Text = DG.nombre;
                    txt_fechaE.Text = DG.fecha;
                    comboBox1.Text = sex;




                }
                catch (Exception)
                {
                    MessageBox.Show("ID INCORRECTO");
                }
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {


            if (txtB_ID.Text == "")
            {
                MessageBox.Show("INGRESE UN ID");
            }
            else
            {


                if (Txt_nombreE.Text == " " || txt_apellidoE.Text == " " || txt_correoE.Text == " " || txt_fechaE.Text == "1/1/2000" || txtIDdepen.Text == "" || comboBox1.Text == "") { MessageBox.Show("COMPLETE TODOS LOS CAMPOS "); }
                else
                {
                    try
                    {

                        string CMD = $"UPDATE dbo.Contactos_D SET C_nombre = '{Txt_nombreE.Text.Trim()}', C_apellido = '{txt_apellidoE.Text.Trim()}',C_correo ='{txt_correoE.Text.Trim()}', C_fecha = '{txt_fechaE.Text.Trim()}',C_sexo ='{comboBox1.Text}' , C_IDdepen = '{txtIDdepen.Text}' WHERE C_ID = '{txtB_ID.Text.Trim()}'";
                        DataSet DS = Utilidades.Ejecutar(CMD);
                        MessageBox.Show("Registro completado");
                        Admin admin = new Admin(user);
                        this.Hide();
                        admin.Show();

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error ");
                    }
                }
            }
        }

        private void TABLA__CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int n = e.RowIndex;
                string h = (string)TABLA_.Rows[n].Cells[0].Value;
                string cmd = $"delete from Contactos_D Where C_ID = {h} ";
                Utilidades.Ejecutar(cmd);
                TABLA_.Rows.RemoveAt(n);



            }
            catch { MessageBox.Show("Error intente de nuevo "); }


        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(user);
            this.Hide();
            admin.Show();
        }

        private void Contactos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Txt_fechaE_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_nombreE_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaTEX(e);
            Txt_nombreE.CharacterCasing = CharacterCasing.Upper;
            txt_apellidoE.CharacterCasing = CharacterCasing.Upper;

        }

        private void Txt_apellidoE_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaTEX(e);
            txt_apellidoE.CharacterCasing = CharacterCasing.Upper;
            txt_apellidoE.CharacterCasing = CharacterCasing.Upper;

        }

        private void Txt_correoE_TextChanged(object sender, EventArgs e)
        {

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
    }
}
