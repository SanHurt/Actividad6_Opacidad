
using System.Windows;
using System.Windows.Input;

namespace Actividad6_Opacidad
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            imagen1Image.Opacity = 0.5;
            imagen2Image.Opacity = 0.5;
            imagen3Image.Opacity = 0.5;
        }

        private void imagen1Image_MouseEnter(object sender, MouseEventArgs e)
        {
            imagen1Image.Opacity = 0.9;
        }

        private void imagen2Image_MouseEnter(object sender, MouseEventArgs e)
        {
            imagen2Image.Opacity = 0.9;
        }

        private void imagen3Image_MouseEnter(object sender, MouseEventArgs e)
        {
            imagen3Image.Opacity = 0.9;
        }

        private void imagen3Image_MouseLeave(object sender, MouseEventArgs e)
        {
            imagen3Image.Opacity = 0.5;
        }

        private void imagen2Image_MouseLeave(object sender, MouseEventArgs e)
        {
            imagen2Image.Opacity = 0.5;
        }

        private void imagen1Image_MouseLeave(object sender, MouseEventArgs e)
        {
            imagen1Image.Opacity = 0.5;
        }
    }
}
