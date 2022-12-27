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

namespace Senderify.src
{
    /// <summary>
    /// Lógica de interacción para Perfil.xaml
    /// </summary>
    public partial class Perfil : Window
    {
       
        
        public Perfil()
        {
            InitializeComponent();

            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            

        }



            private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            

            
             
        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void btn_next_Click(object sender, RoutedEventArgs e)
        {
            Rutas rutas = new Rutas();
            rutas.Visibility = Visibility.Visible;
            this.Visibility = Visibility.Hidden;
            this.Close();
            Ruta r = new Ruta("La Hermosa","Ciudad Real","Daimiel","4 horas","30Km","22/09/2022","18:00","Normal","Pedro Campos","10","No incluídas","10euros","Botas de Hiking","Muchos","Bus","Bus" );
            rutas.list_view_rutas.Items.Add(r.Nombre);

        }
    }
}
