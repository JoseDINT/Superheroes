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

namespace Superheroes
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();






        }

        private void AdelanteImagen_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            int contador = int.Parse(PosicionTextBlock.Text);
            int limiteMax = int.Parse(LimiteMáximoTextBlock.Text);
            if (contador < limiteMax)
            {
                contador++;
                PosicionTextBlock.Text = contador.ToString();
            }
        }

        private void AtrasImagen_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            int contador = int.Parse(PosicionTextBlock.Text);
            if (contador > 1)
            {
                contador--;
                PosicionTextBlock.Text = contador.ToString();
            }

        }
    }
}
