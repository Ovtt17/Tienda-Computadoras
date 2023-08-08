using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    public class Computador
    {
        private string marca;
        private int memoriaRam;
        private string procesador;
        private string estado;
        private double precio;
        private string arquitectura;
        private string memoriaExpandible;

        //getters y setters
        public string Marca { get => marca; set => marca = value; }
        public int MemoriaRam { get => memoriaRam; set => memoriaRam = value; }
        public string Procesador { get => procesador; set => procesador = value; }
        public string Estado { get => estado; set => estado = value; }
        public double Precio { get => precio; set => precio = value; }
        public string Arquitectura { get => arquitectura; set => arquitectura = value; }
        public string MemoriaExpandible { get => memoriaExpandible; set => memoriaExpandible = value; }
    }
}
