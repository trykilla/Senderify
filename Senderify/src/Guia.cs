using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senderify.src
{
    internal class Guia
    {
        protected string nombre;
        protected string DNI;
        protected string idiomas;
        protected string disponibilidad;
        protected string telefono;
        protected string email;
        protected string puntuación;
        protected string perfil;
        protected List<Ruta> rutas;



        public Guia(string nombre, string DNI, string idiomas, string disponibilidad, string telefono, string email, string puntuacion, string perfil, List<Ruta> rutas)
        {
            this.nombre = nombre;
            this.DNI = DNI;
            this.idiomas = idiomas;
            this.disponibilidad = disponibilidad;
            this.telefono = telefono;
            this.email = email;
            this.puntuación = puntuacion;
            this.perfil = perfil;
            this.rutas = rutas;
        }
        

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        

        public string Dni
        {
            get { return DNI; }
            set { DNI = value; }
        }

    

        public string Idiomas
        {
            get { return idiomas; }
            set { idiomas = value; }
        }

        public string Disponibilidad
        {
            get { return disponibilidad; }
            set { disponibilidad = value; }
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

        public string Puntuacion
        {
            get { return puntuación; }
            set { puntuación = value; }
        }

        public string Perfil
        {
            get { return perfil; }
            set { perfil = value; }
        }

        public List<Ruta> Rutas
        {
            get { return rutas; }
            set { rutas = value; }
        }
    }
}


/*
 Nombre
 Idiomas
 Disponibilidad
 Telefono
 Email
 Puntuación.
 
 
 
 */