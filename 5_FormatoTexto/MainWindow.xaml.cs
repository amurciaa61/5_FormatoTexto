using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
            RadioButton rb = (RadioButton)sender;
            
            //switch (rb.Name)
            //{
            //    case "azulRadioButton":
            //        textoOutputTextBlock.Foreground = Brushes.Red;
            //        break;
            //    case "rojoRadioButton":
            //        textoOutputTextBlock.Foreground = Brushes.Red;
            //        break;
            //    case "verdeRadioButton":
            //        textoOutputTextBlock.Foreground = Brushes.Green;
            //        break;
            //    default:
            //        break;
            //}

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
