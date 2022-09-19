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

namespace Sytylaya
{
    /// <summary>
    /// Логика взаимодействия для Window.xaml
    /// </summary>
    public partial class Window : Window
    {
        public Window()
        {
            InitializeComponent();
        }

        private void send_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Молодец! Ты помнишь свое имя!");
        }

        private void name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                MessageBox.Show("Имя введено неверно! Попробуйте еще раз!");
        }
    }
}
