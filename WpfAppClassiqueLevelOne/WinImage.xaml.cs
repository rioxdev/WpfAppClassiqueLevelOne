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
using Path = System.IO.Path;

namespace WpfAppClassiqueLevelOne
{
    /// <summary>
    /// Logique d'interaction pour WinImage.xaml
    /// </summary>
    public partial class WinImage : Window
    {

        private List<BitmapImage> _images = new List<BitmapImage>();
        private int _currImage = 0;

        public WinImage()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                var path = Environment.CurrentDirectory;
                _images.Add(new BitmapImage(new Uri($@"\Sary\un.jpg", uriKind:UriKind.Relative)));
                _images.Add(new BitmapImage(new Uri($@"\Sary\deux.jpg", UriKind.Relative)));
                _images.Add(new BitmapImage(new Uri($@"\Sary\trois.jpg", UriKind.Relative)));
                _images.Add(new BitmapImage(new Uri($@"\Sary\quatre.jpg", UriKind.Relative)));

                imageHolder.Source = _images[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            if (!_images.Any())
                return;

            if (--_currImage < 0)
                _currImage = _images.Count - 1;

            imageHolder.Source = _images[_currImage];
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (!_images.Any())
                return;

            if (++_currImage > _images.Count-1)
                _currImage = 0;
            imageHolder.Source = _images[_currImage];
        }
    }
}
