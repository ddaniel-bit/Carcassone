using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carcassone
{
    public class Leaderboard
    {
        String nev;
        int pont;

        public Leaderboard(string nev, int pont)
        {
            this.nev = nev;
            this.pont = pont;
        }

        public string Nev { get => nev; }
        public int Pont { get => pont; }
    }
}
