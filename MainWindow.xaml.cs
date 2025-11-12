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

namespace WpfApp4Login1P2C
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

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            txtBResultado.Text = lblNombre.Content.ToString() + txtNombre.Text + "\n"
                + lblEmail.Content.ToString() + txtEmail.Text + "\n"
                + lblPassword.Content.ToString() + pwdBContra.Password;
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            txtNombre.Text = "";
            txtEmail.Text = string.Empty;
            pwdBContra.Password = string.Empty;
            txtBResultado.Text = string.Empty;
        }
    }
}
