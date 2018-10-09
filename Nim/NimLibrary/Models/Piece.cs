using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace Nim.Models {
    public class Piece {
        public string ImagePath { get; set; }
        public bool IsSelected { get; set; }

        public Image img;
    }
}
