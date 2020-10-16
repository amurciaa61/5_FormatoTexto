using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace _5_FormatoTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            azulRadioButton.IsChecked = true;
        }

        private void negritaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            textoOutputTextBlock.FontWeight = FontWeights.Bold;
        }

        private void negritaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            textoOutputTextBlock.FontWeight = FontWeights.Normal;
        }


        private void textoInputTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            textoOutputTextBlock.Text = textoInputTextBox.Text;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            string col = (sender as RadioButton).Tag.ToString();
            textoOutputTextBlock.Foreground = (Brush)new BrushConverter().ConvertFromString(col);
        }

        private void cursivaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            textoOutputTextBlock.FontStyle = FontStyles.Italic;
        }

        private void cursivaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            textoOutputTextBlock.FontStyle = FontStyles.Normal;
        }
    }
}
