using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Ejercicio6_Opacidad
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

        private void Imagen_Image_MouseEnter(object sender, MouseEventArgs e)
        {
            (sender as Image).Opacity = 1;
        }

        private void Imagen_Image_MouseLeave(object sender, MouseEventArgs e)
        {
            (sender as Image).Opacity = 0.5;
        }
    }
}
