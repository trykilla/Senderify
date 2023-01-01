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
    /// Lógica de interacción para pdis.xaml
    /// </summary>
    public partial class pdis : Window
    {
        Rutas r = new Rutas();
        public pdis(Rutas r)
        {
            InitializeComponent();
            this.r = r;
        }
        
        

        private void pdis1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            this.r.ShowDialog();
            this.Close();
            

        }
    }
}
