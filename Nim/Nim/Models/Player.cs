using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nim.Models {
    class Player {
        public readonly string Name;
        public readonly bool IsComputer;

        public Player(string Name, bool IsComputer) {
            this.Name = Name;
            this.IsComputer = IsComputer;
        }

        public override string ToString() {
            return Name;
        }
    }
}
