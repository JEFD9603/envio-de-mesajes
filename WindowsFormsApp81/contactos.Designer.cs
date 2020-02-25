namespace WindowsFormsApp81
{
    partial class contactos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button2 = new System.Windows.Forms.Button();
            this.txtIDdepen = new System.Windows.Forms.TextBox();
            this.txt_apellidoE = new System.Windows.Forms.TextBox();
            this.txt_correoE = new System.Windows.Forms.TextBox();
            this.Txt_nombreE = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtB_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TABLA_ = new System.Windows.Forms.DataGridView();
            this.dg_ID_admin_U = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_Nombre_U = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgApellido_U = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgNacimiento_U = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_correo_U = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.txt_fechaE = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.TABLA_)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(163, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 34);
            this.button2.TabIndex = 34;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // txtIDdepen
            // 
            this.txtIDdepen.Location = new System.Drawing.Point(8, 80);
            this.txtIDdepen.Name = "txtIDdepen";
            this.txtIDdepen.Size = new System.Drawing.Size(155, 22);
            this.txtIDdepen.TabIndex = 33;
            // 
            // txt_apellidoE
            // 
            this.txt_apellidoE.Location = new System.Drawing.Point(7, 395);
            this.txt_apellidoE.Name = "txt_apellidoE";
            this.txt_apellidoE.Size = new System.Drawing.Size(155, 22);
            this.txt_apellidoE.TabIndex = 31;
            this.txt_apellidoE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_apellidoE_KeyPress);
            // 
            // txt_correoE
            // 
            this.txt_correoE.Location = new System.Drawing.Point(242, 289);
            this.txt_correoE.Name = "txt_correoE";
            this.txt_correoE.Size = new System.Drawing.Size(155, 22);
            this.txt_correoE.TabIndex = 29;
            this.txt_correoE.TextChanged += new System.EventHandler(this.Txt_correoE_TextChanged);
            this.txt_correoE.Leave += new System.EventHandler(this.Txt_correoE_Leave);
            // 
            // Txt_nombreE
            // 
            this.Txt_nombreE.Location = new System.Drawing.Point(4, 289);
            this.Txt_nombreE.Name = "Txt_nombreE";
            this.Txt_nombreE.Size = new System.Drawing.Size(155, 22);
            this.Txt_nombreE.TabIndex = 28;
            this.Txt_nombreE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_nombreE_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 29);
            this.label8.TabIndex = 27;
            this.label8.Text = "Nombre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 29);
            this.label7.TabIndex = 26;
            this.label7.Text = "Apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(240, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(263, 29);
            this.label6.TabIndex = 25;
            this.label6.Text = "Fecha de nacimiento ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(237, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 29);
            this.label5.TabIndex = 24;
            this.label5.Text = "Correo electronico";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 29);
            this.label4.TabIndex = 23;
            this.label4.Text = "Contacto de:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(528, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 29);
            this.label3.TabIndex = 22;
            this.label3.Text = "Sexo";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(11, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 34);
            this.button1.TabIndex = 21;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtB_ID
            // 
            this.txtB_ID.Location = new System.Drawing.Point(267, 119);
            this.txtB_ID.Multiline = true;
            this.txtB_ID.Name = "txtB_ID";
            this.txtB_ID.Size = new System.Drawing.Size(155, 22);
            this.txtB_ID.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ingrese el ID del usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "Usuarios";
            // 
            // TABLA_
            // 
            this.TABLA_.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TABLA_.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TABLA_.ColumnHeadersHeight = 29;
            this.TABLA_.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dg_ID_admin_U,
            this.DG_Nombre_U,
            this.dgApellido_U,
            this.dgNacimiento_U,
            this.dg_correo_U,
            this.Sexo,
            this.dg_Eliminar});
            this.TABLA_.Location = new System.Drawing.Point(4, 439);
            this.TABLA_.Name = "TABLA_";
            this.TABLA_.RowHeadersWidth = 51;
            this.TABLA_.RowTemplate.Height = 24;
            this.TABLA_.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TABLA_.Size = new System.Drawing.Size(836, 350);
            this.TABLA_.TabIndex = 35;
            this.TABLA_.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TABLA__CellContentClick);
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
            this.dgNacimiento_U.Width = 168;
            // 
            // dg_correo_U
            // 
            this.dg_correo_U.HeaderText = "Correo Electronico";
            this.dg_correo_U.MinimumWidth = 6;
            this.dg_correo_U.Name = "dg_correo_U";
            this.dg_correo_U.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_correo_U.Width = 154;
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Contraseña del correo";
            this.Sexo.MinimumWidth = 6;
            this.Sexo.Name = "Sexo";
            this.Sexo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Sexo.Width = 178;
            // 
            // dg_Eliminar
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Red;
            this.dg_Eliminar.DefaultCellStyle = dataGridViewCellStyle1;
            this.dg_Eliminar.HeaderText = "eliminar";
            this.dg_Eliminar.MinimumWidth = 6;
            this.dg_Eliminar.Name = "dg_Eliminar";
            this.dg_Eliminar.Width = 63;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Masculino",
            "Femenido"});
            this.comboBox1.Location = new System.Drawing.Point(533, 287);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtIDdepen);
            this.panel1.Location = new System.Drawing.Point(536, 315);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 118);
            this.panel1.TabIndex = 37;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(350, 168);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 34);
            this.button3.TabIndex = 38;
            this.button3.Text = "Volver";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // txt_fechaE
            // 
            this.txt_fechaE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_fechaE.Location = new System.Drawing.Point(245, 395);
            this.txt_fechaE.Name = "txt_fechaE";
            this.txt_fechaE.Size = new System.Drawing.Size(155, 22);
            this.txt_fechaE.TabIndex = 39;
            this.txt_fechaE.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // contactos
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 783);
            this.Controls.Add(this.txt_fechaE);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.TABLA_);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_apellidoE);
            this.Controls.Add(this.txt_correoE);
            this.Controls.Add(this.Txt_nombreE);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtB_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "contactos";
            this.Text = "contactos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Contactos_FormClosed);
            this.Load += new System.EventHandler(this.Contactos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TABLA_)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtIDdepen;
        private System.Windows.Forms.TextBox txt_apellidoE;
        private System.Windows.Forms.TextBox txt_correoE;
        private System.Windows.Forms.TextBox Txt_nombreE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtB_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView TABLA_;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_ID_admin_U;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_Nombre_U;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgApellido_U;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgNacimiento_U;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_correo_U;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewButtonColumn dg_Eliminar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker txt_fechaE;
    }
}