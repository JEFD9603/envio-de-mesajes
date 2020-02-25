namespace WindowsFormsApp81
{
    partial class Agregar_C
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
            this.button2 = new System.Windows.Forms.Button();
            this.btnagrega_c = new System.Windows.Forms.Button();
            this.rbAdminNO = new System.Windows.Forms.RadioButton();
            this.rbmasculino = new System.Windows.Forms.RadioButton();
            this.lbadmin = new System.Windows.Forms.Label();
            this.datenaci = new System.Windows.Forms.DateTimePicker();
            this.txtCore = new System.Windows.Forms.TextBox();
            this.txtApel = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(493, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 43);
            this.button2.TabIndex = 36;
            this.button2.Text = "Volver";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnagrega_c
            // 
            this.btnagrega_c.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagrega_c.Location = new System.Drawing.Point(653, 343);
            this.btnagrega_c.Name = "btnagrega_c";
            this.btnagrega_c.Size = new System.Drawing.Size(135, 43);
            this.btnagrega_c.TabIndex = 35;
            this.btnagrega_c.Text = "agregar";
            this.btnagrega_c.UseVisualStyleBackColor = true;
            this.btnagrega_c.Visible = false;
            this.btnagrega_c.Click += new System.EventHandler(this.Button1_Click);
            // 
            // rbAdminNO
            // 
            this.rbAdminNO.AutoSize = true;
            this.rbAdminNO.Location = new System.Drawing.Point(663, 96);
            this.rbAdminNO.Name = "rbAdminNO";
            this.rbAdminNO.Size = new System.Drawing.Size(91, 21);
            this.rbAdminNO.TabIndex = 34;
            this.rbAdminNO.TabStop = true;
            this.rbAdminNO.Text = "Femenino";
            this.rbAdminNO.UseVisualStyleBackColor = true;
            // 
            // rbmasculino
            // 
            this.rbmasculino.AutoSize = true;
            this.rbmasculino.Location = new System.Drawing.Point(554, 96);
            this.rbmasculino.Name = "rbmasculino";
            this.rbmasculino.Size = new System.Drawing.Size(92, 21);
            this.rbmasculino.TabIndex = 33;
            this.rbmasculino.TabStop = true;
            this.rbmasculino.Text = "Masculino";
            this.rbmasculino.UseVisualStyleBackColor = true;
            // 
            // lbadmin
            // 
            this.lbadmin.AutoSize = true;
            this.lbadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbadmin.Location = new System.Drawing.Point(549, 64);
            this.lbadmin.Name = "lbadmin";
            this.lbadmin.Size = new System.Drawing.Size(72, 29);
            this.lbadmin.TabIndex = 32;
            this.lbadmin.Text = "Sexo";
            // 
            // datenaci
            // 
            this.datenaci.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.datenaci.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datenaci.Location = new System.Drawing.Point(357, 187);
            this.datenaci.Name = "datenaci";
            this.datenaci.Size = new System.Drawing.Size(100, 22);
            this.datenaci.TabIndex = 31;
            this.datenaci.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // txtCore
            // 
            this.txtCore.Location = new System.Drawing.Point(357, 242);
            this.txtCore.Name = "txtCore";
            this.txtCore.Size = new System.Drawing.Size(100, 22);
            this.txtCore.TabIndex = 28;
            this.txtCore.TextChanged += new System.EventHandler(this.TxtCore_TextChanged);
            this.txtCore.Leave += new System.EventHandler(this.TxtCore_Leave);
            // 
            // txtApel
            // 
            this.txtApel.Location = new System.Drawing.Point(357, 147);
            this.txtApel.Name = "txtApel";
            this.txtApel.Size = new System.Drawing.Size(100, 22);
            this.txtApel.TabIndex = 27;
            this.txtApel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApel_KeyPress);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(357, 71);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 22);
            this.txtNom.TabIndex = 26;
            this.txtNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNom_KeyPress);
            this.txtNom.Leave += new System.EventHandler(this.TxtNom_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 28);
            this.label6.TabIndex = 25;
            this.label6.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 28);
            this.label5.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 28);
            this.label3.TabIndex = 22;
            this.label3.Text = "Correo Electronico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 28);
            this.label2.TabIndex = 21;
            this.label2.Text = "Fecha de nacimiento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 28);
            this.label1.TabIndex = 20;
            this.label1.Text = "Apellido";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Outlook.com",
            "Gmail.com",
            "Hotmail.com",
            "Yahoo.com"});
            this.comboBox1.Location = new System.Drawing.Point(479, 242);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 37;
            this.comboBox1.Text = "proveedor";
            // 
            // Agregar_C
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnagrega_c);
            this.Controls.Add(this.rbAdminNO);
            this.Controls.Add(this.rbmasculino);
            this.Controls.Add(this.lbadmin);
            this.Controls.Add(this.datenaci);
            this.Controls.Add(this.txtCore);
            this.Controls.Add(this.txtApel);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Agregar_C";
            this.Text = "Agregar_C";
            this.Load += new System.EventHandler(this.Agregar_C_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Agregar_C_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnagrega_c;
        private System.Windows.Forms.RadioButton rbAdminNO;
        private System.Windows.Forms.RadioButton rbmasculino;
        private System.Windows.Forms.Label lbadmin;
        private System.Windows.Forms.DateTimePicker datenaci;
        private System.Windows.Forms.TextBox txtCore;
        private System.Windows.Forms.TextBox txtApel;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}