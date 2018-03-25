using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invaders
{
    class Invader
    {

        private int _positie;
        private int _levens;
        private int _id;
        private static int volgendVrijeId = 0;

        public int Positie { get { return _positie; } }

        public int Id { get { return _id; } }

        public int Levens {
            get { return _levens; }
        }

        public Invader(int invaderLevens) {
            _levens = invaderLevens;

            _id = volgendVrijeId;
            volgendVrijeId++;
        }

        public void verlaagLeven() {
            _levens--;
        }

        public void beweegInvader(int invaderSnelheid)
        {
            _positie += invaderSnelheid;
        }
    }
}
