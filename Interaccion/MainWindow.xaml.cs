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

namespace Interaccion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            

            btnBoton.Click += BtnBoton_Click;
        }

        private void BtnBoton_Click(object sender, RoutedEventArgs e)
        {
            lblHolaMundo.Text = "Adios Mundo";
            lblHolaMundo.FontSize = 29;
            lblHolaMundo.Foreground = Brushes.Red;
        }

        private void BtnBoton2_Click(object sender, RoutedEventArgs e)
        {
            lblHolaMundo.Text = "Surprise";
            lblHolaMundo.FontSize = 29;
            lblHolaMundo.Foreground = Brushes.HotPink;
        }

        private void BtnBoton3_Click(object sender, RoutedEventArgs e)
        {
            lblHolaMundo.Text = ":3";
            lblHolaMundo.FontSize = 29;
            lblHolaMundo.Foreground = Brushes.BlueViolet;

        }
    }
}
