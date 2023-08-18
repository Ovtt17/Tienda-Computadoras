namespace Tienda
{
    partial class FormVisualizar
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
            this.grilla = new System.Windows.Forms.DataGridView();
            this.btnEliminarFila = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarMarca = new System.Windows.Forms.TextBox();
            this.btnBuscarMarca = new System.Windows.Forms.Button();
            this.btnEliminarTodo = new System.Windows.Forms.Button();
            this.btnEliminarFiltro = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // grilla
            // 
            this.grilla.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Location = new System.Drawing.Point(135, 89);
            this.grilla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grilla.Name = "grilla";
            this.grilla.RowHeadersWidth = 51;
            this.grilla.RowTemplate.Height = 24;
            this.grilla.Size = new System.Drawing.Size(1009, 433);
            this.grilla.TabIndex = 9;
            // 
            // btnEliminarFila
            // 
            this.btnEliminarFila.BackColor = System.Drawing.Color.Orange;
            this.btnEliminarFila.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarFila.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEliminarFila.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEliminarFila.Location = new System.Drawing.Point(557, 543);
            this.btnEliminarFila.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarFila.Name = "btnEliminarFila";
            this.btnEliminarFila.Size = new System.Drawing.Size(148, 52);
            this.btnEliminarFila.TabIndex = 32;
            this.btnEliminarFila.Text = "Eliminar";
            this.btnEliminarFila.UseVisualStyleBackColor = false;
            this.btnEliminarFila.Click += new System.EventHandler(this.btnEliminarFila_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(158, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Marca:";
            // 
            // txtBuscarMarca
            // 
            this.txtBuscarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarMarca.Location = new System.Drawing.Point(237, 35);
            this.txtBuscarMarca.Name = "txtBuscarMarca";
            this.txtBuscarMarca.Size = new System.Drawing.Size(172, 30);
            this.txtBuscarMarca.TabIndex = 34;
            // 
            // btnBuscarMarca
            // 
            this.btnBuscarMarca.BackColor = System.Drawing.Color.Green;
            this.btnBuscarMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscarMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBuscarMarca.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBuscarMarca.Location = new System.Drawing.Point(439, 26);
            this.btnBuscarMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarMarca.Name = "btnBuscarMarca";
            this.btnBuscarMarca.Size = new System.Drawing.Size(148, 52);
            this.btnBuscarMarca.TabIndex = 36;
            this.btnBuscarMarca.Text = "Buscar";
            this.btnBuscarMarca.UseVisualStyleBackColor = false;
            this.btnBuscarMarca.Click += new System.EventHandler(this.btnBuscarMarca_Click);
            // 
            // btnEliminarTodo
            // 
            this.btnEliminarTodo.BackColor = System.Drawing.Color.Red;
            this.btnEliminarTodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEliminarTodo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEliminarTodo.Location = new System.Drawing.Point(877, 543);
            this.btnEliminarTodo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarTodo.Name = "btnEliminarTodo";
            this.btnEliminarTodo.Size = new System.Drawing.Size(148, 52);
            this.btnEliminarTodo.TabIndex = 37;
            this.btnEliminarTodo.Text = "Eliminar Todo";
            this.btnEliminarTodo.UseVisualStyleBackColor = false;
            this.btnEliminarTodo.Click += new System.EventHandler(this.btnEliminarTodo_Click);
            // 
            // btnEliminarFiltro
            // 
            this.btnEliminarFiltro.BackColor = System.Drawing.Color.Red;
            this.btnEliminarFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEliminarFiltro.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEliminarFiltro.Location = new System.Drawing.Point(610, 26);
            this.btnEliminarFiltro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarFiltro.Name = "btnEliminarFiltro";
            this.btnEliminarFiltro.Size = new System.Drawing.Size(148, 52);
            this.btnEliminarFiltro.TabIndex = 38;
            this.btnEliminarFiltro.Text = "Quitar Filtro";
            this.btnEliminarFiltro.UseVisualStyleBackColor = false;
            this.btnEliminarFiltro.Click += new System.EventHandler(this.btnEliminarFiltro_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Green;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgregar.Location = new System.Drawing.Point(237, 543);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(148, 52);
            this.btnAgregar.TabIndex = 39;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // FormVisualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1284, 637);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEliminarFiltro);
            this.Controls.Add(this.btnEliminarTodo);
            this.Controls.Add(this.btnBuscarMarca);
            this.Controls.Add(this.txtBuscarMarca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminarFila);
            this.Controls.Add(this.grilla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormVisualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabla de Datos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormVisualizar_FormClosing);
            this.Load += new System.EventHandler(this.FormVisualizar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.Button btnEliminarFila;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarMarca;
        private System.Windows.Forms.Button btnBuscarMarca;
        private System.Windows.Forms.Button btnEliminarTodo;
        private System.Windows.Forms.Button btnEliminarFiltro;
        private System.Windows.Forms.Button btnAgregar;
    }
}