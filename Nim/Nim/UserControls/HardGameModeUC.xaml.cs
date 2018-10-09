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
    /// Interaction logic for HardGameModeUC.xaml
    /// </summary>
    public partial class HardGameModeUC : UserControl
    {
        MainWindow window;
        public List<Pile> Piles { get; set; }

        public HardGameModeUC()
        {
            InitializeComponent();
            Piles = new List<Pile>();
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

        internal void UpdateView()
        {
            foreach (Piece piece in Piles[0])
            {
                Uri imageUri = new Uri(piece.ImagePath, UriKind.Relative);
                BitmapImage imageBitmap = new BitmapImage(imageUri);
                Image img = new Image()
                {
                    Source = imageBitmap,
                };
                //img.MouseDown

                row1.Children.Add(img);
            }

            foreach (Piece piece in Piles[1])
            {
                Uri imageUri = new Uri(piece.ImagePath, UriKind.Relative);
                BitmapImage imageBitmap = new BitmapImage(imageUri);
                Image img = new Image()
                {
                    Source = imageBitmap,
                };
                //img.MouseDown

                row2.Children.Add(img);
            }

            foreach (Piece piece in Piles[2])
            {
                Uri imageUri = new Uri(piece.ImagePath, UriKind.Relative);
                BitmapImage imageBitmap = new BitmapImage(imageUri);
                Image img = new Image()
                {
                    Source = imageBitmap,
                };
                //img.MouseDown

                row3.Children.Add(img);
            }

            foreach (Piece piece in Piles[3])
            {
                Uri imageUri = new Uri(piece.ImagePath, UriKind.Relative);
                BitmapImage imageBitmap = new BitmapImage(imageUri);
                Image img = new Image()
                {
                    Source = imageBitmap,
                };
                //img.MouseDown

                row4.Children.Add(img);
            }
        }
    }
}
