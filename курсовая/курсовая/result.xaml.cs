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
    /// Логика взаимодействия для result.xaml
    /// </summary>
    public partial class result : Window
    {
        Dictionary<string, DateTime> dlist = new Dictionary<string, DateTime>();
        public result()
        {
            InitializeComponent();
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.FileName = "date";
            dlg.DefaultExt = ".txt";
            dlg.Filter = "Text documents (.txt)|*.txt";
            dlg.ShowDialog();
            list.Items.Clear();
            dlist.Clear();
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(dlg.FileName);
            while ((line = file.ReadLine()) != null)
            {
                string name = line;
                line = file.ReadLine();
                if (line == null) break;
                DateTime dt = DateTime.Parse(line);
                list.Items.Add(name);
                dlist.Add(name, dt);
            }
            file.Close();
        }

        private void B7_Click(object sender, RoutedEventArgs e)
        {
            Window menu = new menu();
            menu.Show();
            this.Close();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


        }
    }
}
