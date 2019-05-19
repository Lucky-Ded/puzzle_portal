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
            Rectangle myRect = new Rectangle();
            ImageBrush ub = new ImageBrush();
            //установка цвета линии обводки и цвета заливки при помощи коллекции кистей
            myRect.Stroke = Brushes.Black;
            //myRect.Fill = Brushes.SkyBlue;
            //РАСКОММЕНТИТЬ
            ub.AlignmentX = AlignmentX.Left;
            ub.AlignmentY = AlignmentY.Top;
            ub.ImageSource = new BitmapImage(new Uri(@"pack://application:,,,/Puzle/for game/ozero.jpg", UriKind.Absolute));
            myRect.Fill = ub;
            //параметры выравнивания
            myRect.HorizontalAlignment = HorizontalAlignment.Left;
            myRect.VerticalAlignment = VerticalAlignment.Center;
            //размеры прямоугольника
            myRect.Height = 230;
            myRect.Width = 400;
            myRect.Margin = new Thickness(1, 0, 0, 0);
            //добавление объекта в сцену
            window1.pokaz.Children.Add(myRect);
            this.Close();


        }

        public void Bim2_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
          window1.Nomer = 2;
            Rectangle myRect = new Rectangle();
            ImageBrush ub = new ImageBrush();
            //установка цвета линии обводки и цвета заливки при помощи коллекции кистей
            myRect.Stroke = Brushes.Black;
            //myRect.Fill = Brushes.SkyBlue;
            //РАСКОММЕНТИТЬ
            ub.AlignmentX = AlignmentX.Left;
            ub.AlignmentY = AlignmentY.Top;
            ub.ImageSource = new BitmapImage(new Uri(@"pack://application:,,,/Puzle/for game/gtr.jpg", UriKind.Absolute));
            myRect.Fill = ub;
            //параметры выравнивания
            myRect.HorizontalAlignment = HorizontalAlignment.Left;
            myRect.VerticalAlignment = VerticalAlignment.Center;
            //размеры прямоугольника
            myRect.Height = 230;
            myRect.Width = 400;
            myRect.Margin = new Thickness(1, 0, 0, 0);
            //добавление объекта в сцену
            window1.pokaz.Children.Add(myRect);
            window1.Show();
            this.Close();
        }

        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();

            window1.Nomer = 3;
            Rectangle myRect = new Rectangle();
            ImageBrush ub = new ImageBrush();
            //установка цвета линии обводки и цвета заливки при помощи коллекции кистей
            myRect.Stroke = Brushes.Black;
            //myRect.Fill = Brushes.SkyBlue;
            //РАСКОММЕНТИТЬ
            ub.AlignmentX = AlignmentX.Left;
            ub.AlignmentY = AlignmentY.Top;
            ub.ImageSource = new BitmapImage(new Uri(@"pack://application:,,,/Puzle/for game/lamba.jpg", UriKind.Absolute));
            myRect.Fill = ub;
            //параметры выравнивания
            myRect.HorizontalAlignment = HorizontalAlignment.Left;
            myRect.VerticalAlignment = VerticalAlignment.Center;
            //размеры прямоугольника
            myRect.Height = 230;
            myRect.Width = 400;
            myRect.Margin = new Thickness(1, 0, 0, 0);
            //добавление объекта в сцену
            window1.pokaz.Children.Add(myRect);
            window1.Show();
            this.Close();

        }

        private void First_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();

            window1.Nomer = 4;
            Rectangle myRect = new Rectangle();
            ImageBrush ub = new ImageBrush();
            //установка цвета линии обводки и цвета заливки при помощи коллекции кистей
            myRect.Stroke = Brushes.Black;
            //myRect.Fill = Brushes.SkyBlue;
            //РАСКОММЕНТИТЬ
            ub.AlignmentX = AlignmentX.Left;
            ub.AlignmentY = AlignmentY.Top;
            ub.ImageSource = new BitmapImage(new Uri(@"pack://application:,,,/Puzle/for game/leopard.jpg", UriKind.Absolute));
            myRect.Fill = ub;
            //параметры выравнивания
            myRect.HorizontalAlignment = HorizontalAlignment.Left;
            myRect.VerticalAlignment = VerticalAlignment.Center;
            //размеры прямоугольника
            myRect.Height = 230;
            myRect.Width = 400;
            myRect.Margin = new Thickness(1, 0, 0, 0);
            //добавление объекта в сцену
            window1.pokaz.Children.Add(myRect);
            window1.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();

            window1.Nomer = 5;
            Rectangle myRect = new Rectangle();
            ImageBrush ub = new ImageBrush();
            //установка цвета линии обводки и цвета заливки при помощи коллекции кистей
            myRect.Stroke = Brushes.Black;
            //myRect.Fill = Brushes.SkyBlue;
            //РАСКОММЕНТИТЬ
            ub.AlignmentX = AlignmentX.Left;
            ub.AlignmentY = AlignmentY.Top;
            ub.ImageSource = new BitmapImage(new Uri(@"pack://application:,,,/Puzle/for game/most.jpg", UriKind.Absolute));
            myRect.Fill = ub;
            //параметры выравнивания
            myRect.HorizontalAlignment = HorizontalAlignment.Left;
            myRect.VerticalAlignment = VerticalAlignment.Center;
            //размеры прямоугольника
            myRect.Height = 230;
            myRect.Width = 400;
            myRect.Margin = new Thickness(1, 0, 0, 0);
            //добавление объекта в сцену
            window1.pokaz.Children.Add(myRect);
            window1.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();

            window1.Nomer = 6;
            Rectangle myRect = new Rectangle();
            ImageBrush ub = new ImageBrush();
            //установка цвета линии обводки и цвета заливки при помощи коллекции кистей
            myRect.Stroke = Brushes.Black;
            //myRect.Fill = Brushes.SkyBlue;
            //РАСКОММЕНТИТЬ
            ub.AlignmentX = AlignmentX.Left;
            ub.AlignmentY = AlignmentY.Top;
            ub.ImageSource = new BitmapImage(new Uri(@"pack://application:,,,/Puzle/for game/sobaka.jpg", UriKind.Absolute));
            myRect.Fill = ub;
            //параметры выравнивания
            myRect.HorizontalAlignment = HorizontalAlignment.Left;
            myRect.VerticalAlignment = VerticalAlignment.Center;
            //размеры прямоугольника
            myRect.Height = 230;
            myRect.Width = 400;
            myRect.Margin = new Thickness(1, 0, 0, 0);
            //добавление объекта в сцену
            window1.pokaz.Children.Add(myRect);
            window1.Show();
            this.Close();

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();

            window1.Nomer = 7;
            Rectangle myRect = new Rectangle();
            ImageBrush ub = new ImageBrush();
            //установка цвета линии обводки и цвета заливки при помощи коллекции кистей
            myRect.Stroke = Brushes.Black;
            //myRect.Fill = Brushes.SkyBlue;
            //РАСКОММЕНТИТЬ
            ub.AlignmentX = AlignmentX.Left;
            ub.AlignmentY = AlignmentY.Top;
            ub.ImageSource = new BitmapImage(new Uri(@"pack://application:,,,/Puzle/for game/toge.jpg", UriKind.Absolute));
            myRect.Fill = ub;
            //параметры выравнивания
            myRect.HorizontalAlignment = HorizontalAlignment.Left;
            myRect.VerticalAlignment = VerticalAlignment.Center;
            //размеры прямоугольника
            myRect.Height = 230;
            myRect.Width = 400;
            myRect.Margin = new Thickness(1, 0, 0, 0);
            //добавление объекта в сцену
            window1.pokaz.Children.Add(myRect);
            window1.Show();
            this.Close();

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Nomer = 8;
            Rectangle myRect = new Rectangle();
            ImageBrush ub = new ImageBrush();
            //установка цвета линии обводки и цвета заливки при помощи коллекции кистей
            myRect.Stroke = Brushes.Black;
            //myRect.Fill = Brushes.SkyBlue;
            //РАСКОММЕНТИТЬ
            ub.AlignmentX = AlignmentX.Left;
            ub.AlignmentY = AlignmentY.Top;
            ub.ImageSource = new BitmapImage(new Uri(@"pack://application:,,,/Puzle/for game/sidney.jpg", UriKind.Absolute));
            myRect.Fill = ub;
            //параметры выравнивания
            myRect.HorizontalAlignment = HorizontalAlignment.Left;
            myRect.VerticalAlignment = VerticalAlignment.Center;
            //размеры прямоугольника
            myRect.Height = 230;
            myRect.Width = 400;
            myRect.Margin = new Thickness(1, 0, 0, 0);
            //добавление объекта в сцену
            window1.pokaz.Children.Add(myRect);
            window1.Show();
            this.Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();

            window1.Nomer = 9;
            Rectangle myRect = new Rectangle();
            ImageBrush ub = new ImageBrush();
            //установка цвета линии обводки и цвета заливки при помощи коллекции кистей
            myRect.Stroke = Brushes.Black;
            //myRect.Fill = Brushes.SkyBlue;
            //РАСКОММЕНТИТЬ
            ub.AlignmentX = AlignmentX.Left;
            ub.AlignmentY = AlignmentY.Top;
            ub.ImageSource = new BitmapImage(new Uri(@"pack://application:,,,/Puzle/for game/panda.jpg", UriKind.Absolute));
            myRect.Fill = ub;
            //параметры выравнивания
            myRect.HorizontalAlignment = HorizontalAlignment.Left;
            myRect.VerticalAlignment = VerticalAlignment.Center;
            //размеры прямоугольника
            myRect.Height = 230;
            myRect.Width = 400;
            myRect.Margin = new Thickness(1, 0, 0, 0);
            //добавление объекта в сцену
            window1.pokaz.Children.Add(myRect);
            window1.Show();
            this.Close();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();

            window1.Nomer = 10;
            Rectangle myRect = new Rectangle();
            ImageBrush ub = new ImageBrush();
            //установка цвета линии обводки и цвета заливки при помощи коллекции кистей
            myRect.Stroke = Brushes.Black;
            //myRect.Fill = Brushes.SkyBlue;
            //РАСКОММЕНТИТЬ
            ub.AlignmentX = AlignmentX.Left;
            ub.AlignmentY = AlignmentY.Top;
            ub.ImageSource = new BitmapImage(new Uri(@"pack://application:,,,/Puzle/for game/r34.jpg", UriKind.Absolute));
            myRect.Fill = ub;
            //параметры выравнивания
            myRect.HorizontalAlignment = HorizontalAlignment.Left;
            myRect.VerticalAlignment = VerticalAlignment.Center;
            //размеры прямоугольника
            myRect.Height = 230;
            myRect.Width = 400;
            myRect.Margin = new Thickness(1, 0, 0, 0);
            //добавление объекта в сцену
            window1.pokaz.Children.Add(myRect);
            window1.Show();
            this.Close();

        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Nomer = 11;
            Rectangle myRect = new Rectangle();
            ImageBrush ub = new ImageBrush();
            //установка цвета линии обводки и цвета заливки при помощи коллекции кистей
            myRect.Stroke = Brushes.Black;
            //myRect.Fill = Brushes.SkyBlue;
            //РАСКОММЕНТИТЬ
            ub.AlignmentX = AlignmentX.Left;
            ub.AlignmentY = AlignmentY.Top;
            ub.ImageSource = new BitmapImage(new Uri(@"pack://application:,,,/Puzle/for game/ironman.jpg", UriKind.Absolute));
            myRect.Fill = ub;
            //параметры выравнивания
            myRect.HorizontalAlignment = HorizontalAlignment.Left;
            myRect.VerticalAlignment = VerticalAlignment.Center;
            //размеры прямоугольника
            myRect.Height = 230;
            myRect.Width = 400;
            myRect.Margin = new Thickness(1, 0, 0, 0);
            //добавление объекта в сцену
            window1.pokaz.Children.Add(myRect);
            window1.Show();
            this.Close();

        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Nomer = 12;
            Rectangle myRect = new Rectangle();
            ImageBrush ub = new ImageBrush();
            //установка цвета линии обводки и цвета заливки при помощи коллекции кистей
            myRect.Stroke = Brushes.Black;
            //myRect.Fill = Brushes.SkyBlue;
            //РАСКОММЕНТИТЬ
            ub.AlignmentX = AlignmentX.Left;
            ub.AlignmentY = AlignmentY.Top;
            ub.ImageSource = new BitmapImage(new Uri(@"pack://application:,,,/Puzle/for game/joker.jpg", UriKind.Absolute));
            myRect.Fill = ub;
            //параметры выравнивания
            myRect.HorizontalAlignment = HorizontalAlignment.Left;
            myRect.VerticalAlignment = VerticalAlignment.Center;
            //размеры прямоугольника
            myRect.Height = 230;
            myRect.Width = 400;
            myRect.Margin = new Thickness(1, 0, 0, 0);
            //добавление объекта в сцену
            window1.pokaz.Children.Add(myRect);
            window1.Show();
            this.Close();

        }
    }
}
