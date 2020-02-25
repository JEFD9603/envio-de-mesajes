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
    public partial class reporte : principala
    {   string h;
        User user =  new User();
        User DG = new User();
        public reporte( User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            nombre.Text = user.nombre;
            correo.Text = user.correo;
           

            if (user.admin == "True")
            {
                panel3.Visible = true;
                try
                {
                    string CMD = $"SELECT * FROM Usuario";
                    DataSet ID = Utilidades.Ejecutar(CMD);


                    int n = ID.Tables[0].Rows.Count;
                    int i;
                    for (i = 0; i <= n; i++)
                    {
                        string mf = ID.Tables[i].Rows[0]["ID_usuario"].ToString().Trim();
                        comboBox1.Items.Add(mf);
                        
                    }
                }  catch { MessageBox.Show("hell"); }





                h = comboBox1.Text;




            }
            else
            {
                h = user.user_ID; 
            }



            try
            {


                string CMD = $"SELECT * FROM mensa WHERE ID_user ='{h}'";

                DataSet DS = Utilidades.Ejecutar(CMD);

                DG.user_ID = DS.Tables[0].Rows[0]["ID_user"].ToString().Trim();
                DG.correo = DS.Tables[0].Rows[0]["Correo_P"].ToString().Trim();
                DG.contrasenaA = DS.Tables[0].Rows[0]["cuerpo_m"].ToString().Trim();
                DG.fecha = DS.Tables[0].Rows[0]["fecha"].ToString().Trim();





                int n = DS.Tables[0].Rows.Count;
                int i;
                for (i = 1; i < n; i++)
                {





                    DG.user_ID = DS.Tables[i].Rows[0]["ID_user"].ToString().Trim();
                    DG.correo = DS.Tables[i].Rows[0]["Correo_P"].ToString().Trim();
                    DG.contrasenaA = DS.Tables[i].Rows[0]["cuerpo_m"].ToString().Trim();
                    DG.fecha = DS.Tables[i].Rows[0]["fecha"].ToString().Trim();



                    TABLAU.Rows[i].Cells[0].Value = DG.user_ID;
                    TABLAU.Rows[i].Cells[1].Value = DG.fecha;
                    TABLAU.Rows[i].Cells[2].Value = DG.correo;
                    TABLAU.Rows[i].Cells[3].Value = DG.contrasenaA;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ID INCORRECTO");
            }



        }

        private void TABLA__CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Correo_Click(object sender, EventArgs e)
        {

        }

        private void Reporte_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ComboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
