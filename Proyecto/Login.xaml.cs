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

namespace Proyecto
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        pantalla_de_informacion info= new pantalla_de_informacion();
        public Login()
        {
            InitializeComponent();
            img_error.Visibility = Visibility.Hidden;
        }

        
        private void movible_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void btn_minimizar_Click(object sender, RoutedEventArgs e)
        {

            this.Close();
        }

        private void minimizar_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            String usuario = txtusername.Text.ToString();
            String password= txtpassword.Text.ToString();
            if (usuario.Equals("usuario") && password.Equals("root")) 
            {
                info.Show();
                this.Close();
            }
            else
            {
                img_error.Visibility= Visibility.Visible;
            }
        }
    }
}
