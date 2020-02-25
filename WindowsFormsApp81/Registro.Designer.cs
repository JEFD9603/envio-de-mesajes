namespace WindowsFormsApp81
{
    partial class Registro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtCoreoE = new System.Windows.Forms.TextBox();
            this.txtContraseñaC = new System.Windows.Forms.TextBox();
            this.txtcontraseñaA = new System.Windows.Forms.TextBox();
            this.datenacimiento = new System.Windows.Forms.DateTimePicker();
            this.lbadmin = new System.Windows.Forms.Label();
            this.rbadminSI = new System.Windows.Forms.RadioButton();
            this.rbAdminNO = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apellido";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de nacimiento";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Correo Electronico";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contraseña de Correo";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(316, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contraseña de Aplicacion ";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nombre";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(357, 107);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 6;
            this.txtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(357, 183);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 22);
            this.txtApellido.TabIndex = 9;
            this.txtApellido.TextChanged += new System.EventHandler(this.TxtApellido_TextChanged);
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApellido_KeyPress);
            // 
            // txtCoreoE
            // 
            this.txtCoreoE.Location = new System.Drawing.Point(357, 278);
            this.txtCoreoE.Name = "txtCoreoE";
            this.txtCoreoE.Size = new System.Drawing.Size(100, 22);
            this.txtCoreoE.TabIndex = 10;
            this.txtCoreoE.TextChanged += new System.EventHandler(this.TxtCoreoE_TextChanged);
            // 
            // txtContraseñaC
            // 
            this.txtContraseñaC.Location = new System.Drawing.Point(357, 345);
            this.txtContraseñaC.Name = "txtContraseñaC";
            this.txtContraseñaC.Size = new System.Drawing.Size(100, 22);
            this.txtContraseñaC.TabIndex = 11;
            this.txtContraseñaC.TextChanged += new System.EventHandler(this.TxtContraseñaC_TextChanged);
            // 
            // txtcontraseñaA
            // 
            this.txtcontraseñaA.Location = new System.Drawing.Point(357, 400);
            this.txtcontraseñaA.Name = "txtcontraseñaA";
            this.txtcontraseñaA.Size = new System.Drawing.Size(100, 22);
            this.txtcontraseñaA.TabIndex = 12;
            this.txtcontraseñaA.TextChanged += new System.EventHandler(this.TxtcontraseñaA_TextChanged);
            // 
            // datenacimiento
            // 
            this.datenacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datenacimiento.Location = new System.Drawing.Point(357, 223);
            this.datenacimiento.Name = "datenacimiento";
            this.datenacimiento.Size = new System.Drawing.Size(100, 22);
            this.datenacimiento.TabIndex = 13;
            this.datenacimiento.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.datenacimiento.ValueChanged += new System.EventHandler(this.Datenacimiento_ValueChanged);
            // 
            // lbadmin
            // 
            this.lbadmin.AutoSize = true;
            this.lbadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbadmin.Location = new System.Drawing.Point(549, 100);
            this.lbadmin.Name = "lbadmin";
            this.lbadmin.Size = new System.Drawing.Size(217, 29);
            this.lbadmin.TabIndex = 14;
            this.lbadmin.Text = "Es administrador ";
            this.lbadmin.Click += new System.EventHandler(this.Lbadmin_Click);
            // 
            // rbadminSI
            // 
            this.rbadminSI.AutoSize = true;
            this.rbadminSI.Location = new System.Drawing.Point(587, 124);
            this.rbadminSI.Name = "rbadminSI";
            this.rbadminSI.Size = new System.Drawing.Size(41, 21);
            this.rbadminSI.TabIndex = 15;
            this.rbadminSI.TabStop = true;
            this.rbadminSI.Text = "SI";
            this.rbadminSI.UseVisualStyleBackColor = true;
            this.rbadminSI.CheckedChanged += new System.EventHandler(this.RbadminSI_CheckedChanged);
            // 
            // rbAdminNO
            // 
            this.rbAdminNO.AutoSize = true;
            this.rbAdminNO.Location = new System.Drawing.Point(659, 125);
            this.rbAdminNO.Name = "rbAdminNO";
            this.rbAdminNO.Size = new System.Drawing.Size(50, 21);
            this.rbAdminNO.TabIndex = 16;
            this.rbAdminNO.TabStop = true;
            this.rbAdminNO.Text = "NO";
            this.rbAdminNO.UseVisualStyleBackColor = true;
            this.rbAdminNO.CheckedChanged += new System.EventHandler(this.RbAdminNO_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(653, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 43);
            this.button1.TabIndex = 18;
            this.button1.Text = "agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(493, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 43);
            this.button2.TabIndex = 19;
            this.button2.Text = "Volver";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Outlook.com",
            "Gmail.com",
            "Hotmail.com",
            "Yahoo.com"});
            this.comboBox1.Location = new System.Drawing.Point(482, 278);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 38;
            this.comboBox1.Text = "proveedor";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbAdminNO);
            this.Controls.Add(this.rbadminSI);
            this.Controls.Add(this.lbadmin);
            this.Controls.Add(this.datenacimiento);
            this.Controls.Add(this.txtcontraseñaA);
            this.Controls.Add(this.txtContraseñaC);
            this.Controls.Add(this.txtCoreoE);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Registro";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Registro_FormClosed);
            this.Load += new System.EventHandler(this.Registro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtCoreoE;
        private System.Windows.Forms.TextBox txtContraseñaC;
        private System.Windows.Forms.TextBox txtcontraseñaA;
        private System.Windows.Forms.DateTimePicker datenacimiento;
        private System.Windows.Forms.Label lbadmin;
        private System.Windows.Forms.RadioButton rbadminSI;
        private System.Windows.Forms.RadioButton rbAdminNO;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}