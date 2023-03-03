using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Proyecto
{
    public partial class MainWindow : Window
    {
        Login login= new Login(); //Captura para mandar a la otra ventana

       

        public MainWindow() // metodo de carga inicializada
        {
            InitializeComponent();
           
            var thread = new Thread(new ThreadStart(() =>
            {
                Thread.Sleep(15000);
                this.Dispatcher.Invoke(() =>
                {
                    this.Close();
                    login.Show(); //muestra la ventana de logeo

                });
            }));
            thread.Start(); //Comienzo de encabezado

        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
    }
}
