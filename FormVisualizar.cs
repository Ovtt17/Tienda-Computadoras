using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tienda;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tienda
{
    public partial class FormVisualizar : Form
    {
        DataTable tabla;
        private List<Computador> listaCopia = new List<Computador>();

        public FormVisualizar()
        {
            InitializeComponent();
            listaCopia = null;
        }
        public FormVisualizar(List<Computador> lista)
        {
            InitializeComponent();
            listaCopia = lista;
        }
        private void FormVisualizar_Load(object sender, EventArgs e)
        {
            IniciarTabla();
        }
        private void FormVisualizar_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormPrincipal.GetInstancia().Show();
        }
        //evento para eliminar los datos de la tabla (lista)
        private void btnEliminarFila_Click(object sender, EventArgs e)
        {
            EliminarFila();
        }
        private void btnBuscarMarca_Click(object sender, EventArgs e)
        {
            Buscar();
        }
        private void btnEliminarTodo_Click(object sender, EventArgs e)
        {
            //limpiamos la lista
            listaCopia.Clear();
            VisualizarListaPrincipal();
            MessageBox.Show("Se han eliminado todos los registros.");
        }
        private void btnEliminarFiltro_Click(object sender, EventArgs e)
        {
            //iniciar la tabla de nuevo
            if(txtBuscarMarca.Text == string.Empty)
            {
                MessageBox.Show("Actualmente no hay ningun filtro.");
            }
            txtBuscarMarca.Text = "";
            VisualizarListaPrincipal();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Close();
            // Obtiene la instancia actual de FormPrincipal y la muestra
            FormPrincipal.GetInstancia().Show();
        }
        
        private void IniciarTabla()
        {
            //inicializacion de tabla
            //creamos una tabla
            tabla = new DataTable("Computadoras");

            //agregacion de columnas a la tabla
            tabla.Columns.Add("Marca");
            tabla.Columns.Add("Memoria RAM");
            tabla.Columns.Add("Procesador");
            tabla.Columns.Add("Estado");
            tabla.Columns.Add("Precio");
            tabla.Columns.Add("Arquitectura");
            tabla.Columns.Add("Memoria Expandible");
            // se asigna la tabla "tabla" como origen de datos al control gráfico
            grilla.DataSource = tabla;
            VisualizarListaPrincipal();
        }
        //utilizo este metodo (VisualizarListaPrincipal) para ahorrar memoria
        //en lugar de estar creando nuevas tablas
        private void VisualizarListaPrincipal()
        {
            //limpiamos filas de la tabla
            tabla.Rows.Clear();
            //recorrer todos los datos guardados en la lista principal
            foreach (Computador computador in listaCopia)
            {
                CrearFila(computador);
            }

        }
        private void CrearFila(Computador computador)
        {
            //creamos una nueva fila en la tabla
            DataRow fila = tabla.NewRow();
            fila["Marca"] = computador.Marca;
            fila["Memoria RAM"] = computador.MemoriaRam;
            fila["Procesador"] = computador.Procesador;
            fila["Estado"] = computador.Estado;
            fila["Precio"] = computador.Precio;
            fila["Arquitectura"] = computador.Arquitectura;
            fila["Memoria Expandible"] = computador.MemoriaExpandible;
            //agregamos los datos a la tabla
            tabla.Rows.Add(fila);
        }
        private void EliminarFila()
        {
            int fila = grilla.CurrentRow.Index;
            //elimina la fila de la lista
            listaCopia.RemoveAt(fila);
            //visualizar datos de la lista
            VisualizarListaPrincipal();
            MessageBox.Show("Datos eliminados!!");
        }

        private void Buscar()
        {
            string marcaBuscada = txtBuscarMarca.Text.Trim(); //Trim() es para borrar espacios en blanco al principio y fin de la cadena

            // Verificar si el campo de búsqueda está vacío
            if (string.IsNullOrEmpty(marcaBuscada))
            {
                MessageBox.Show("Ingrese una marca para realizar la búsqueda.");
                return;
            }

            //crear una lista para guardar los datos que se encuentren
            List<Computador> coincidencias = new List<Computador>();

            foreach (Computador c in listaCopia)
            {
                string marcaGuardada = c.Marca;
                // pasamos a minusculas para evitar problema a la hora de escribir en minus
                if (marcaGuardada.ToLower() == marcaBuscada.ToLower()) 
                {
                    //en caso de encontrar, guardamos en la nueva lista
                    coincidencias.Add(c);
                }
            }
            
            if (coincidencias.Count == 0)
            {
                MessageBox.Show("No existe un computador con marca: " + txtBuscarMarca.Text);
            }
            else
            {
                //limpiar filas para mostrar solo las coincidencias
                tabla.Rows.Clear();

                // Mostrar todas las marcas encontradas
                foreach (Computador c in coincidencias)
                {
                    CrearFila(c);
                }
                // limpiamos para liberar memoria
                coincidencias.Clear();
            }
            
        }

    }
}
