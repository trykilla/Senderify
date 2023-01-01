using Senderify.src;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Senderify
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        protected List<string> users = new List<string>()
                    {
                        "Hector",
                        "Ruben",
                    };
        protected List<string> passwords = new List<string>()
                    {
                        "1234",
                        "4321",
                    };
        protected List<string> names = new List<string>()
                    {
                        "Hector Alberca",
                        "Ruben Crespo",
                    };
        protected List<string> fecha = new List<string>()
                    {
                        "19/02/2002",
                        "11/12/2002",
                    };
        protected List<string> edades = new List<string>()
                    {
                        "20",
                        "20",
                    };
        protected List<string> dnis = new List<string>()
                    {
                        "06298732K",
                        "20616361N",
                    };
        protected List<string> residencias = new List<string>()
                    {
                        "Campo de Criptana",
                        "Villarubia de los Ojos",
                    };
        protected List<string> ultimo = new List<string>()
                    {
                        "19/02/2022",
                        "22/10/2021",
                    };
        protected List<string> tlfs = new List<string>()
                    {
                        "675424124",
                        "666777444",
                    };
        protected List<string> emails = new List<string>()
                    {
                        "hector.alberca@alu.uclm.es",
                        "ruben.crespo3@alu.uclm.es",
        };

        public MainWindow()
        {
            InitializeComponent();

        }

        public List<string> getUsers()
        {
            return this.users;
        }



            private void user_box_MouseEnter(object sender, MouseEventArgs e)
        {
            if (user_box.Text == "Introduzca el usuario...")
            {
                user_box.Text = "";
            }
        }

        private void pass_box_MouseEnter(object sender, MouseEventArgs e)
        {
            if (pass_box.Text == "Introduzca la contraseña...")
            {
                pass_box.Text = "";
            }
        }

        private void pass_box_MouseLeave(object sender, MouseEventArgs e)
        {
            if (pass_box.Text == "")
            {
                pass_box.Text = "Introduzca la contraseña...";
            }
        }

        private void user_box_MouseLeave(object sender, MouseEventArgs e)
        {
            if (user_box.Text == "")
            {
                user_box.Text = "Introduzca el usuario...";
            }
        }

        private void user_box_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (user_box.Text == "Introduzca el usuario...")
            {
                user_box.Text = "";
                user_box.Foreground = Brushes.Black;
            }
            if (e.Key == Key.Enter)
            {
                for (int i = 0; i < users.Count; i++)
                {
                    if (ComprobarEntrada(user_box.Text, users[i],user_box))
                    {
                        pass_box.IsEnabled = true;
                        pass_box.Focus();
                        break;
                    }

                }
            }
        }

        private Boolean ComprobarEntrada(string valorIntroducido, string valorValido,
            Control componenteEntrada)
        {
            bool valido = false;
            if (valorIntroducido.Equals(valorValido))
            {
                // borde y background en verde
                componenteEntrada.BorderBrush = Brushes.Green;
                componenteEntrada.Background = Brushes.LightGreen;
                // imagen al lado de la entrada de usuario --> 
                valido = true;
            }
            else
            {
                // marcamos borde en rojo
                componenteEntrada.BorderBrush = Brushes.Red;
                componenteEntrada.Background = Brushes.LightCoral;
                // imagen al lado de la entrada de usuario --> 
                valido = false;
            }
            return valido;
        }

        private void pass_box_KeyDown(object sender, KeyEventArgs e)
        {
            if (pass_box.Text == "Introduzca la contraseña...")
            {
                pass_box.Text = "";
                pass_box.Foreground = Brushes.Black;

            }
        }

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < passwords.Count; i++)
            {
                if (ComprobarEntrada(pass_box.Text, passwords[i], pass_box) && ComprobarEntrada(user_box.Text, users[i], user_box))
                {
                    Perfil p = new Perfil();
                    p.Visibility = Visibility.Visible;
                    this.Visibility = Visibility.Hidden;
                    this.Close();

                    p.lista_datos.Items.Add("Nombre: "+names[i]);
                    p.lista_datos.Items.Add("Fecha de nacimiento: "+fecha[i]);
                    p.lista_datos.Items.Add("Edad: " + edades[i]);
                    p.lista_datos.Items.Add("DNI: " + dnis[i]);
                    p.lista_datos.Items.Add("Residencia: " + residencias[i]);
                    p.lista_datos.Items.Add("Última conexión: " + ultimo[i]);
                    p.lista_datos.Items.Add("Teléfono: " + tlfs[i]);
                    p.lista_datos.Items.Add("Email: " + emails[i]);
                    if (i == 0)
                    {
                        p.img_perfil_hec.Visibility = Visibility.Visible;
                    } else
                    {
                        p.img_perfil_rub.Visibility = Visibility.Visible;
                    }



                    break;
                    
                }
                

            }
        }

        private void main_helpbutton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Has seleccionado la opción ayuda \n En esta ventana debes introducir el login, con el usuario y contraseña correctos.");
        }

        private void btn_login_MouseEnter(object sender, MouseEventArgs e)
        {
            btn_login.Foreground = Brushes.Black;
        }

        private void btn_login_MouseLeave(object sender, MouseEventArgs e)
        {
            btn_login.Foreground = Brushes.White;
        }

        private void user_box_TextChanged(object sender, TextChangedEventArgs e)
        {
            user_box.Foreground = Brushes.Black;
        }

        private void pass_box_TextChanged(object sender, TextChangedEventArgs e)
        {
            pass_box.Foreground = Brushes.Black;
        }

        private void Sendirify_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }
    }
}
