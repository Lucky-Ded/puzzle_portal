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
using System.Windows.Shapes;

namespace курсовая
{
    /// <summary>
    /// Логика взаимодействия для menu.xaml
    /// </summary>
    public partial class menu : Window
    {
        public menu()
        {
            InitializeComponent();
        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            
            this.Close();
        }

        private void B3_Click(object sender, RoutedEventArgs e)
        {
            Window game = new game();
            game.Show();
            this.Close();
        }

        private void B4_Click(object sender, RoutedEventArgs e)
        {
            Window options = new options();
            options.Show();
            this.Close();
        }

        private void B5_Click(object sender, RoutedEventArgs e)
        {
            Window result = new result();
            result.Show();
            this.Close();
        }
    }
}
