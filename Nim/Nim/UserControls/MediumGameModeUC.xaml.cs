using Nim.Models;
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
        internal MainWindow window;
        public List<Pile> Piles { get; set; }

        public MediumGameModeUC()
        {
            InitializeComponent();
            Piles = new List<Pile>();
        }
        
        private void btn_EndTurn_Click(object sender, RoutedEventArgs e)
        {
            window.EndTurn();
        }


        private void btn_NewGame_Click(object sender, RoutedEventArgs e)
        {
            window.MainMenu();
        }

        private void btn_Close(object sender, RoutedEventArgs e)
        {
            window.Button_Close(sender, e);
        }

        internal void UpdateView()
        {
            row1.Children.Clear();
            row2.Children.Clear();
            row3.Children.Clear();
            foreach (Piece piece in Piles[0])
            {
                Image img;
                Uri imageUri = new Uri("/Nim;component/Matchstick5.png", UriKind.Relative);
                BitmapImage imageBitmap = new BitmapImage(imageUri);
                img = new Image()
                {
                    Source = imageBitmap,
                };
                img.MouseDown += window.ToggleSelected;
                row1.Children.Add(img);
            }

            foreach (Piece piece in Piles[1])
            {
                Image img;
                Uri imageUri = new Uri("/Nim;component/Matchstick5.png", UriKind.Relative);
                BitmapImage imageBitmap = new BitmapImage(imageUri);
                img = new Image()
                {
                    Source = imageBitmap,
                };
                img.MouseDown += window.ToggleSelected;
                row2.Children.Add(img);
            }

            foreach (Piece piece in Piles[2])
            {
                Image img;
                Uri imageUri = new Uri("/Nim;component/Matchstick5.png", UriKind.Relative);
                BitmapImage imageBitmap = new BitmapImage(imageUri);
                img = new Image()
                {
                    Source = imageBitmap,
                };
                img.MouseDown += window.ToggleSelected;
                row3.Children.Add(img);
            }
        }
    }
}
