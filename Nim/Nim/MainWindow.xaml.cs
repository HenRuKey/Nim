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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string Mode = "PvC";
        string Difficulty = "Medium";
        SolidColorBrush selected = new SolidColorBrush(Color.FromRgb(161, 162, 163));
        SolidColorBrush unselected = new SolidColorBrush(Color.FromRgb(106, 119, 144));
        PlayerNameGUI nameGUI = new PlayerNameGUI();
        

        public MainWindow()
        {
            InitializeComponent();
            btn_PvC.Background = selected;
            btn_Medium.Background = selected;
        }

        private void GameMode_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if(button.Name == "btn_PvC")
            {
                btn_PvC.Background = selected;
                btn_PvP.Background = unselected;
                Mode = "PvC";
            }
            else
            {
                btn_PvP.Background = selected;
                btn_PvC.Background = unselected;
                Mode = "PvP";
            }

        }

        private void Button_Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Difficulty_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if (button.Name == "btn_Easy")
            {
                btn_Easy.Background = selected;
                btn_Medium.Background = unselected;
                btn_Hard.Background = unselected;
                Difficulty = "Easy";

            } else if (button.Name == "btn_Medium")
            {
                btn_Easy.Background = unselected;
                btn_Medium.Background = selected;
                btn_Hard.Background = unselected;
                Difficulty = "Medium";
            } else
            {
                btn_Easy.Background = unselected;
                btn_Medium.Background = unselected;
                btn_Hard.Background = selected;
                Difficulty = "Hard";

            }

        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            this.Content = nameGUI.Content;
        }
    }
}
