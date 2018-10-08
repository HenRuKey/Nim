using Nim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimLibrary
{
    public class GameController
    {
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
                    pile.Add(new Piece()
                    {
                        //ImagePath = "Add A Path Here",
                        IsSelected = false
                    });
                }
            }
        }

        public void TakeTurn()
        {

        }
    }
}
