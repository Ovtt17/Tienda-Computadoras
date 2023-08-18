namespace Tienda
{
    partial class FormPrincipal
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
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelRAM = new System.Windows.Forms.Label();
            this.labelProcesador = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelArquitectura = new System.Windows.Forms.Label();
            this.labelMemoriaExpandible = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.txtProcesador = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.cmbArquitectura = new System.Windows.Forms.ComboBox();
            this.cmbMemoriaExpandible = new System.Windows.Forms.ComboBox();
            this.btnVerTabla = new System.Windows.Forms.Button();
            this.cmbMemoriaRAM = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelMarca.ForeColor = System.Drawing.Color.White;
            this.labelMarca.Location = new System.Drawing.Point(12, 35);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(209, 20);
            this.labelMarca.TabIndex = 0;
            this.labelMarca.Text = "Marca de la computadora: ";
            // 
            // labelRAM
            // 
            this.labelRAM.AutoSize = true;
            this.labelRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelRAM.ForeColor = System.Drawing.Color.White;
            this.labelRAM.Location = new System.Drawing.Point(12, 89);
            this.labelRAM.Name = "labelRAM";
            this.labelRAM.Size = new System.Drawing.Size(168, 20);
            this.labelRAM.TabIndex = 1;
            this.labelRAM.Text = "Memoria RAM (GB): ";
            // 
            // labelProcesador
            // 
            this.labelProcesador.AutoSize = true;
            this.labelProcesador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelProcesador.ForeColor = System.Drawing.Color.White;
            this.labelProcesador.Location = new System.Drawing.Point(12, 142);
            this.labelProcesador.Name = "labelProcesador";
            this.labelProcesador.Size = new System.Drawing.Size(105, 20);
            this.labelProcesador.TabIndex = 2;
            this.labelProcesador.Text = "Procesador: ";
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelEstado.ForeColor = System.Drawing.Color.White;
            this.labelEstado.Location = new System.Drawing.Point(12, 196);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(214, 20);
            this.labelEstado.TabIndex = 3;
            this.labelEstado.Text = "Estado de la computadora: ";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelPrecio.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPrecio.Location = new System.Drawing.Point(12, 249);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(93, 20);
            this.labelPrecio.TabIndex = 4;
            this.labelPrecio.Text = "Precio ($): ";
            // 
            // labelArquitectura
            // 
            this.labelArquitectura.AutoSize = true;
            this.labelArquitectura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelArquitectura.ForeColor = System.Drawing.SystemColors.Control;
            this.labelArquitectura.Location = new System.Drawing.Point(12, 299);
            this.labelArquitectura.Name = "labelArquitectura";
            this.labelArquitectura.Size = new System.Drawing.Size(110, 20);
            this.labelArquitectura.TabIndex = 6;
            this.labelArquitectura.Text = "Arquitectura: ";
            // 
            // labelMemoriaExpandible
            // 
            this.labelMemoriaExpandible.AutoSize = true;
            this.labelMemoriaExpandible.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelMemoriaExpandible.ForeColor = System.Drawing.SystemColors.Control;
            this.labelMemoriaExpandible.Location = new System.Drawing.Point(13, 361);
            this.labelMemoriaExpandible.Name = "labelMemoriaExpandible";
            this.labelMemoriaExpandible.Size = new System.Drawing.Size(168, 20);
            this.labelMemoriaExpandible.TabIndex = 7;
            this.labelMemoriaExpandible.Text = "Memoria expandible: ";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Green;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.Location = new System.Drawing.Point(50, 427);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(121, 57);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Red;
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBorrar.Location = new System.Drawing.Point(401, 427);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(135, 57);
            this.btnBorrar.TabIndex = 10;
            this.btnBorrar.Text = "Borrar Campos";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // txtProcesador
            // 
            this.txtProcesador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtProcesador.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtProcesador.Location = new System.Drawing.Point(136, 138);
            this.txtProcesador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProcesador.Name = "txtProcesador";
            this.txtProcesador.Size = new System.Drawing.Size(175, 26);
            this.txtProcesador.TabIndex = 17;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPrecio.Location = new System.Drawing.Point(111, 246);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 26);
            this.txtPrecio.TabIndex = 20;
            // 
            // cmbMarca
            // 
            this.cmbMarca.BackColor = System.Drawing.Color.White;
            this.cmbMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Items.AddRange(new object[] {
            "HP",
            "Lenovo",
            "Dell",
            "Acer",
            "Toshiba"});
            this.cmbMarca.Location = new System.Drawing.Point(235, 32);
            this.cmbMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(121, 28);
            this.cmbMarca.TabIndex = 5;
            // 
            // cmbEstado
            // 
            this.cmbEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Nueva",
            "Usada"});
            this.cmbEstado.Location = new System.Drawing.Point(246, 193);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 28);
            this.cmbEstado.TabIndex = 25;
            // 
            // cmbArquitectura
            // 
            this.cmbArquitectura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbArquitectura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArquitectura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbArquitectura.FormattingEnabled = true;
            this.cmbArquitectura.Items.AddRange(new object[] {
            "64 bits",
            "32 bits"});
            this.cmbArquitectura.Location = new System.Drawing.Point(141, 295);
            this.cmbArquitectura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbArquitectura.Name = "cmbArquitectura";
            this.cmbArquitectura.Size = new System.Drawing.Size(121, 28);
            this.cmbArquitectura.TabIndex = 26;
            // 
            // cmbMemoriaExpandible
            // 
            this.cmbMemoriaExpandible.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbMemoriaExpandible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMemoriaExpandible.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbMemoriaExpandible.FormattingEnabled = true;
            this.cmbMemoriaExpandible.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cmbMemoriaExpandible.Location = new System.Drawing.Point(208, 359);
            this.cmbMemoriaExpandible.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMemoriaExpandible.Name = "cmbMemoriaExpandible";
            this.cmbMemoriaExpandible.Size = new System.Drawing.Size(121, 28);
            this.cmbMemoriaExpandible.TabIndex = 27;
            // 
            // btnVerTabla
            // 
            this.btnVerTabla.BackColor = System.Drawing.Color.Orange;
            this.btnVerTabla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnVerTabla.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVerTabla.Location = new System.Drawing.Point(223, 427);
            this.btnVerTabla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVerTabla.Name = "btnVerTabla";
            this.btnVerTabla.Size = new System.Drawing.Size(133, 57);
            this.btnVerTabla.TabIndex = 29;
            this.btnVerTabla.Text = "Ver datos";
            this.btnVerTabla.UseVisualStyleBackColor = false;
            this.btnVerTabla.Click += new System.EventHandler(this.btnVerTabla_Click);
            // 
            // cmbMemoriaRAM
            // 
            this.cmbMemoriaRAM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbMemoriaRAM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMemoriaRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbMemoriaRAM.FormattingEnabled = true;
            this.cmbMemoriaRAM.Items.AddRange(new object[] {
            "4",
            "8",
            "12",
            "16",
            "32",
            "64",
            "128"});
            this.cmbMemoriaRAM.Location = new System.Drawing.Point(186, 86);
            this.cmbMemoriaRAM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMemoriaRAM.Name = "cmbMemoriaRAM";
            this.cmbMemoriaRAM.Size = new System.Drawing.Size(121, 28);
            this.cmbMemoriaRAM.TabIndex = 30;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(607, 526);
            this.Controls.Add(this.cmbMemoriaRAM);
            this.Controls.Add(this.btnVerTabla);
            this.Controls.Add(this.cmbMemoriaExpandible);
            this.Controls.Add(this.cmbArquitectura);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtProcesador);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.labelMemoriaExpandible);
            this.Controls.Add(this.labelArquitectura);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.labelProcesador);
            this.Controls.Add(this.labelRAM);
            this.Controls.Add(this.labelMarca);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tienda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelRAM;
        private System.Windows.Forms.Label labelProcesador;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelArquitectura;
        private System.Windows.Forms.Label labelMemoriaExpandible;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TextBox txtProcesador;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.ComboBox cmbArquitectura;
        private System.Windows.Forms.ComboBox cmbMemoriaExpandible;
        private System.Windows.Forms.Button btnVerTabla;
        private System.Windows.Forms.ComboBox cmbMemoriaRAM;
    }
}

