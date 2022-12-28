using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace Senderify.src
{
    /// <summary>
    /// Lógica de interacción para Rutas.xaml
    /// </summary>
    public partial class Rutas : Window
    {
        List<Ruta> conjunto = new List<Ruta>();
        Ruta r = new Ruta("La Hermosa", "Ciudad Real", "Daimiel", "30Km", "22/09/2022", "18:00", "Normal", "Pedro Campos", "10", "No incluidas", "10euros", "Botas de Hiking", "Muchos", "Bus", "Bus");
        Ruta r2 = new Ruta("Paseo por la montaña", "Villarrubia", "Malagon", "33Km", "22/11/2022", "15:00", "Normal", "Enrique Mariño", "34", "No incluídas", "15 euros", "Botas de Hiking", "Muchos", "Bus", "Bus");
        Ruta r3 = new Ruta("Sendero del Bosque", "Madrid", "Burgos", "45Km", "17/12/2022", "9:00", "Fácil", "Ana Gómez", "12", "Incluidas", "25euros", "Zapatillas de senderismo", "Pocos", "Coche", "Tren");
        Ruta r4 = new Ruta("Excursión al Mar", "Cádiz", "Málaga", "60Km", "15/07/2022", "13:00", "Difícil", "Javier Martín", "20", "Incluidas", "30 euros", "Botas de senderismo", "Muchos", "Coche", "Barco");
        List<Guia> conguia = new List<Guia>();




        public Rutas()
        {
            InitializeComponent();
            conjunto.Add(r);
            conjunto.Add(r2);
            conjunto.Add(r3);
            conjunto.Add(r4);

            List<Ruta> ruta_g = new List<Ruta> { r, r2 };
            
            Guia g = new Guia("Pedro Rodriguez", "123456789A", "Español e inglés", "Fin de Semana", "666778899", "Pedro.Dominguez@gmail.com", "8,7", "/src/perifl.jpg",ruta_g);
            /*Guia g1 = new Guia("Juan Pérez", "987654321B", "Español, inglés y francés", "Todos los días", "123456789", "Juan.Perez@gmail.com", "9,5", "src/perifl");
            Guia g2 = new Guia("Ana García", "123123456C", "Español y alemán", "Sólo fines de semana", "987654321", "Ana.Garcia@gmail.com", "7,2", "src/perfoil");
            Guia g3 = new Guia("Pablo Martínez", "456456123D", "Español, italiano y portugués", "Todos los días", "456789123", "Pablo.Martinez@gmail.com", "8,9", "src/perifl");
            */
            conguia.Add(g); 
           /* conguia.Add(g1);
            conguia.Add(g2);
            conguia.Add(g3);
           */


            for (int i = 0; i < conjunto.Count; i++)
            {
                list_view_rutas.Items.Add(conjunto[i].Nombre);
            }

            for (int i = 0; i < conguia.Count; i++)
            {
                list_view_guias.Items.Add(conguia[i].Nombre);
            }

        }


        private void Rutas1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Cerrar p = new Cerrar();
            p.Visibility = Visibility.Visible;
        }

        private void Rutas_Helpbutt_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Estás en la ventana de rutas, a parte de consultar la información, puedes añadir una ruta nueva, modificarla o eliminarla. También puedes consultar la información de los guías que hay disponibles para cada ruta.");
        }

        



        private void btn_anadir_Click(object sender, RoutedEventArgs e)
        {
            String nombre = nombre_box.Text;
            String inicio = inicio_box.Text;
            String fin = fin_box.Text;
            String duracion = duracion_box.Text;
            String fecha = fecha_box1.Text;
            String hora = salida_box.Text;
            String dificultad = difi_box.Text;
            String guia = guia_box.Text;
            String excursionistas = n_box.Text;
            String incluye = comida_box.Text;
            String precio = precio_box.Text;
            String material = mat_box.Text;
            String vuelta = vuelta_box.Text;
            String acceso = acceso_box.Text;
            String pdis = pdis_box.Text;

            Ruta r = new Ruta(nombre, inicio, fin, duracion, fecha, hora, dificultad, 
                guia, excursionistas, incluye, precio, material, pdis, acceso, vuelta);
            conjunto.Add(r);
            list_view_rutas.Items.Add(r.Nombre);


        }

        private void btn_borrar_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < conjunto.Count; i++)
            {
                if (list_view_rutas.SelectedItem.Equals(conjunto[i].Nombre))
                {
                    conjunto.RemoveAt(i);
                    nombre_box.Text = "";
                    inicio_box.Text = "";
                    fin_box.Text = "";
                    duracion_box.Text = "";
                    fecha_box1.Text = "";
                    salida_box.Text = "";
                    difi_box.Text = "";
                    guia_box.Text = "";
                    n_box.Text = "";
                    comida_box.Text = "";
                    precio_box.Text = "";
                    mat_box.Text = "";
                    pdis_box.Text = "";
                    vuelta_box.Text = "";
                    acceso_box.Text = "";
                    list_view_rutas.Items.RemoveAt(i); 
                    break;
                }
            }
        }

        private void list_view_rutas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            for (int i = 0; i < conjunto.Count; i++)
            {
                if (list_view_rutas.SelectedItem == null) {
                    break;
                }
                if (list_view_rutas.SelectedItem.Equals(conjunto[i].Nombre))
                {
                    nombre_box.Text = conjunto[i].Nombre;
                    inicio_box.Text = conjunto[i].Inicio;
                    fin_box.Text = conjunto[i].Fin;
                    duracion_box.Text = conjunto[i].Duracion;
                    fecha_box1.Text = conjunto[i].Fecha;
                    salida_box.Text = conjunto[i].Hora;
                    difi_box.Text = conjunto[i].Dificultad;
                    guia_box.Text = conjunto[i].Guia;
                    n_box.Text = conjunto[i].N_excursionistas;
                    comida_box.Text = conjunto[i].Comida_bebida;
                    precio_box.Text = conjunto[i].Precio;
                    mat_box.Text = conjunto[i].Material;
                    pdis_box.Text = conjunto[i].Pdi;
                    vuelta_box.Text = conjunto[i].Acceso_vuelta;
                    acceso_box.Text = conjunto[i].Acceso_orig;
                    break;
                    
                                    }
            }
        }

        private void btn_modificar_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < conjunto.Count; i++)
            {
                if (list_view_rutas.SelectedItem.Equals(conjunto[i].Nombre))
                {
                    
                    conjunto[i].Inicio = inicio_box.Text;
                    conjunto[i].Fin = fin_box.Text;
                    conjunto[i].Duracion = duracion_box.Text;
                    conjunto[i].Fecha = fecha_box1.Text;
                    conjunto[i].Hora = salida_box.Text;
                    conjunto[i].Dificultad = difi_box.Text;
                    conjunto[i].Guia = guia_box.Text;
                    conjunto[i].N_excursionistas = n_box.Text;
                    conjunto[i].Comida_bebida = comida_box.Text;
                    conjunto[i].Precio = precio_box.Text;
                    conjunto[i].Material = mat_box.Text;
                    conjunto[i].Pdi = pdis_box.Text;
                    conjunto[i].Acceso_vuelta = vuelta_box.Text;
                    conjunto[i].Acceso_orig = acceso_box.Text;
                    break;





                }
            }
        }

        private void list_view_guias_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            for (int i = 0; i < conguia.Count; i++)
            {
                if (list_view_guias.SelectedItem == null)
                {
                    break;
                }
                if (list_view_guias.SelectedItem.Equals(conguia[i].Nombre))
                {
                   guia_nombre_box.Text = conguia[i].Nombre;
                   guia_dni_box.Text = conguia[i].Dni;
                   guia_idioma_box.Text = conguia[i].Idiomas;
                   guia_dispo_box.Text = conguia[i].Disponibilidad;
                   guia_tel_box.Text = conguia[i].Telefono;
                   guia_gmail_box.Text = conguia[i].Email;
                   guia_punt_box.Text = conguia[i].Puntuacion;
                    for (int j = 0; j < conguia[i].Rutas.Count; j++)
                        lista_rutas.Items.Add(conguia[i].Rutas[j].Nombre);
                    foto_guia.Source = new BitmapImage(new Uri(conguia[i].Perfil, UriKind.RelativeOrAbsolute));
                    
                   break;

                }
            }

        }

        private void btn_anadirguia_Click(object sender, RoutedEventArgs e)
        {
            String nombre = guia_nombre_box.Text;
            String DNI = guia_dni_box.Text;
            String idiomas = guia_idioma_box.Text;
            String dispo = guia_dispo_box.Text;
            String tel = guia_tel_box.Text;
            String gmail = guia_gmail_box.Text;
            String punt = guia_punt_box.Text;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Imágenes (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
            List<Ruta> rutas = new List<Ruta>();

            Guia g = new Guia(nombre,DNI,idiomas,dispo, tel, gmail, punt,"",rutas);
           
            if (openFileDialog.ShowDialog() == true)
            {
                // Obtiene la ruta de la imagen seleccionada en forma de cadena de caracteres
                string imagePath = openFileDialog.FileName;

                // Añade la ruta de la imagen al objeto aquí, por ejemplo, estableciendo la propiedad de ruta de imagen del objeto en la ruta de la imagen
                g.Perfil = imagePath;
            }


            conguia.Add(g);
            list_view_guias.Items.Add(g.Nombre);

        }

        private void btn_borrarguia_Click(object sender, RoutedEventArgs e)
        {
            for(int i = 0; i < conguia.Count; i++)
            {
                if (list_view_guias.SelectedItem.Equals(conguia[i].Nombre)) { 
                conguia.RemoveAt(i);
                guia_nombre_box.Text = "";
                guia_dni_box.Text = "";
                guia_idioma_box.Text = "";
                guia_dispo_box.Text = "";
                guia_tel_box.Text = "";
                guia_gmail_box.Text = "";
                guia_punt_box.Text = "";
                    foto_guia.Source = null;
                    lista_rutas.Items.Clear();
                    list_view_guias.Items.RemoveAt(i);
                    break;
                }



            }
        }

        private void btn_modificarguia_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < conguia.Count; i++) {

                if (list_view_guias.SelectedItem.Equals(conguia[i].Nombre))
                {
                    conguia[i].Dni = guia_dni_box.Text;
                    conguia[i].Idiomas = guia_idioma_box.Text;
                    conguia[i].Disponibilidad = guia_dispo_box.Text;
                    conguia[i].Telefono = guia_tel_box.Text;
                    conguia[i].Email = guia_gmail_box.Text;
                    conguia[i].Puntuacion = guia_punt_box.Text;

                    break;
                }
            }

        }

        private void lista_rutas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            for (int i = 0; i < conjunto.Count; i++)
            {
                if (lista_rutas.SelectedItem.Equals(conjunto[i].Nombre))
                 {
                    
                    list_view_rutas.SelectedItem = conjunto[i].Nombre;
                    tab_control.SelectedIndex = 0;
                    break;

                }

            }
        }

        private void Guias_helpbutt_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Estás en la ventana de guías, además de consultar la información, aquí podrás añadir, modificar y borrar guías. Para añadir una guía, rellena los campos y pulsa el botón añadir. Para modificar una guía, selecciona una guía de la lista y modifica los campos que quieras. Para borrar una guía, selecciona una guía de la lista y pulsa el botón borrar.");
        }
    }
}
    

