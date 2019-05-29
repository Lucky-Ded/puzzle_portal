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
using System.IO;

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
            FileStream file1 = new FileStream(@"C:\ri87\git курсовая1\курсовая\date1.txt", FileMode.Open); //создаем файловый поток 
            StreamReader reader = new StreamReader(file1); // создаем «потоковый читатель» и связываем его с файловым потоком 
            list.Items.Add(reader.ReadToEnd()); //считываем все данные с потока и выводим на экран

        }

        private void B7_Click(object sender, RoutedEventArgs e)
        {
            Window menu = new menu();
            menu.Show();
            this.Close();
        }

       
    }
}
