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

namespace MyFirstDesktopApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Textbox2.Text = Textbox1.Text;
            Textbox1.Text = "Ввод закончен";
                     
            Textbox1.Width = 100;
            Textbox2.BorderBrush = Brushes.Green;
            Textbox1.BorderBrush = Brushes.Red;
            //Textbox1.Text = "";
        }
                private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Textbox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
