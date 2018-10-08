using Nim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Shapes;

namespace NimLibrary
{
    public class GameController
    {
        // Access modifier set to internal to let unit tests view fields.
        internal Player player1;
        internal Player player2;
        internal Pile pile1 = new Pile();
        internal Pile pile2 = new Pile();
        internal Pile pile3 = new Pile();
        internal Pile pile4 = new Pile();
        internal List<Pile> Piles = new List<Pile>(); 

        public GameController(string mode, string difficulty, string name1, string name2)
        {
            player1 = new Player(name1, false);
            if (mode == "PvC")
            {
                player2 = new Player(name2, true);
            } else
            {
                player2 = new Player(name2, false);
            }

            switch (difficulty) {
                case "easy":
                    pile1.Size = pile2.Size = 3;
                    Piles.Add(pile1);
                    Piles.Add(pile2);
                    break;
                case "medium":
                    pile1.Size = 2;
                    pile2.Size = 5;
                    pile3.Size = 7;
                    Piles.Add(pile1);
                    Piles.Add(pile2);
                    Piles.Add(pile3);
                    break;
                case "hard":
                    pile1.Size = 2;
                    pile1.Size = 3;
                    pile1.Size = 8;
                    pile1.Size = 9;
                    Piles.Add(pile1);
                    Piles.Add(pile2);
                    Piles.Add(pile3);
                    Piles.Add(pile4);
                    break;
            }

            foreach (Pile pile in Piles)
            {
                for (int i = 0; i < pile.Size; i++)
                {
                    Piece p = new Piece();
                    p.ImagePath = "";
                    p.IsSelected = false;
                }
            }
        }

        private void ToggleSelected(object sender, MouseButtonEventArgs e)
        {
            
        }

        public void TakeTurn()
        {
            //Check that at least one piece is selected
            if (SelectedCount() == 0) {
                return;
            }

            //Remove selected pieces
            foreach (Pile pile in Piles) {
                foreach (Piece piece in pile) {
                    if (piece.IsSelected) {
                        pile.Remove(piece);
                    }
                }
            }

            if (GameOver()) {
                //TODO: Notify user
                return;
            }

            //TODO: Change players
            
            //Computer's turn
            if (player2.IsComputer /* && currentPlayer == player2*/) {
                //Select pieces
                RandomComp();

                //Remove selected pieces
                foreach (Pile pile in Piles) {
                    foreach (Piece piece in pile) {
                        if (piece.IsSelected) {
                            pile.Remove(piece);
                        }
                    }
                }

                if (GameOver()) {
                    //TODO: Notify user
                    return;
                }

                //TODO: Change players
            }
        }


        private bool GameOver() {
            foreach (Pile pile in Piles) {
                if (pile.Count == 0) {
                    return true;
                }
            }
            return false;
        }

        private int SelectedCount() {
            int count = 0;
            foreach (Pile pile in Piles) {
                foreach (Piece piece in pile) {
                    if (piece.IsSelected) {
                        count++;
                    }
                }
            }
            return count;
        }

        private void RandomComp() {
            Random random = new Random();
            Pile selectedPile;
            do {
                selectedPile = Piles[random.Next(Piles.Count)];
            } while (selectedPile.Count == 0);
            int numberToTake = random.Next(1, selectedPile.Count);
            for (int i = 0; i < numberToTake; i++) {
                selectedPile[selectedPile.Count - 1 - i].IsSelected = true;
            }
        }
    }
}
