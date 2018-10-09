using Nim.Models;
using Nim.UserControls;
using NimLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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

        GameController game;
        TitleScreen titleScreen = new TitleScreen();
        NameSelect nameSelect = new NameSelect();
        EasyGameModeUC easyGame = new EasyGameModeUC();
        MediumGameModeUC mediumGame = new MediumGameModeUC();
        HardGameModeUC hardGame = new HardGameModeUC();
        

        public MainWindow()
        {
            InitializeComponent();
            mainWindow.Children.Add(titleScreen);
            mainWindow.Children.Add(nameSelect);
            mainWindow.Children.Add(easyGame);
            mainWindow.Children.Add(mediumGame);
            mainWindow.Children.Add(hardGame);
            nameSelect.Visibility = Visibility.Hidden;
            easyGame.Visibility = Visibility.Hidden;
            mediumGame.Visibility = Visibility.Hidden;
            hardGame.Visibility = Visibility.Hidden;
            titleScreen.btn_PvC.Background = selected;
            titleScreen.btn_Medium.Background = selected;
            easyGame.window = this;
            mediumGame.window = this;
            hardGame.window = this;
        }



        public void GameMode_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if(button.Name == "btn_PvC")
            {
                titleScreen.btn_PvC.Background = selected;
                titleScreen.btn_PvP.Background = unselected;
                Mode = "PvC";
            }
            else
            {
                titleScreen.btn_PvP.Background = selected;
                titleScreen.btn_PvC.Background = unselected;
                Mode = "PvP";
            }

        }

        internal void Button_Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        internal void Difficulty_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if (button.Name == "btn_Easy")
            {
                titleScreen.btn_Easy.Background = selected;
                titleScreen.btn_Medium.Background = unselected;
                titleScreen.btn_Hard.Background = unselected;
                Difficulty = "Easy";

            } else if (button.Name == "btn_Medium")
            {
                titleScreen.btn_Easy.Background = unselected;
                titleScreen.btn_Medium.Background = selected;
                titleScreen.btn_Hard.Background = unselected;
                Difficulty = "Medium";
            } else
            {
                titleScreen.btn_Easy.Background = unselected;
                titleScreen.btn_Medium.Background = unselected;
                titleScreen.btn_Hard.Background = selected;
                Difficulty = "Hard";

            }

        }

        internal void Start_Click(object sender, RoutedEventArgs e)
        {
            titleScreen.Visibility = Visibility.Hidden;
            nameSelect.Visibility = Visibility.Visible;
        }

        internal void MainMenu()
        {
            titleScreen.Visibility = Visibility.Visible;
            nameSelect.Visibility = Visibility.Hidden;
            easyGame.Visibility = Visibility.Hidden;
            mediumGame.Visibility = Visibility.Hidden;
            hardGame.Visibility = Visibility.Hidden;
        }

        internal void Go()
        {
            game = new GameController(Mode, Difficulty, nameSelect.Player1.Content.ToString(), nameSelect.Player2.Content.ToString());
            nameSelect.Visibility = Visibility.Hidden;
            switch (Difficulty)
            {
                case "Easy":
                    easyGame.Visibility = Visibility.Visible;
                    easyGame.Piles = game.getPiles();
                    easyGame.UpdateView();
                    break;
                case "Medium":
                    mediumGame.Visibility = Visibility.Visible;
                    mediumGame.Piles = game.getPiles();
                    mediumGame.UpdateView();
                    break;
                case "Hard":
                    hardGame.Visibility = Visibility.Visible;
                    hardGame.Piles = game.getPiles();
                    hardGame.UpdateView();
                    break;
            }
        }

        internal void ToggleSelected(object sender, MouseButtonEventArgs e)
        {
            Image img = (Image)sender;
            UniformGrid row = (UniformGrid)img.Parent;
            
            switch (row.Name)
            {
                case "row1":
                    if (CheckRows(1))
                    {
                        img.RenderTransformOrigin = new Point(0.5, 0.5);
                        RotateTransform rotateTransform = new RotateTransform(15);
                        img.RenderTransform = rotateTransform;
                        game.SelectPiece(1);
                    }
                    break;
                case "row2":
                    if (CheckRows(2))
                    {
                        img.RenderTransformOrigin = new Point(0.5, 0.5);
                        RotateTransform rotateTransform = new RotateTransform(15);
                        img.RenderTransform = rotateTransform;
                        game.SelectPiece(2);
                    }
                    break;
                case "row3":
                    if (CheckRows(3))
                    {
                        img.RenderTransformOrigin = new Point(0.5, 0.5);
                        RotateTransform rotateTransform = new RotateTransform(15);
                        img.RenderTransform = rotateTransform;
                        game.SelectPiece(3);
                    }
                    break;
                case "row4":
                    if (CheckRows(4))
                    {
                        img.RenderTransformOrigin = new Point(0.5, 0.5);
                        RotateTransform rotateTransform = new RotateTransform(15);
                        img.RenderTransform = rotateTransform;
                        game.SelectPiece(4);
                    }
                    break;
            }
        }

        internal bool CheckRows(int index)
        {
            List<Pile> piles = game.getPiles();
            for (int i = 0; i < game.getPiles().Count; i++)
            {
                foreach (Piece piece in piles[i])
                {
                    if (piece.IsSelected && i != index)
                    {
                        return false;
                    }
                }
            }
            return true;
        }


        internal void EndTurn()
        {
            game.TakeTurn();
            easyGame.UpdateView();
        }
    }
}
