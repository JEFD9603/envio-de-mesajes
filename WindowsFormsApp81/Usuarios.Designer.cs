namespace WindowsFormsApp81
{
    partial class Usuarios:principala
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TABLA_U = new System.Windows.Forms.DataGridView();
            this.dg_ID_admin_U = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_Nombre_U = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgApellido_U = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgNacimiento_U = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_correo_U = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_contraseña_C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_contraseña_U = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aminstrador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtB_ID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_nombreE = new System.Windows.Forms.TextBox();
            this.txt_correoE = new System.Windows.Forms.TextBox();
            this.txt_contraseñaCE = new System.Windows.Forms.TextBox();
            this.txt_apellidoE = new System.Windows.Forms.TextBox();
            this.txt_contraseñaEA = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txt_fechaE = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.TABLA_U)).BeginInit();
            this.SuspendLayout();
            // 
            // TABLA_U
            // 
            this.TABLA_U.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TABLA_U.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TABLA_U.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dg_ID_admin_U,
            this.DG_Nombre_U,
            this.dgApellido_U,
            this.dgNacimiento_U,
            this.dg_correo_U,
            this.dg_contraseña_C,
            this.dg_contraseña_U,
            this.Aminstrador,
            this.dg_Eliminar});
            this.TABLA_U.Location = new System.Drawing.Point(127, 369);
            this.TABLA_U.Name = "TABLA_U";
            this.TABLA_U.RowHeadersWidth = 51;
            this.TABLA_U.RowTemplate.Height = 24;
            this.TABLA_U.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TABLA_U.Size = new System.Drawing.Size(1009, 344);
            this.TABLA_U.TabIndex = 0;
            this.TABLA_U.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // dg_ID_admin_U
            // 
            this.dg_ID_admin_U.HeaderText = "ID";
            this.dg_ID_admin_U.MinimumWidth = 6;
            this.dg_ID_admin_U.Name = "dg_ID_admin_U";
            this.dg_ID_admin_U.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_ID_admin_U.Width = 50;
            // 
            // DG_Nombre_U
            // 
            this.DG_Nombre_U.HeaderText = "Nombre";
            this.DG_Nombre_U.MinimumWidth = 6;
            this.DG_Nombre_U.Name = "DG_Nombre_U";
            this.DG_Nombre_U.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_Nombre_U.Width = 87;
            // 
            // dgApellido_U
            // 
            this.dgApellido_U.HeaderText = "Apellido";
            this.dgApellido_U.MinimumWidth = 6;
            this.dgApellido_U.Name = "dgApellido_U";
            this.dgApellido_U.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgApellido_U.Width = 87;
            // 
            // dgNacimiento_U
            // 
            this.dgNacimiento_U.HeaderText = "Fecha de nacimiento";
            this.dgNacimiento_U.MinimumWidth = 6;
            this.dgNacimiento_U.Name = "dgNacimiento_U";
            this.dgNacimiento_U.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgNacimiento_U.Width = 154;
            // 
            // dg_correo_U
            // 
            this.dg_correo_U.HeaderText = "Correo Electronico";
            this.dg_correo_U.MinimumWidth = 6;
            this.dg_correo_U.Name = "dg_correo_U";
            this.dg_correo_U.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_correo_U.Width = 141;
            // 
            // dg_contraseña_C
            // 
            this.dg_contraseña_C.HeaderText = "Contraseña del correo";
            this.dg_contraseña_C.MinimumWidth = 6;
            this.dg_contraseña_C.Name = "dg_contraseña_C";
            this.dg_contraseña_C.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_contraseña_C.Width = 126;
            // 
            // dg_contraseña_U
            // 
            this.dg_contraseña_U.HeaderText = "contraseña de Aplicasion";
            this.dg_contraseña_U.MinimumWidth = 6;
            this.dg_contraseña_U.Name = "dg_contraseña_U";
            this.dg_contraseña_U.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_contraseña_U.Width = 121;
            // 
            // Aminstrador
            // 
            this.Aminstrador.HeaderText = "Administrador";
            this.Aminstrador.MinimumWidth = 6;
            this.Aminstrador.Name = "Aminstrador";
            this.Aminstrador.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Aminstrador.Width = 124;
            // 
            // dg_Eliminar
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            this.dg_Eliminar.DefaultCellStyle = dataGridViewCellStyle2;
            this.dg_Eliminar.HeaderText = "eliminar";
            this.dg_Eliminar.MinimumWidth = 6;
            this.dg_Eliminar.Name = "dg_Eliminar";
            this.dg_Eliminar.Width = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese el ID del usuario";
            // 
            // txtB_ID
            // 
            this.txtB_ID.Location = new System.Drawing.Point(273, 40);
            this.txtB_ID.Name = "txtB_ID";
            this.txtB_ID.Size = new System.Drawing.Size(155, 22);
            this.txtB_ID.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(464, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1007, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contraseña correo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1007, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contraseña aplicacion";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(507, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Correo electronico";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(507, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(263, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fecha de nacimiento ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 29);
            this.label7.TabIndex = 9;
            this.label7.Text = "Apellido";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 29);
            this.label8.TabIndex = 10;
            this.label8.Text = "Nombre";
            // 
            // Txt_nombreE
            // 
            this.Txt_nombreE.Location = new System.Drawing.Point(17, 174);
            this.Txt_nombreE.Name = "Txt_nombreE";
            this.Txt_nombreE.Size = new System.Drawing.Size(155, 22);
            this.Txt_nombreE.TabIndex = 11;
            this.Txt_nombreE.TextChanged += new System.EventHandler(this.Txt_nombreE_TextChanged);
            this.Txt_nombreE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_nombreE_KeyPress);
            // 
            // txt_correoE
            // 
            this.txt_correoE.Location = new System.Drawing.Point(512, 174);
            this.txt_correoE.Name = "txt_correoE";
            this.txt_correoE.Size = new System.Drawing.Size(155, 22);
            this.txt_correoE.TabIndex = 12;
            this.txt_correoE.TextChanged += new System.EventHandler(this.Txt_correoE_TextChanged);
            this.txt_correoE.Leave += new System.EventHandler(this.Txt_correoE_Leave);
            // 
            // txt_contraseñaCE
            // 
            this.txt_contraseñaCE.Location = new System.Drawing.Point(1012, 174);
            this.txt_contraseñaCE.Name = "txt_contraseñaCE";
            this.txt_contraseñaCE.Size = new System.Drawing.Size(155, 22);
            this.txt_contraseñaCE.TabIndex = 13;
            // 
            // txt_apellidoE
            // 
            this.txt_apellidoE.Location = new System.Drawing.Point(17, 297);
            this.txt_apellidoE.Name = "txt_apellidoE";
            this.txt_apellidoE.Size = new System.Drawing.Size(155, 22);
            this.txt_apellidoE.TabIndex = 14;
            this.txt_apellidoE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_apellidoE_KeyPress);
            // 
            // txt_contraseñaEA
            // 
            this.txt_contraseñaEA.Location = new System.Drawing.Point(1012, 297);
            this.txt_contraseñaEA.Multiline = true;
            this.txt_contraseñaEA.Name = "txt_contraseñaEA";
            this.txt_contraseñaEA.Size = new System.Drawing.Size(155, 22);
            this.txt_contraseñaEA.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(604, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 34);
            this.button2.TabIndex = 17;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(779, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 34);
            this.button3.TabIndex = 18;
            this.button3.Text = "Volver";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // txt_fechaE
            // 
            this.txt_fechaE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_fechaE.Location = new System.Drawing.Point(512, 307);
            this.txt_fechaE.Name = "txt_fechaE";
            this.txt_fechaE.Size = new System.Drawing.Size(155, 22);
            this.txt_fechaE.TabIndex = 20;
            this.txt_fechaE.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 714);
            this.Controls.Add(this.txt_fechaE);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_contraseñaEA);
            this.Controls.Add(this.txt_apellidoE);
            this.Controls.Add(this.txt_contraseñaCE);
            this.Controls.Add(this.txt_correoE);
            this.Controls.Add(this.Txt_nombreE);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtB_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TABLA_U);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Usuarios_FormClosed);
            this.Load += new System.EventHandler(this.Contactos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TABLA_U)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TABLA_U;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtB_ID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_nombreE;
        private System.Windows.Forms.TextBox txt_correoE;
        private System.Windows.Forms.TextBox txt_contraseñaCE;
        private System.Windows.Forms.TextBox txt_apellidoE;
        private System.Windows.Forms.TextBox txt_contraseñaEA;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_ID_admin_U;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_Nombre_U;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgApellido_U;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgNacimiento_U;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_correo_U;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_contraseña_C;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_contraseña_U;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aminstrador;
        private System.Windows.Forms.DataGridViewButtonColumn dg_Eliminar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker txt_fechaE;
    }
}