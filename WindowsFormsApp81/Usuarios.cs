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
    public partial class Usuarios : principala
    {
        
        User DG = new User();
        User user = new User();
        public Usuarios(User h)
        {
            user = h;
            InitializeComponent();
        }

        private void Contactos_Load(object sender, EventArgs e)

        {
            try
            {
                string CMD = $"SELECT * FROM Usuario";

                DataSet DS = Utilidades.Ejecutar(CMD);

                int n = DS.Tables[0].Rows.Count;
                int i;              
                for (i = 0; i < n; i++)
                {
                    

                    DG.correo = DS.Tables[0].Rows[i]["correo_U"].ToString().Trim();
                    DG.contrasenaA = DS.Tables[0].Rows[i]["contraseña_A"].ToString().Trim();
                    DG.admin = DS.Tables[0].Rows[i]["admini"].ToString().Trim();
                    DG.apellido = DS.Tables[0].Rows[i]["apellido_U"].ToString().Trim();
                    DG.user_ID = DS.Tables[0].Rows[i]["ID_usuario"].ToString().Trim();
                    DG.nombre = DS.Tables[0].Rows[i]["nombre_U"].ToString().Trim();
                    DG.contrasenaC = DS.Tables[0].Rows[i]["contraseña_C"].ToString().Trim();
                    DG.fecha = DS.Tables[0].Rows[i]["fecha_N"].ToString().Trim();

                    i = TABLA_U.Rows.Add();
                    TABLA_U.Rows[i].Cells[0].Value = DG.user_ID;
                    TABLA_U.Rows[i].Cells[1].Value = DG.nombre;
                    TABLA_U.Rows[i].Cells[2].Value = DG.apellido;
                    TABLA_U.Rows[i].Cells[3].Value = DG.fecha;
                    TABLA_U.Rows[i].Cells[4].Value = DG.correo;
                    TABLA_U.Rows[i].Cells[5].Value = DG.contrasenaC;
                    TABLA_U.Rows[i].Cells[6].Value = DG.contrasenaA;
                    TABLA_U.Rows[i].Cells[7].Value = DG.admin;
                    TABLA_U.Rows[i].Cells[8].Value = "Eliminar";
                

                }


            }catch (Exception)
            { MessageBox.Show("error");}
            

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int n = e.RowIndex;
                string h = (string)TABLA_U.Rows[n].Cells[0].Value;
                MessageBox.Show("" + h);
                string cmd = $"delete from Contactos_D Where C_IDdepen = {h}  delete from usuario where ID_usuario = {h}";
                Utilidades.Ejecutar(cmd);
                TABLA_U.Rows.RemoveAt(n);
                


            }
            catch { MessageBox.Show("Error intente de nuevo "); }


        }

        private void Usuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
                {   string CMD = $"SELECT * FROM Usuario WHERE ID_usuario ='{txtB_ID.Text.Trim()}'";

                    DataSet DS = Utilidades.Ejecutar(CMD);

                    DG.contrasenaA = DS.Tables[0].Rows[0]["contraseña_A"].ToString().Trim();
                    DG.admin = DS.Tables[0].Rows[0]["admini"].ToString().Trim();
                    DG.apellido = DS.Tables[0].Rows[0]["apellido_U"].ToString().Trim();
                    DG.contrasenaC = DS.Tables[0].Rows[0]["contraseña_C"].ToString().Trim();
                    DG.nombre = DS.Tables[0].Rows[0]["nombre_U"].ToString().Trim();
                    DG.correo = DS.Tables[0].Rows[0]["correo_U"].ToString().Trim();


                    txt_contraseñaEA.Text = DG.contrasenaA;
                    txt_contraseñaCE.Text = DG.contrasenaC;
                    txt_correoE.Text = DG.correo;
                    txt_apellidoE.Text = DG.apellido;
                    Txt_nombreE.Text = DG.nombre;
                    txt_fechaE.Text = DG.fecha;




                }
                catch (Exception E ){ MessageBox.Show("ID INCORRECTO" + E);}
            }


        }


        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {


            if (txtB_ID.Text == "")
            {
                MessageBox.Show("INGRESE UN ID");
            }
            else
            {

                if (Txt_nombreE.Text == " " || txt_apellidoE.Text == " " || txt_correoE.Text == " " || txt_fechaE.Text == "1/1/2000" || txt_contraseñaEA.Text == "" || txt_contraseñaCE.Text == "") {
                    MessageBox.Show("COMPLETE TODOS LOS CAMPOS ");
                        }
                else
                {
                    try
                    {



                        string CMD = $"UPDATE dbo.Usuario SET nombre_U = '{Txt_nombreE.Text.Trim()}', apellido_U = '{txt_apellidoE.Text.Trim()}',correo_U='{txt_correoE.Text.Trim()}', contraseña_C ='{txt_contraseñaCE.Text.Trim()}',contraseña_A = '{txt_contraseñaEA.Text.Trim()}', fecha_N = '{txt_fechaE.Text.Trim()}' WHERE ID_usuario = '{txtB_ID.Text.Trim()}'";
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

        


        private void Button3_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(user);
            this.Hide();
            admin.Show();
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

        private void Txt_nombreE_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_nombreE_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaTEX(e);
            Txt_nombreE.CharacterCasing = CharacterCasing.Upper;
            Txt_nombreE.CharacterCasing = CharacterCasing.Upper;

        }

        private void Txt_apellidoE_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaTEX(e);
            txt_apellidoE.CharacterCasing = CharacterCasing.Upper;
            txt_apellidoE.CharacterCasing= CharacterCasing.Upper;

        }
    }
}

