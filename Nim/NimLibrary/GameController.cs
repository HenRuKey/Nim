using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimLibrary
{
    public class GameController
    {
        Player player1;
        PLayer player2;
        List<Pile> Piles = new List<Pile>(); 
        public GameController(string mode, string difficulty, string name1, string name2)
        {
            player1 = new Player();
            player1.Name = name1;
            player1.IsComputer = false;
            player2 = new PLayer();
            player2.Name = name2();
            player2.IsComputer = false;
            if (mode == "PvC")
            {
                player2.IsComputer = true;
            }

            switch (difficulty) {
                case "easy":
                    Pile pile1 = new Pile();
                    Piles pile2 = new Pile();
                    pile1.size = pile2.size = 3;
                    break;
                case "medium":
                    break;
                case "hard":
                    break;
            }


        }
    }
}
