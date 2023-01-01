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
using Application = System.Net.Mime.MediaTypeNames.Application;

namespace Senderify.src
{
    /// <summary>
    /// Lógica de interacción para Rutas.xaml
    /// </summary>
    public partial class Rutas : Window
    {

        List<Ruta> conjunto = new List<Ruta>();
        pdi pdi1 = new ("Mirador RioBueno", "Un mirador con vistas al río", "Mirador", new List<string>());
        pdi pdi2 = new ("Castillo Las Cruces", "Un castillo con estilo medieval", "Castillo", new List<string>());
        pdi pdi3 = new ("Big Ben Moderno", "Una torre con un reloj en la parte superior", "Torre", new List<string>());
        pdi pdi4 = new ("Puente Muerte Asegurada", "Un puente hecho de hierro y acero", "Puente", new List<string>());
        pdi pdi5 = new ("Museo Etnográfico", "Un museo de arte moderno y contemporáneo", "Museo", new List<string>());
        pdi pdi6 = new ("Catedral Granaca", "Una catedral con estilo gótico", "Catedral", new List<string>());
        pdi pdi7 = new ("Jardín botánico Madrico", "Un jardín con una gran variedad de plantas", "Jardín", new List<string>());
        pdi pdi8 = new ("Faro Las Luces", "Un faro en la costa para guiar a los barcos", "Faro", new List<string>());
      
        List<pdi> pdis = new List<pdi>();
        Ruta r = new("La Hermosa", "Ciudad Real", "Daimiel", "30Km", "22/09/2022", "18:00", "Normal", "", "10", "No incluidas", "10euros", "Botas de Hiking", "Muchos", "Bus", "Bus",null);
        Ruta r2 = new Ruta("Paseo por la montaña", "Villarrubia", "Malagon", "33Km", "22/11/2022", "15:00", "", "Enrique Mariño", "18", "No incluídas", "15 euros", "Botas de Hiking", "Muchos", "Bus", "Bus",null);
        Ruta r3 = new Ruta("Sendero del Bosque", "Madrid", "Burgos", "45Km", "17/12/2022", "9:00", "Fácil", "", "12", "Incluidas", "25euros", "Zapatillas de senderismo", "Pocos", "Coche", "Tren",null);
        Ruta r4 = new Ruta("Excursión al Mar", "Cádiz", "Málaga", "60Km", "15/07/2022", "13:00", "Difícil", "", "20", "Incluidas", "30 euros", "Botas de senderismo", "Muchos", "Coche", "Barco",null);
        List<Guia> conguia = new List<Guia>();
        List<Excursionista> excursionistas = new List<Excursionista>();




        public Rutas()
        {
            InitializeComponent();

            String src1 = "/src/mirador_rio.jpeg";
            String src2 = "/src/rio_mirador_2.jpeg";
            List<String> l1 = new List<string>();
            l1.Add(src1);
            l1.Add(src2);
            pdi1.GaleriaImagenes = l1;

            String src3 = "/src/castillo_medieval.jpeg";
            String src4 = "/src/castillo_medieval_2.jpeg";
            List<String> l2 = new List<string>();
            l2.Add(src3);
            l2.Add(src4);
            pdi2.GaleriaImagenes = l2;

            // Crea la lista de imágenes para el tercer PDI
            List<String> l3 = new List<string>();
            l3.Add("/src/torre_reloj.jpeg");
            l3.Add("/src/reloj_torre_2.jpeg");

            // Asigna la lista de imágenes al tercer PDI
            pdi3.GaleriaImagenes = l3;

            // Crea la lista de imágenes para el cuarto PDI
            List<String> l4 = new List<string>();
            l4.Add("/src/puente_hierro.jpeg");
            l4.Add("/src/hierro_puente_2.jpeg");

            // Asigna la lista de imágenes al cuarto PDI
            pdi4.GaleriaImagenes = l4;

            // Crea la lista de imágenes para el quinto PDI
            List<String> l5 = new List<string>();
            l5.Add("/src/museo_arte.jpeg");
            l5.Add("/src/arte_museo_2.jpeg");

            // Asigna la lista de imágenes al quinto PDI
            pdi5.GaleriaImagenes = l5;

            // Crea la lista de imágenes para el sexto PDI
            List<String> l6 = new List<string>();
            l6.Add("/src/catedral_gotic.jpeg");
            l6.Add("/src/gotic_catedral_2.jpeg");

            // Asigna la lista de imágenes al sexto PDI
            pdi6.GaleriaImagenes = l6;

            // Crea la lista de imágenes para el séptimo PDI
            List<String> l7 = new List<string>();
            l7.Add("/src/jardin_botanico.jpeg");
            l7.Add("/src/botanico_jardin_2.jpeg");

            pdi7.GaleriaImagenes = l7;

            // Crea la lista de imágenes para el octavo PDI
            List<String> l8 = new List<string>();
            l8.Add("/src/faro.jpeg");
            l8.Add("/src/faro_2.jpeg");

            // Asigna la lista de imágenes al octavo PDI
            pdi8.GaleriaImagenes = l8;




            List<pdi> pdis1 = new List<pdi> { pdi1, pdi2 };
            List<pdi> pdis2 = new List<pdi> { pdi3, pdi4 };
            List<pdi> pdis3 = new List<pdi> { pdi5, pdi6, pdi7 ,pdi8 };
           
            r.Pdis = pdis1;
            r2.Pdis = pdis2;
            r3.Pdis = pdis3;
            r.Pdi = r.Pdis.Count().ToString();
            r2.Pdi = r2.Pdis.Count().ToString();
            r3.Pdi = r3.Pdis.Count().ToString();
            r4.Pdi = "Sin puntos de interés...";

            pdis.Add(pdi1);
            pdis.Add(pdi2);
            pdis.Add(pdi3);
            pdis.Add(pdi4);
            pdis.Add(pdi5);
            pdis.Add(pdi6);
            pdis.Add(pdi7);
            pdis.Add(pdi8);

            conjunto.Add(r);
            conjunto.Add(r2);
            conjunto.Add(r3);
            conjunto.Add(r4);

          
            

            List<Ruta> ruta_g = new List<Ruta> { r, r2 };
            List<Ruta> ruta_g2 = new List<Ruta> { r4 };
            List<Ruta> ruta_g3 = new List<Ruta> { r3, r4 };
            List<Ruta> ruta_g4 = new List<Ruta> { r, r2, r3, r4 };
            List<Ruta> ruta_g5 = new List<Ruta> { };

            

            
            
            Guia g = new Guia("Pedro Rodriguez", "123456789A", "Español e inglés", "Fin de Semana", "666778899", "Pedro.Dominguez@gmail.com", "8,7", "/src/soldier.jpeg", ruta_g);
            Guia g1 = new Guia("Juan Pérez", "987654321B", "Español, inglés y francés", "Todos los días", "123456789", "Juan.Perez@gmail.com", "9,5", "/src/juan_perez.png", ruta_g3);
            Guia g2 = new Guia("Ana García", "123123456C", "Español y alemán", "Sólo fines de semana", "987654321", "Ana.Garcia@gmail.com", "7,2", "/src/mija.jpeg", ruta_g2);
            Guia g3 = new Guia("Pablo Martínez", "456456123D", "Español, italiano y portugués", "Todos los días", "456789123", "Pablo.Martinez@gmail.com", "8,9", "/src/brad_pitt.jpeg", ruta_g4);

            conguia.Add(g);
            conguia.Add(g1);
            conguia.Add(g2);
            conguia.Add(g3);

            r.Guia = g.Nombre;
            r2.Guia = g1.Nombre;
            r3.Guia = g2.Nombre;
            r4.Guia = g3.Nombre;

            Excursionista e = new Excursionista("Perico los palotes", "20", "666889444", "perico@gmail.com", "/src/alonso_rapido_y_furioso.png", ruta_g2);
            Excursionista e2 = new Excursionista("Ana Martínez", "25", "623456789", "ana@gmail.com", "", ruta_g);
            Excursionista e3 = new Excursionista("Pablo García", "23", "687654321", "pablo@gmail.com", "", ruta_g4);
            Excursionista e4 = new Excursionista("María Pérez", "40", "611145111", "maria@gmail.com", "/src/esposito.png", ruta_g3);
            Excursionista e5 = new Excursionista("Javier Rodríguez", "45", "622228522", "javier@gmail.com", "", ruta_g5);

            excursionistas.Add(e);
            excursionistas.Add(e2);
            excursionistas.Add(e3);
            excursionistas.Add(e4);
            excursionistas.Add(e5);


            for (int i = 0; i < conjunto.Count; i++)
            {
                list_view_rutas.Items.Add(conjunto[i].Nombre);
            }

            for (int i = 0; i < conguia.Count; i++)
            {
                list_view_guias.Items.Add(conguia[i].Nombre);
            }

            for (int i = 0; i < conjunto.Count; i++)
            {
                combo_ruta.Items.Add(conjunto[i].Nombre);
                combo_rutas_ex.Items.Add(conjunto[i].Nombre);
            }



            for (int i = 0; i < conguia.Count; i++)
            {
                combo_guias.Items.Add(conguia[i].Nombre);
            }

            for (int i = 0; i < excursionistas.Count; i++)
            {
                list_view_excu.Items.Add(excursionistas[i].Nombre);
            }

        }


        private void Rutas1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

            
            

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
            String guia = combo_guias.Text;
            String excursionistas = "";
            List<pdi> puntos = new List<pdi> { };
            bool isDigit = true;
             
            for (int i = 0; i < conjunto.Count; i++)
            {
                if (nombre.Equals(conjunto[i].Nombre))
                {
                    MessageBox.Show("Ya existe una ruta con ese nombre");
                    return;
                }
            }

            foreach (char c in n_box.Text)
            {
                if (!char.IsDigit(c))
                {
                    isDigit = false;
                    break;
                }
            }
          
            excursionistas = n_box.Text;

            String incluye = comida_box.Text;
            String precio = precio_box.Text;
            String material = mat_box.Text;
            String vuelta = vuelta_box.Text;
            String acceso = acceso_box.Text;
            String pdis = pdis_box.Text;
            if (isDigit)
            {
                if (int.Parse(excursionistas) >= 4 && int.Parse(excursionistas) <= 20)
                {
                    Ruta r = new Ruta(nombre, inicio, fin, duracion, fecha, hora, dificultad,
                        guia, excursionistas, incluye, precio, material, pdis, acceso, vuelta, puntos);
                    conjunto.Add(r);
                    combo_ruta.Items.Add(r.Nombre);
                    list_view_rutas.Items.Add(r.Nombre);
                    MessageBox.Show("Ruta añadida correctamente");
                }
            }
            else
            {
                MessageBox.Show("El número de excursionistas debe estar entre 4 y 20 y además deben ser números");
            }
            




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
                    combo_guias.Text = "";
                    n_box.Text = "";
                    comida_box.Text = "";
                    precio_box.Text = "";
                    mat_box.Text = "";
                    pdis_box.Text = "";
                    vuelta_box.Text = "";
                    acceso_box.Text = "";
                    list_view_rutas.Items.RemoveAt(i);
                    MessageBox.Show("Ruta eliminada correctamente");

                    break;
                }
            }
        }

        private void list_view_rutas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            nom_box_pdi.Text = "";
            desc_box_pdi.Text = "";
            tipo_box_pdi.Text = "";
            img_1.Source = null;
            img_2.Source = null;
            for (int i = 0; i < conjunto.Count; i++)
            {
                if (list_view_rutas.SelectedItem == null)
                {
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
                    combo_guias.Text = conjunto[i].Guia;
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
                if (list_view_rutas.SelectedItem == null)
                {
                    MessageBox.Show("No hay ninguna ruta seleccionada");
                    break;
                }
                if (list_view_rutas.SelectedItem.Equals(conjunto[i].Nombre))
                {

                    conjunto[i].Inicio = inicio_box.Text;
                    conjunto[i].Fin = fin_box.Text;
                    conjunto[i].Duracion = duracion_box.Text;
                    conjunto[i].Fecha = fecha_box1.Text;
                    conjunto[i].Hora = salida_box.Text;
                    conjunto[i].Dificultad = difi_box.Text;
                    conjunto[i].Guia = combo_guias.Text;
                    conjunto[i].N_excursionistas = n_box.Text;
                    conjunto[i].Comida_bebida = comida_box.Text;
                    conjunto[i].Precio = precio_box.Text;
                    conjunto[i].Material = mat_box.Text;
                    conjunto[i].Pdi = pdis_box.Text;
                    conjunto[i].Acceso_vuelta = vuelta_box.Text;
                    conjunto[i].Acceso_orig = acceso_box.Text;
                    if (!conjunto[i].Nombre.Equals(nombre_box.Text))
                    {
                        MessageBox.Show("No se puede cambiar el nombre.");
                        return;
                    }
                    MessageBox.Show("Ruta modificada correctamente");
                    break;





                }
            }
        }

        private void list_view_guias_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lista_rutas.Items.Clear();
            combo_ruta.IsEnabled = true;

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
                    {

                        if (!lista_rutas.Items.Contains(conguia[i].Rutas[j].Nombre))
                        {
                            lista_rutas.Items.Add(conguia[i].Rutas[j].Nombre);
                        }


                    }
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
            for (int i = 0; i < conguia.Count; i++)
            {
                if (nombre.Equals(conguia[i].Nombre))
                {
                    MessageBox.Show("Ya existe un/a guía con ese nombre");
                    return;
                }
            }
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Imágenes (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
            List<Ruta> rutas = new List<Ruta>();

            Guia g = new Guia(nombre, DNI, idiomas, dispo, tel, gmail, punt, "", rutas);

            if (openFileDialog.ShowDialog() == true)
            {
                // Obtiene la ruta de la imagen seleccionada en forma de cadena de caracteres
                string imagePath = openFileDialog.FileName;

                // Añade la ruta de la imagen al objeto aquí, por ejemplo, estableciendo la propiedad de ruta de imagen del objeto en la ruta de la imagen
                g.Perfil = imagePath;
            }


            conguia.Add(g);
            list_view_guias.Items.Add(g.Nombre);
            MessageBox.Show("Guía añadida correctamente");

        }

        private void btn_borrarguia_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < conguia.Count; i++)
            {
                
                if (list_view_guias.SelectedItem.Equals(conguia[i].Nombre))
                {
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
                    MessageBox.Show("Guía borrada correctamente");
                    break;
                }



            }
        }

        private void btn_modificarguia_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < conguia.Count; i++)
            {
                if (list_view_guias.SelectedItem == null)
                {
                    MessageBox.Show("No hay guías seleccionadas");
                    break;
                }

                if (list_view_guias.SelectedItem.Equals(conguia[i].Nombre))
                {
                    conguia[i].Dni = guia_dni_box.Text;
                    conguia[i].Idiomas = guia_idioma_box.Text;
                    conguia[i].Disponibilidad = guia_dispo_box.Text;
                    conguia[i].Telefono = guia_tel_box.Text;
                    conguia[i].Email = guia_gmail_box.Text;
                    conguia[i].Puntuacion = guia_punt_box.Text;
                    if (!conguia[i].Nombre.Equals(guia_nombre_box.Text))
                    {
                        MessageBox.Show("No se puede cambiar el nombre.");
                        return;
                    }

                    MessageBox.Show("Guía modificada correctamente");

                    break;
                }
            }

        }

        private void lista_rutas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            for (int i = 0; i < conjunto.Count; i++)
            {
                if (lista_rutas.SelectedItem == null)
                {
                    break;
                }
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

        private void anadir_ruta_Click(object sender, RoutedEventArgs e)
        {


        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            for (int i = 0; i < conguia.Count; i++)
            {
                if (list_view_guias.SelectedItem.Equals(conguia[i].Nombre))
                {

                    for (int j = 0; j < conjunto.Count; j++)
                    {
                        if (combo_ruta.SelectedItem.Equals(conjunto[j].Nombre))
                        {
                            conguia[i].Rutas.Add(conjunto[j]);
                            lista_rutas.Items.Add(conjunto[j].Nombre);
                            break;
                        }
                    }

                }



            }
        }

        private void btn_ir_guia_Click(object sender, RoutedEventArgs e)
        {
            if (combo_guias.Text == "")
            {
                MessageBox.Show("No hay guía seleccionado.");
                return;
            }
            for (int i = 0; i < conguia.Count; i++)
            {
               
                if (combo_guias.Text.Equals(conguia[i].Nombre))
                {

                    list_view_guias.SelectedItem = conguia[i].Nombre;
                    tab_control.SelectedIndex = 1;
                    break;

                }

            }

        }

        private void btn_ayuda_ex_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Estás en la ventana de excursionistas, además de consultar la información, aquí podrás añadir, modificar y borrar excursionistas. Para añadir un excursionista, rellena los campos y pulsa el botón añadir. Para modificar un excursionista, selecciona un excursionista de la lista y modifica los campos que quieras. Para borrar un excursionista, selecciona un excursionista de la lista y pulsa el botón borrar. La foto para los excursionistas no es obligatoria.");

        }

        private void list_view_excu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            list_rut_ex.Items.Clear();
            combo_rutas_ex.IsEnabled = true;
            for (int i = 0; i < excursionistas.Count; i++)
            {
                if (list_view_excu.SelectedItem == null)
                {
                    break;
                }
                if (list_view_excu.SelectedItem.Equals(excursionistas[i].Nombre))
                {

                    nombre_box_ex.Text = excursionistas[i].Nombre;
                    edad_box.Text = excursionistas[i].Edad;
                    tel_box.Text = excursionistas[i].Telefono;
                    email_box.Text = excursionistas[i].Email;
                    for (int j = 0; j < excursionistas[i].Rutas.Count; j++)
                    {

                        if (!list_rut_ex.Items.Contains(excursionistas[i].Rutas[j].Nombre))
                        {
                            list_rut_ex.Items.Add(excursionistas[i].Rutas[j].Nombre);
                        }


                    }
                    foto_exc.Source = new BitmapImage(new Uri(excursionistas[i].Ruta_foto, UriKind.RelativeOrAbsolute));
                    break;

                }

            }
        }

        private void combo_rutas_ex_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            for (int i = 0; i < excursionistas.Count; i++)
            {
                if (list_view_excu.SelectedItem.Equals(excursionistas[i].Nombre))
                {

                    for (int j = 0; j < conjunto.Count; j++)
                    {
                        if (combo_rutas_ex.SelectedItem.Equals(conjunto[j].Nombre))
                        {
                            int n_ex = int.Parse(conjunto[j].N_excursionistas);
                            n_ex++;
                            conjunto[j].N_excursionistas = n_ex.ToString();
                            if (int.Parse(conjunto[j].N_excursionistas) < 20)
                            {
                                excursionistas[i].Rutas.Add(conjunto[j]);
                                list_rut_ex.Items.Add(conjunto[j].Nombre);
                            }
                            else
                            {
                                MessageBox.Show("Esta ruta ya tiene 20 excursionistas");
                            }
                            break;
                        }
                    }

                }



            }
        }

        private void btn_anadir_ex_Click(object sender, RoutedEventArgs e)
        {
           
            String nombre = nombre_box_ex.Text;
            String edad = edad_box.Text;
            String tel = tel_box.Text;
            String gmail = email_box.Text;
            for (int i = 0; i < excursionistas.Count; i++)
            {
                if (nombre.Equals(excursionistas[i].Nombre))
                {
                    MessageBox.Show("Ya existe un/a excursionista con ese nombre");
                    return;
                }
            }
            Excursionista ex = null;
            List<Ruta> rutas = new List<Ruta>();

            MessageBoxResult result = MessageBox.Show("¿Quieres añadir una foto?", "Confirmación", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {

                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Imágenes (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() == true)
                {
                    // Obtiene la ruta de la imagen seleccionada en forma de cadena de caracteres
                    string imagePath = openFileDialog.FileName;
                    ex = new Excursionista(nombre, edad, tel, gmail, imagePath, rutas);
                }
            }
            else
            {
                 ex = new Excursionista(nombre, edad, tel, gmail, "", rutas);
            }


            // Añade la ruta de la imagen al objeto aquí, por ejemplo, estableciendo la propiedad de ruta de imagen del objeto en la ruta de la imagen

            
            excursionistas.Add(ex);
            list_view_excu.Items.Add(ex.Nombre);
            MessageBox.Show("Excursionista añadido correctamente");

        }

        private void btn_borrar_ex_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < excursionistas.Count; i++)
            {
                if (list_view_excu.SelectedItem.Equals(excursionistas[i].Nombre))
                {
                    excursionistas.RemoveAt(i);
                    nombre_box_ex.Text = "";
                    edad_box.Text = "";
                    tel_box.Text = "";
                    email_box.Text = "";       
                    foto_exc.Source = null;
                    list_rut_ex.Items.Clear();
                    list_view_excu.Items.RemoveAt(i);
                    MessageBox.Show("Excursionista borrado correctamente");
                    break;
                }



            }
        }

        private void btn_modi_ex_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < excursionistas.Count; i++)
            {
                if (list_view_excu.SelectedItem == null)
                {
                    MessageBox.Show("No hay excursionista seleccionado/a");
                    break;
                }

                if (list_view_excu.SelectedItem.Equals(excursionistas[i].Nombre))
                {
                    excursionistas[i].Edad = edad_box.Text;
                    excursionistas[i].Email = email_box.Text;
                    excursionistas[i].Telefono = tel_box.Text;
                    if (!excursionistas[i].Nombre.Equals(nombre_box_ex.Text))
                    {
                        MessageBox.Show("No se puede cambiar el nombre.");
                        return;
                    }
                    MessageBox.Show("Excursionista modificado correctamente");

                    break;
                }
            }
        }

        private void list_rut_ex_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            for (int i = 0; i < conjunto.Count; i++)
            {
                if (list_rut_ex.SelectedItem == null)
                {
                    break;
                }
                if (list_rut_ex.SelectedItem.Equals(conjunto[i].Nombre))
                {

                    list_view_rutas.SelectedItem = conjunto[i].Nombre;
                    tab_control.SelectedIndex = 0;
                    break;

                }

            }

        }

        private void btn_ir_pdi_Click(object sender, RoutedEventArgs e)
        {
            
            int cont = 0;
            list_view_pdis.Items.Clear();
            for (int i = 0; i < conjunto.Count; i++)
            {
                if (list_view_rutas.SelectedItem == null)
                {
                    break;
                }
                if (list_view_rutas.SelectedItem.Equals(conjunto[i].Nombre))
                {
                    
                    for (int j = 0; conjunto[i].Pdis != null && j < conjunto[i].Pdis.Count; j++)
                    {
                        
                            list_view_pdis.Items.Add(conjunto[i].Pdis[j].Nombre);
                            cont++;
                        
                    }
                    
                }
                
            }
            if (cont <= 0)
            {
                MessageBox.Show("Esta ruta no tiene puntos de interés");
            }
           
            else {
                pdis_tab_item.IsEnabled = true;
                tab_control.SelectedIndex = 3;
            }
            



        }

        private void pdis_tab_item_LostFocus(object sender, RoutedEventArgs e)
        {
            pdis_tab_item.IsEnabled = false;
            /*nom_box_pdi.Text = "";
            desc_box_pdi.Text = "";
            tipo_box_pdi.Text = "";
            img_1.Source = null;
            img_2.Source = null;*/
        }

        private void list_view_pdis_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            
            for (int i = 0; i < pdis.Count; i++)
            {
                if (list_view_pdis.SelectedItem == null)
                {
                    break;
                }
                if (list_view_pdis.SelectedItem.Equals(pdis[i].Nombre))
                {

                    nom_box_pdi.Text = pdis[i].Nombre;
                    desc_box_pdi.Text = pdis[i].Descripcion;
                    tipo_box_pdi.Text = pdis[i].Tipologia;
                    img_1.Source = new BitmapImage(new Uri(pdis[i].GaleriaImagenes[0], UriKind.RelativeOrAbsolute));
                    img_2.Source = new BitmapImage(new Uri(pdis[i].GaleriaImagenes[1], UriKind.RelativeOrAbsolute));
                    break;

                }

            }

        }

        private void btn_anadir_pdi_Click(object sender, RoutedEventArgs e)
        {
            String nombre = nom_box_pdi.Text;
            String desc = desc_box_pdi.Text;
            String tipo = tipo_box_pdi.Text;

            List<String> st = new List<string>();
            List<OpenFileDialog> op = new List<OpenFileDialog>();
            pdi pd = new pdi(nombre, desc, tipo,st);
            OpenFileDialog openFileDialog = new OpenFileDialog();
            OpenFileDialog openFileDialog2 = new OpenFileDialog();

            for (int i = 0; i < pdis.Count; i++)
            {
                if (nombre.Equals(pdis[i].Nombre))
                {
                    MessageBox.Show("Ya existe un punto de interés con ese nombre");
                    return;
                }
            }
            
            if (openFileDialog.ShowDialog() == true && openFileDialog2.ShowDialog() == true)
            {
                pd.GaleriaImagenes.Add(openFileDialog.FileName);
                pd.GaleriaImagenes.Add(openFileDialog2.FileName);
                pdis.Add(pd);
                list_view_pdis.Items.Add(pd.Nombre);
                for (int i = 0; i < conjunto.Count; i++)
                {
                    if (list_view_rutas.SelectedItem == null)
                    {
                        break;
                    }
                    if (list_view_rutas.SelectedItem.Equals(conjunto[i].Nombre))
                    {
                        conjunto[i].Pdis.Add(pd);
                        conjunto[i].Pdi = conjunto[i].Pdis.Count().ToString();
                        break;
                    }
                }
                MessageBox.Show("Punto de interés añadido correctamente");
            }
            else
            {
                MessageBox.Show("No se ha podido añadir el punto de interés");
            }
            nom_box_pdi.Text = "";
            desc_box_pdi.Text = "";
            tipo_box_pdi.Text = "";
            
        }

        private void pdis_help_btn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Estás en la ventana de Puntos de Interés. Aquí podrás consultar los puntos de interés de una ruta específica, así como añadir un punto a esta ruta.");
        }

        private void btn_cerrar_perf_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("¿Seguro que quieres cerrar la sesión?", "Confirmación", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                MainWindow w = new MainWindow();
                this.Hide();
                w.ShowDialog();
                this.Close();



            }
        }

        private void btn_cerrar_guias_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("¿Seguro que quieres cerrar la sesión?", "Confirmación", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                MainWindow w = new MainWindow();
                this.Hide();
                w.ShowDialog();
                this.Close();



            }

        }

        private void btn_cerrar_ex_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("¿Seguro que quieres cerrar la sesión?", "Confirmación", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                MainWindow w = new MainWindow();
                this.Hide();
                w.ShowDialog();
                this.Close();



            }
        }

        private void btn_cerrrar_pdis_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("¿Seguro que quieres cerrar la sesión?", "Confirmación", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                MainWindow w = new MainWindow();
                this.Hide();
                w.ShowDialog();
                this.Close();



            }
        }

       
    }
}

    

