using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senderify.src
{
    internal class pdi
    {
        private string nombre;
        private string descripcion;
        private string tipologia;
        private List<string> galeriaImagenes;

        // Constructor
        public pdi(string nombre, string descripcion, string tipologia, List<string> galeriaImagenes)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.tipologia = tipologia;
            this.galeriaImagenes = galeriaImagenes;
        }

        // Getters y setters
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Tipologia { get => tipologia; set => tipologia = value; }
        public List<string> GaleriaImagenes { get => galeriaImagenes; set => galeriaImagenes = value; }
    }
}

