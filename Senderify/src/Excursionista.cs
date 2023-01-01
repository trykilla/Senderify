using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senderify.src
{
    internal class Excursionista
    {
        private string nombre;
        private string edad;
        private string telefono;
        private string email;
        private string ruta_foto;
        private List<Ruta> rutas;

        // Constructor de la clase
        public Excursionista(string nombre, string edad, string telefono, string email, string ruta_foto, List<Ruta> rutas)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.telefono = telefono;
            this.email = email;
            this.ruta_foto = ruta_foto;
            this.rutas = rutas;
        }

        // Getters y setters para cada atributo
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Ruta_foto
        {
            get { return ruta_foto; }
            set { ruta_foto = value; }
        }
        public List<Ruta> Rutas
        {
            get { return rutas; }
            set { rutas = value; }
        }
    }
}
