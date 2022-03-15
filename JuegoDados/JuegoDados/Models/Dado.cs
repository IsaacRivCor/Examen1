using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDados.Models
{
    internal class Dado
    {
        int _numero;

        public int numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        public Dado()
        {
            _numero = 0;
        }

        public int tirarDado()
        {
            Random r = new Random();
            _numero = r.Next(1,6);
            return _numero;
        }

    }
}
