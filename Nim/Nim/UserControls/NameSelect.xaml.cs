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
    /// Interaction logic for NameSelect.xaml
    /// </summary>
    public partial class NameSelect : UserControl
    {
        MainWindow window;
        public NameSelect()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, RoutedEventArgs e)
        {
            window = getWindow();
            window.MainMenu();
        }

        private void Button_Close(object sender, RoutedEventArgs e)
        {
            window = getWindow();
            window.Button_Close(sender, e);
        }

        private MainWindow getWindow()
        {
            return Application.Current.MainWindow as MainWindow;
        }

        private void btn_Go_Click(object sender, RoutedEventArgs e)
        {
            window = getWindow();
            window.Go();
        }
    }
}
