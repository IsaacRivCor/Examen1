using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDados.Models
{
    internal class Jugador
    {
        int _dinero;

        public int dinero
        {
            get { return _dinero; }
            set { _dinero = value; }
        }

        public Jugador()
        {
            _dinero = 300;
        }
    }
}
