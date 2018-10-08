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
    /// Interaction logic for HardGameModeUC.xaml
    /// </summary>
    public partial class HardGameModeUC : UserControl
    {
        public HardGameModeUC()
        {
            InitializeComponent();
        }

        private void HardR1C1_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void HardR1C2_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void HardR2C1_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void HardR2C2_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void HardR2C3_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void HardR3C1_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void HardR3C2_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void HardR3C3_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void HardR3C4_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void HardR3C5_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void HardR3C6_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void HardR3C7_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void HardR3C8_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void HardR4C1_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void HardR4C2_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void HardR4C3_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void HardR4C4_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void HardR4C5_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void HardR4C6_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void HardR4C7_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void HardR4C8_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void HardR4C9_Click(object sender, MouseButtonEventArgs e)
        {

        }
        MainWindow window;

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
    }
}
