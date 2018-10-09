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

namespace Nim
{
    /// <summary>
    /// Interaction logic for EasyGameModeUC.xaml
    /// </summary>
    public partial class EasyGameModeUC : UserControl
    {
        MainWindow window;
        public EasyGameModeUC()
        {
            InitializeComponent();
        }

        private void EasyR1C1_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void EasyR1C2_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void EasyR1C3_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void EasyR2C1_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void EasyR2C2_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void EasyR2C3_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void btn_EndTurn_Click(object sender, RoutedEventArgs e)
        {
            window = getWindow();
            window.EndTurn();
        }

        private MainWindow getWindow()
        {
            return Application.Current.MainWindow as MainWindow;
        }

        private void btn_NewGame_Click(object sender, RoutedEventArgs e)
        {
            window = getWindow();
            window.MainMenu();
        }

        private void btn_Close(object sender, RoutedEventArgs e)
        {
            window = getWindow();
            window.Button_Close(sender, e);
        }

        private void E_R1C1_Click(object sender, RoutedEventArgs e)
        {
            btnR1C1.Opacity = 0.5;
            btnR1C1.IsEnabled = false;
        }

        private void E_R1C2_Click(object sender, RoutedEventArgs e)
        {
            btnR1C2.Opacity = 0.5;
            btnR1C2.IsEnabled = false;
        }

        private void E_R1C3_Click(object sender, RoutedEventArgs e)
        {
            btnR1C3.Opacity = 0.5;
            btnR1C3.IsEnabled = false;
        }

        private void E_R2C1_Click(object sender, RoutedEventArgs e)
        {
            btnR2C1.Opacity = 0.5;
            btnR2C1.IsEnabled = false;
        }

        private void E_R2C2_Click(object sender, RoutedEventArgs e)
        {
            btnR2C2.Opacity = 0.5;
            btnR2C2.IsEnabled = false;
        }

        private void E_R2C3_Click(object sender, RoutedEventArgs e)
        {
            btnR2C3.Opacity = 0.5;
            btnR2C3.IsEnabled = false;
        }
    }
}
