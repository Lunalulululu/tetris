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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ImageSource[] titleImages = new ImageSource[]
        {
            new BitmapImage(new Uri("Assets"))
        }
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_KeyDown(object sender, KeyEventArgs e)
        { 
        
        }

        private void GameCanvas_Loaded(object sender, RoutedEventArgs e)
        { 
        
        }
    }
}
