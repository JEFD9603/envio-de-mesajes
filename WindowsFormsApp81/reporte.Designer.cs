namespace WindowsFormsApp81
{
    partial class reporte
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TABLAU = new System.Windows.Forms.DataGridView();
            this.correo = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.dg_ID_admin_U = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_correo_U = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recivido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgNacimiento_U = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.TABLAU)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TABLAU
            // 
            this.TABLAU.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TABLAU.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(40)))), ((int)(((byte)(33)))));
            this.TABLAU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TABLAU.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.TABLAU.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(40)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TABLAU.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.TABLAU.ColumnHeadersHeight = 48;
            this.TABLAU.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dg_ID_admin_U,
            this.dg_correo_U,
            this.nombreE,
            this.Recivido,
            this.Sexo,
            this.msj,
            this.dgNacimiento_U});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(40)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(40)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TABLAU.DefaultCellStyle = dataGridViewCellStyle8;
            this.TABLAU.EnableHeadersVisualStyles = false;
            this.TABLAU.GridColor = System.Drawing.Color.Maroon;
            this.TABLAU.Location = new System.Drawing.Point(1, 462);
            this.TABLAU.Name = "TABLAU";
            this.TABLAU.RowHeadersWidth = 51;
            this.TABLAU.RowTemplate.Height = 24;
            this.TABLAU.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TABLAU.Size = new System.Drawing.Size(1188, 279);
            this.TABLAU.TabIndex = 40;
            this.TABLAU.UseWaitCursor = true;
            this.TABLAU.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TABLA__CellContentClick);
            // 
            // correo
            // 
            this.correo.AutoSize = true;
            this.correo.BackColor = System.Drawing.Color.Transparent;
            this.correo.Font = new System.Drawing.Font("Monotype Corsiva", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correo.ForeColor = System.Drawing.Color.Maroon;
            this.correo.Location = new System.Drawing.Point(52, 220);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(129, 53);
            this.correo.TabIndex = 41;
            this.correo.Text = "Correo";
            this.correo.Click += new System.EventHandler(this.Correo_Click);
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.BackColor = System.Drawing.Color.Transparent;
            this.nombre.Font = new System.Drawing.Font("Monotype Corsiva", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.ForeColor = System.Drawing.Color.Maroon;
            this.nombre.Location = new System.Drawing.Point(52, 164);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(151, 53);
            this.nombre.TabIndex = 42;
            this.nombre.Text = "Nombre";
            // 
            // dg_ID_admin_U
            // 
            this.dg_ID_admin_U.HeaderText = "ID";
            this.dg_ID_admin_U.MinimumWidth = 6;
            this.dg_ID_admin_U.Name = "dg_ID_admin_U";
            this.dg_ID_admin_U.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dg_correo_U
            // 
            this.dg_correo_U.HeaderText = "Nombre";
            this.dg_correo_U.MinimumWidth = 6;
            this.dg_correo_U.Name = "dg_correo_U";
            this.dg_correo_U.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nombreE
            // 
            this.nombreE.HeaderText = "Enviado por";
            this.nombreE.MinimumWidth = 6;
            this.nombreE.Name = "nombreE";
            // 
            // Recivido
            // 
            this.Recivido.HeaderText = "Recivido por";
            this.Recivido.MinimumWidth = 6;
            this.Recivido.Name = "Recivido";
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Asunto";
            this.Sexo.MinimumWidth = 6;
            this.Sexo.Name = "Sexo";
            this.Sexo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // msj
            // 
            this.msj.HeaderText = "Mensaje";
            this.msj.MinimumWidth = 6;
            this.msj.Name = "msj";
            // 
            // dgNacimiento_U
            // 
            this.dgNacimiento_U.HeaderText = "Fecha de envio";
            this.dgNacimiento_U.MinimumWidth = 6;
            this.dgNacimiento_U.Name = "dgNacimiento_U";
            this.dgNacimiento_U.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // comboBox1
            // 
            this.comboBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(40)))), ((int)(((byte)(33)))));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.Font = new System.Drawing.Font("Monotype Corsiva", 23.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(306, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(96, 57);
            this.comboBox1.TabIndex = 43;
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBox1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(3, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 53);
            this.label3.TabIndex = 44;
            this.label3.Text = "Selecione un ID ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Location = new System.Drawing.Point(46, 316);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 130);
            this.panel3.TabIndex = 45;
            this.panel3.Visible = false;
            // 
            // reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.TABLAU);
            this.Name = "reporte";
            this.Text = "reporte";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Reporte_FormClosed);
            this.Load += new System.EventHandler(this.Reporte_Load);
            this.Controls.SetChildIndex(this.TABLAU, 0);
            this.Controls.SetChildIndex(this.correo, 0);
            this.Controls.SetChildIndex(this.nombre, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.TABLAU)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TABLAU;
        private System.Windows.Forms.Label correo;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_ID_admin_U;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_correo_U;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recivido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn msj;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgNacimiento_U;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
    }
}