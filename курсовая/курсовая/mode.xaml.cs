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
    /// Логика взаимодействия для mode.xaml
    /// </summary>
    public partial class mode : Window
    {
        public mode()
        {
            InitializeComponent();
        }

        private void B12_Click(object sender, RoutedEventArgs e)
        {
            Window game = new game();
            game.Show();
            this.Close();
        }

        private void B10_Click(object sender, RoutedEventArgs e)
        {
            Window svoboda = new svoboda();
            svoboda.Show();
            this.Close();
        }

        private void B11_Click(object sender, RoutedEventArgs e)
        {
            Window time = new time();
            time.Show();
            this.Close();
        }
    }
}
