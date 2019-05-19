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
    /// Логика взаимодействия для game.xaml
    /// </summary>
    public partial class game : Window
    {
       
        public game()
        {
           InitializeComponent();
        }

        private void B8_Click(object sender, RoutedEventArgs e)
        {
            Window menu = new menu();
            menu.Show();
            this.Close();
        }

        

        private void Bim1_Click(object sender, RoutedEventArgs e)
        {
            
            Window1 window1 = new Window1();
            
            window1.Nomer = 1;
            window1.Show();
            this.Close();
            

        }

        public void Bim2_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
          window1.Nomer = 2;
            window1.Show();
            this.Close();
        }

        public void Bim3_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
           // window1.Chosen = 1;
            window1.Show();
            this.Close();
        }

    }
}
