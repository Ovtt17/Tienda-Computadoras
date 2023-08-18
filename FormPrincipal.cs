using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda
{
    public partial class FormPrincipal : Form
    {
        // Propiedad estática para almacenar la instancia única de FormPrincipal
        private static FormPrincipal instancia;

        //creamos la lista de tipo Computador
        private List<Computador> lista = new List<Computador>();

        public FormPrincipal()
        {
            InitializeComponent();
            instancia = this;
        }
        // Agrega un método estático para obtener la instancia actual de FormPrincipal
        public static FormPrincipal GetInstancia()
        {
            return instancia;
        }
        //evento para guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //guardamos los datos
            Guardar();
            //limpiamos los campos que se llenaron de informacion
            LimpiarCampos();
        }
        //evento para ver datos guardados
        private void btnVerTabla_Click(object sender, EventArgs e)
        {
            FormVisualizar formVisualizar = new FormVisualizar(lista);
            this.Hide(); // ocultar el formulario principal
            formVisualizar.ShowDialog();
        }

        //evento para limpiar los datos que se introdujeron en los combobox y textbox
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        public void Guardar()
        {
            //Creamos el objeto Computador
            Computador computador;
            //convertimos las opciones seleccionadas a string
            //los de tipo numerico los convertimos a numeros
            string marcaSeleccionada = cmbMarca.SelectedItem.ToString();
            int memoriaRamSeleccionada = int.Parse(cmbMemoriaRAM.SelectedItem.ToString());
            string procesadorSeleccionado = txtProcesador.Text;
            string estadoSeleccionado = cmbEstado.SelectedItem.ToString();
            double precioIngresado;
            string arquitecturaSeleccionada = cmbArquitectura.SelectedItem.ToString();
            string memoriaExpandibleSeleccionada = cmbMemoriaExpandible.SelectedItem.ToString();

            

            //hacemos un try catch para comprobar de que se haya ingresado el precio de forma correcta
            try
            {
                precioIngresado = double.Parse(txtPrecio.Text);
            }
            catch (FormatException err)
            {
                MessageBox.Show($"ERROR: {err.Message}\n\nINGRESE EL PRECIO CORRECTAMENTE..");
                return;
            }
            //Validaciones al guardar los datos.
            bool marcaValida = marcaSeleccionada.Length != 0;
            bool ramValida = memoriaRamSeleccionada > 0;
            bool procesadorValido = procesadorSeleccionado.Length != 0;
            bool estadoValido = estadoSeleccionado.Length != 0;
            bool precioValido = precioIngresado > 0;
            bool arquitecturaValida = arquitecturaSeleccionada.Length != 0;
            bool memoriaExpValida = memoriaExpandibleSeleccionada.Length != 0;

            bool datosCorrectos = marcaValida && ramValida && procesadorValido
                                 && estadoValido && precioValido && arquitecturaValida
                                 && memoriaExpValida;

            if (datosCorrectos)
            {
                computador = new Computador()
                {
                    Marca = marcaSeleccionada,
                    MemoriaRam = memoriaRamSeleccionada,
                    Procesador = txtProcesador.Text,
                    Estado = estadoSeleccionado,
                    Precio = precioIngresado,
                    Arquitectura = arquitecturaSeleccionada,
                    MemoriaExpandible = memoriaExpandibleSeleccionada
                };
                //mandamos los datos a la lista
                lista.Add(computador);
                MessageBox.Show("DATOS GUARDADOS CON EXITO...");
            }
            else
            {
                MessageBox.Show("INGRESE LOS DATOS CORRECTAMENTE..");
                return;
            }




        }

        private void LimpiarCampos()
        {
            cmbMarca.SelectedIndex = -1;
            cmbMemoriaRAM.SelectedIndex = -1;
            txtProcesador.Text = "";
            cmbEstado.SelectedIndex = -1;
            txtPrecio.Text = "";
            cmbArquitectura.SelectedIndex = -1;
            cmbMemoriaExpandible.SelectedIndex = -1;
        }

    }
}
