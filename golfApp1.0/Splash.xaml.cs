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

namespace golfApp1._0
{
    /// <summary>
    /// Interaction logic for Splash.xaml
    /// </summary>
    public partial class Splash : Window
    {
        MainWindow mw = new MainWindow();

        public Splash()
        {
            InitializeComponent();
        }

        private void move(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Button_Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Minimize(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void UN_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LogIn_Click(object sender, RoutedEventArgs e)
        {
            if ((UN.Text == "michael") & (PSWD.Password == "seman"))
            {
                this.Close();
                mw.Show();
            }
            else
            {
                MessageBox.Show("wrong user name and/or password.");
            }
        }
    }
}
