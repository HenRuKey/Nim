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
    /// Interaction logic for GameOverUC.xaml
    /// </summary>
    public partial class GameOverUC : UserControl
    {
        public GameOverUC()
        {
            InitializeComponent();
        }

        MainWindow window;

        private MainWindow getWindow()
        {
            return Application.Current.MainWindow as MainWindow;
        }

        private void Close_Game_Click(object sender, RoutedEventArgs e)
        {
            window = getWindow();
            window.Button_Close(sender, e);
        }

        private void PlayAgain_Click(object sender, RoutedEventArgs e)
        {
            window = getWindow();
            window.MainMenu();
        }
    }
}
