using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDados.Models
{
    internal class Tirada
    {
        string _tipoApuesta;
        bool _ganada;

        public string tipoApuesta
        {
            get { return _tipoApuesta; }
            set { _tipoApuesta = value; }
        }
        public bool ganada
        {
            get { return _ganada; }
            set { _ganada = value; }
        }

        public Tirada (string tipoApuesta, bool resultado)
        {
            this._tipoApuesta = tipoApuesta;
            this._ganada = resultado;
        }

        public override string ToString()
        {
            return $"Tipo de apuesta: {_tipoApuesta} ganada: {_ganada}";
        }
    }
}
