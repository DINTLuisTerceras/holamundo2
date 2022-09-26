using System.Windows;
using System.Windows.Controls;

namespace holamundo
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void saludarButton_Click(object sender, RoutedEventArgs e)
        {
            nombreLabel.Content = "Hola " + nombreTextBox.Text + "!";
        }
    }
}
