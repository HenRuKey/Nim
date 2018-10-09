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
    /// Interaction logic for MediumGameModeUC.xaml
    /// </summary>
    public partial class MediumGameModeUC : UserControl
    {
        public MediumGameModeUC()
        {
            InitializeComponent();
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
