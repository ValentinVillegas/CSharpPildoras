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

namespace PrimeraInterfaz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            /*
            Grid miGrid = new Grid();
            this.Content = miGrid;

            Button miBoton = new Button();
            
            WrapPanel miWrap = new WrapPanel();

            TextBlock txt1 = new TextBlock();
            txt1.Text = "Hola ";
            txt1.Foreground = Brushes.Green;
            miWrap.Children.Add(txt1);

            TextBlock txt2 = new TextBlock();
            txt2.Text = "Clic ";
            txt2.Foreground = Brushes.White;
            miWrap.Children.Add(txt2);

            TextBlock txt3 = new TextBlock();
            txt3.Text = "Enviar";
            txt3.Foreground = Brushes.Red;

            miWrap.Children.Add(txt3);

            miBoton.Content = miWrap;
            miBoton.Width = 150;
            miBoton.Height = 50;

            miGrid.Children.Add(miBoton);
            */
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Haz echo clic en el botón");
        }

        private void Panel_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Haz echo clic en el panel");
        }
    }
}