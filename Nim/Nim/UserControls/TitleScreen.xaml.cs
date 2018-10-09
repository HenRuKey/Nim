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

namespace Nim.UserControls
{
    /// <summary>
    /// Interaction logic for TitleScreen.xaml
    /// </summary>
    public partial class TitleScreen : UserControl
    {
        MainWindow window;
        public TitleScreen()
        {
            InitializeComponent();
            
        }

        private void btn_PvP_Click(object sender, RoutedEventArgs e)
        {
            window = getWindow();
            window.GameMode_Click(sender, e);
        }

        private MainWindow getWindow()
        {
            return Application.Current.MainWindow as MainWindow;
        }

        private void btn_PvC_Click(object sender, RoutedEventArgs e)
        {
            window = getWindow();
            window.GameMode_Click(sender, e);
        }

        private void btn_Close_Click(object sender, RoutedEventArgs e)
        {
            window = getWindow();
            window.Button_Close(sender, e);
        }

        private void btn_Easy_Click(object sender, RoutedEventArgs e)
        {
            window = getWindow();
            window.Difficulty_Click(sender, e);
        }

        private void btn_Medium_Click(object sender, RoutedEventArgs e)
        {
            window = getWindow();
            window.Difficulty_Click(sender, e);
        }

        private void btn_Hard_Click(object sender, RoutedEventArgs e)
        {
            window = getWindow();
            window.Difficulty_Click(sender, e);
        }

        private void Button_Start_Click(object sender, RoutedEventArgs e)
        {
            window = getWindow();
            window.Start_Click(sender, e);
        }

        private void btnHelp_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("Each turn you can take any number of matches " +
                "from a single row. Press \"End Turn\" when you are finished. " +
                "The player that takes the last piece is the loser!", "Tutorial",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
