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

        }

        private void perf_helpbutt_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Has seleccionado el botón de ayuda.\nEstás en la ventana de perfil, donde podrás visualizar " +
                "las cualidades del administrador que haya iniciado sesión en el login.\nPara avanzar a la siguiente ventana pulse la flecha");
        }

        private void btn_cerrar_perf_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("¿Seguro que quieres cerrar la sesión?", "Confirmación", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                MainWindow w = new MainWindow();
                w.Visibility = Visibility.Visible;
                this.Close();


            }
        }
    }
}
