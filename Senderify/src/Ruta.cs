using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senderify.src
{
    internal class Ruta
    {
        protected string nombre;
        protected string inicio;
        protected string fin;
        protected string duracion;
        protected string fecha;
        protected string hora;
        protected string dificultad;
        protected string guia;
        protected string n_excursionistas;
        protected string comida_bebida;
        protected string precio;
        protected string material; /*Deportivas, botas,*/
        protected string pdi;
        protected string acceso_orig;
        protected string acceso_vuelta;

        public Ruta(string nombre, string inicio, string fin, string duracion, string fecha, string hora, string dificultad, string guia, string n_excursionistas, string comida_bebida, string precio, string material, string pdi, string acceso_orig, string acceso_vuelta)
        {
            this.nombre = nombre;
            this.inicio = inicio;
            this.fin = fin;
            this.duracion = duracion;
            this.fecha = fecha;
            this.hora = hora;
            this.dificultad = dificultad;
            this.guia = guia;
            this.n_excursionistas = n_excursionistas;
            this.comida_bebida = comida_bebida;
            this.precio = precio;
            this.material = material;
            this.pdi = pdi;
            this.acceso_orig = acceso_orig;
            this.acceso_vuelta = acceso_vuelta;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Inicio { get => inicio; set => inicio = value; }
        public string Fin { get => fin; set => fin = value; }
        public string Duracion { get => duracion; set => duracion = value; }

        public string Fecha { get => fecha; set => fecha = value; }
        public string Hora { get => hora; set => hora = value; }
        public string Dificultad { get => dificultad; set => dificultad = value; }
        public string Guia { get => guia; set => guia = value; }
        public string N_excursionistas { get => n_excursionistas; set => n_excursionistas = value; }
        public string Comida_bebida { get => comida_bebida; set => comida_bebida = value; }
        public string Precio { get => precio; set => precio = value; }
        public string Material { get => material; set => material = value; }
        public string Pdi { get => pdi; set => pdi = value; }
        public string Acceso_orig { get => acceso_orig; set => acceso_orig = value; }
        public string Acceso_vuelta { get => acceso_vuelta; set => acceso_vuelta = value; }
        
        

    }
}

/*Guía: Pedro Calcerrada
Número de excursionistas: 23
Duración: 4 horas
Acceso al punto de origen: En autobús
Acceso de vuelta: En autobús
Material necesario: Unas deportivas
Comida y bebida: No incluida
Puntos de interés*/
