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

namespace proj1
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

        private void btnFalus_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Neřešitelny problem hoši.", 
                "Problem", MessageBoxButton.YesNo, MessageBoxImage.Exclamation) == MessageBoxResult.Yes)
            {
                MessageBox.Show(new TextRange(textBox.Document.ContentStart,textBox.Document.ContentEnd).Text);
            }
            else
            {
                MessageBox.Show("Ta nedobre");
            }
        }

    }
}
