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

namespace WpfAppClassiqueLevelOne
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //RenderButton();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($" it s my time {DateTime.Now}");
        }

        private void RenderButton()
        {
            Button btn = new Button()
            {
                Content = DateTime.Now.ToShortTimeString(),
                Width = 50,
                Height = 40
            };

            btn.Click += Btn_Click;

            this.Content = btn;
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($" it s my time {DateTime.Now}");
        }
    }
}
