using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JuegoDados.Models;

namespace JuegoDados
{
    internal class Juego
    {
        Dado _dado1;
        Dado _dado2;
        Jugador _jugador;
        int _balance;
        int _resultadosExtremos;
        int _resultadosMedios;
        int _resultadosPares;
        int _resultadosImpares;
        List<int> _resultadosDados;
        List<Tirada> _listaTiradas;
        public Juego()
        {
            this._dado1 = new Dado();
            this._dado2 = new Dado();
            this._jugador = new Jugador();
            this._balance = 0;
            this._resultadosExtremos = 0;
            this._resultadosMedios = 0;
            this._resultadosPares = 0;
            this._resultadosImpares = 0;
            this._listaTiradas = new List<Tirada>();
            this._resultadosDados = new List<int>();
        }

        public void showMenuPrincipal()
        {
            int opcionSeleccionada = 0;
            Console.Clear();
            do
            {
                if (_jugador.dinero > 0)
                {
                    Console.WriteLine("Bienvenido al Juego de dados. Seleccione una opcion");
                    Console.WriteLine("1.- Hacer apuesta");
                    Console.WriteLine("2.- Mostrar historial");
                    Console.WriteLine("3.- Mostrar estadisticas");
                    Console.WriteLine("4.- Retirarte");
                }
                else
                {
                    Console.WriteLine("Te has quedado sin dinero, no puedes jugar más");
                    break;
                }
            } while (!validaMenu(4, ref opcionSeleccionada));
            switch (opcionSeleccionada)
            {

                case 1:
                    showMenuApuestas();
                    break;
                case 2:
                    mostrarHistorial();
                    Console.WriteLine("Presiona 'Enter' para continuar...");
                    Console.ReadLine();
                    showMenuPrincipal();
                    break;
                case 3:
                    mostrarEstadisticas();
                    Console.WriteLine("Presiona 'Enter' para continuar...");
                    Console.ReadLine();
                    showMenuPrincipal();
                    break;
                case 4:
                    Console.WriteLine($"Balance final: {_balance}");
                    Console.WriteLine("Presiona 'Enter' para continuar...");
                    Console.ReadLine();
                    break;
                
            }
        }
        private void showMenuApuestas()
        {
            int opcionSeleccionada = 0;
            Console.Clear();
            do
            {
                Console.WriteLine("Bienvenido al Sistema de Control de Peliculas");
                Console.WriteLine("1.- Apostar a numero especifico");
                Console.WriteLine("2.- Apostar a numero extremo");
                Console.WriteLine("3.- Apostar a numero medio");
                Console.WriteLine("4.- Apostar a numero par");
                Console.WriteLine("5.- Apostar a numero impar");
                Console.WriteLine("6.- Regresar ....");
            } while (!validaMenu(6, ref opcionSeleccionada));
            switch (opcionSeleccionada)
            {

                case 1:
                    int valorDado = pedirValorInt("Ingresa el numero a apostar");
                    int apuesta = pedirApuesta("Ingresa la cantidad de dinero a apostar");
                    _balance = _balance - apuesta;
                    _jugador.dinero = _jugador.dinero - apuesta;
                    Tirada nuevaTirada = new Tirada("Numero Especifico", false);
                    int sumaDados = _dado1.tirarDado() + _dado2.tirarDado();
                    _resultadosDados.Add(sumaDados);
                    if (valorDado == sumaDados)
                    {
                        Console.WriteLine("Apuesta ganada");
                        _jugador.dinero = _jugador.dinero + (apuesta * 10);
                        _balance = _balance + (apuesta * 10);
                        nuevaTirada.ganada = true;
                        _listaTiradas.Add(nuevaTirada);
                        aumentarContadoresResultados(sumaDados);
                    }
                    else
                    {
                        Console.WriteLine("Apuesta perdida");
                        _listaTiradas.Add(nuevaTirada);
                        aumentarContadoresResultados(sumaDados);
                    }
                    Console.WriteLine("Presiona 'Enter' para continuar...");
                    Console.ReadLine();
                    showMenuPrincipal();
                    break;
                case 2:
                    apuesta = pedirApuesta("Ingresa la cantidad de dinero a apostar");
                    _balance = _balance - apuesta;
                    _jugador.dinero = _jugador.dinero - apuesta;
                    nuevaTirada = new Tirada("Numero Extremo", false);
                    sumaDados = _dado1.tirarDado() + _dado2.tirarDado();
                    _resultadosDados.Add(sumaDados);
                    if ((sumaDados > 1 && sumaDados < 5) || (sumaDados > 9 && sumaDados < 13))
                    {
                        Console.WriteLine("Apuesta ganada");
                        _jugador.dinero = _jugador.dinero + (apuesta * 8);
                        _balance = _balance + (apuesta * 8);
                        nuevaTirada.ganada = true;
                        _listaTiradas.Add(nuevaTirada);
                        aumentarContadoresResultados(sumaDados);
                    }
                    else
                    {
                        Console.WriteLine("Apuesta perdida");
                        _listaTiradas.Add(nuevaTirada);
                        aumentarContadoresResultados(sumaDados);
                    }
                    Console.WriteLine("Presiona 'Enter' para continuar...");
                    Console.ReadLine();
                    showMenuPrincipal();
                    break;
                case 3:
                    apuesta = pedirApuesta("Ingresa la cantidad de dinero a apostar");
                    _balance = _balance - apuesta;
                    _jugador.dinero = _jugador.dinero - apuesta;
                    nuevaTirada = new Tirada("Numero Extremo", false);
                    sumaDados = _dado1.tirarDado() + _dado2.tirarDado();
                    _resultadosDados.Add(sumaDados);
                    if (sumaDados > 4 && sumaDados < 10)
                    {
                        Console.WriteLine("Apuesta ganada");
                        _jugador.dinero = _jugador.dinero + (apuesta * 4);
                        _balance = _balance + (apuesta * 4);
                        nuevaTirada.ganada = true;
                        _listaTiradas.Add(nuevaTirada);
                        aumentarContadoresResultados(sumaDados);
                    }
                    else
                    {
                        Console.WriteLine("Apuesta perdida");
                        _listaTiradas.Add(nuevaTirada);
                        aumentarContadoresResultados(sumaDados);
                    }
                    Console.WriteLine("Presiona 'Enter' para continuar...");
                    Console.ReadLine();
                    showMenuPrincipal();
                    break;
                case 4:
                    apuesta = pedirApuesta("Ingresa la cantidad de dinero a apostar");
                    _balance = _balance - apuesta;
                    _jugador.dinero = _jugador.dinero - apuesta;
                    nuevaTirada = new Tirada("Numero Extremo", false);
                    sumaDados = _dado1.tirarDado() + _dado2.tirarDado();
                    _resultadosDados.Add(sumaDados);
                    if (sumaDados%2 == 0)
                    {
                        Console.WriteLine("Apuesta ganada");
                        _jugador.dinero = _jugador.dinero + (apuesta * 2);
                        _balance = _balance + (apuesta * 2);
                        nuevaTirada.ganada = true;
                        _listaTiradas.Add(nuevaTirada);
                        aumentarContadoresResultados(sumaDados);
                    }
                    else
                    {
                        Console.WriteLine("Apuesta perdida");
                        _listaTiradas.Add(nuevaTirada);
                        aumentarContadoresResultados(sumaDados);
                    }
                    Console.WriteLine("Presiona 'Enter' para continuar...");
                    Console.ReadLine();
                    showMenuPrincipal();
                    break;
                case 5:
                    apuesta = pedirApuesta("Ingresa la cantidad de dinero a apostar");
                    _balance = _balance - apuesta;
                    _jugador.dinero = _jugador.dinero - apuesta;
                    nuevaTirada = new Tirada("Numero Extremo", false);
                    sumaDados = _dado1.tirarDado() + _dado2.tirarDado();
                    _resultadosDados.Add(sumaDados);
                    if (sumaDados%2 != 0)
                    {
                        Console.WriteLine("Apuesta ganada");
                        _jugador.dinero = _jugador.dinero + (apuesta * 2);
                        _balance = _balance + (apuesta * 2);
                        nuevaTirada.ganada = true;
                        _listaTiradas.Add(nuevaTirada);
                        aumentarContadoresResultados(sumaDados);
                    }
                    else
                    {
                        Console.WriteLine("Apuesta perdida");
                        _listaTiradas.Add(nuevaTirada);
                        aumentarContadoresResultados(sumaDados);
                    }
                    Console.WriteLine("Presiona 'Enter' para continuar...");
                    Console.ReadLine();
                    showMenuPrincipal();
                    break;
                case 6:
                    showMenuPrincipal();
                    break;
            }
        }
        public void mostrarHistorial()
        {
            foreach (Tirada item in _listaTiradas)
            {
                Console.WriteLine(item.ToString());
            }
        }
        private void mostrarEstadisticas()
        {
            Console.WriteLine($"Balance: {_balance}");
            Console.WriteLine($"Tiradas Realizadas: {_listaTiradas.Count}");
            Console.WriteLine($"Numero mas repetido:");
            obtenerMasTirado();
            Console.WriteLine($"Numero meos repetido:");
            obtenerMenosTirado();
            Console.WriteLine($"Resultado extrmos: {_resultadosExtremos}");
            Console.WriteLine($"Resultado medios: {_resultadosMedios}");
            Console.WriteLine($"Resultado pares: {_resultadosPares}");
            Console.WriteLine($"Resultado impares: {_resultadosImpares}");
        }
        private void obtenerMasTirado()
        {
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int num5 = 0;
            int num6 = 0;
            int num7 = 0;
            int num8 = 0;
            int num9 = 0;
            int num10 = 0;
            int num11 = 0;
            int num12 = 0;

            foreach (int item in _resultadosDados)
            {
                if (item == 2)
                {
                    num2++;
                }
                else if (item == 3)
                {
                    num3++;
                }
                else if (item == 4)
                {
                    num4++;
                }
                else if (item == 5)
                {
                    num5++;
                }
                else if (item == 6)
                {
                    num6++;
                }
                else if (item == 7)
                {
                    num7++;
                }
                else if (item == 8)
                {
                    num8++;
                }
                else if (item == 9)
                {
                    num9++;
                }
                else if (item == 10)
                {
                    num10++;
                }
                else if (item == 11)
                {
                    num11++;
                }
                else if (item == 12)
                {
                    num12++;
                }
            }

            if (num2 > num3 && num2 > num4 && num2 > num5 && num2 > num6 && num2 > num7 && num2 > num8 && num2 > num9 && num2 > num10 && num2 > num11 && num2 > num12)
            {
                Console.WriteLine("El numeo que más apareció fue el 2");
            }
            else if (num3 > num2 && num3 > num4 && num3 > num5 && num3 > num6 && num3 > num7 && num3 > num8 && num3 > num9 && num3 > num10 && num3 > num11 && num3 > num12)
            {
                Console.WriteLine("El numeo que más apareció fue el 3");
            }
            else if (num4 > num3 && num4 > num2 && num4 > num5 && num4 > num6 && num4 > num7 && num4 > num8 && num4 > num9 && num4 > num10 && num4 > num11 && num4 > num12)
            {
                Console.WriteLine("El numeo que más apareció fue el 4");
            }
            else if (num5 > num3 && num5 > num4 && num5 > num2 && num5 > num6 && num5 > num7 && num5 > num8 && num5 > num9 && num5 > num10 && num5 > num11 && num5 > num12)
            {
                Console.WriteLine("El numeo que más apareció fue el 5");
            }
            else if (num6 > num3 && num6 > num4 && num6 > num5 && num6 > num2 && num6 > num7 && num6 > num8 && num6 > num9 && num6 > num10 && num6 > num11 && num6 > num12)
            {
                Console.WriteLine("El numeo que más apareció fue el 6");
            }
            else if (num7 > num3 && num7 > num4 && num7 > num5 && num7 > num6 && num7 > num2 && num7 > num8 && num7 > num9 && num7 > num10 && num7 > num11 && num7 > num12)
            {
                Console.WriteLine("El numeo que más apareció fue el 7");
            }
            else if (num8 > num3 && num8 > num4 && num8 > num5 && num8 > num6 && num8 > num7 && num8 > num2 && num8 > num9 && num8 > num10 && num8 > num11 && num8 > num12)
            {
                Console.WriteLine("El numeo que más apareció fue el 8");
            }
            else if (num9 > num3 && num9 > num4 && num9 > num5 && num9 > num6 && num9 > num7 && num9 > num8 && num9 > num2 && num9 > num10 && num9 > num11 && num9 > num12)
            {
                Console.WriteLine("El numeo que más apareció fue el 9");
            }
            else if (num10 > num3 && num10 > num4 && num10 > num5 && num10 > num6 && num10 > num7 && num10 > num8 && num10 > num9 && num10 > num2 && num10 > num11 && num10 > num12)
            {
                Console.WriteLine("El numeo que más apareció fue el 10");
            }
            else if (num11 > num3 && num11 > num4 && num11 > num5 && num11 > num6 && num11 > num7 && num11 > num8 && num11 > num9 && num11 > num10 && num11 > num12 && num11 > num12)
            {
                Console.WriteLine("El numeo que más apareció fue el 11");
            }
            else if (num12 > num3 && num12 > num4 && num12 > num5 && num12 > num6 && num12 > num7 && num12 > num8 && num12 > num9 && num12 > num10 && num12 > num11 && num12 > num2)
            {
                Console.WriteLine("El numeo que más apareció fue el 12");
            }
            else
            {
                Console.WriteLine("Se encontraron varios numeros que más se repitieron");
            }
        }

        private void obtenerMenosTirado()
        {
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int num5 = 0;
            int num6 = 0;
            int num7 = 0;
            int num8 = 0;
            int num9 = 0;
            int num10 = 0;
            int num11 = 0;
            int num12 = 0;

            foreach (int item in _resultadosDados)
            {
                if (item == 2)
                {
                    num2++;
                }
                else if (item == 3)
                {
                    num3++;
                }
                else if (item == 4)
                {
                    num4++;
                }
                else if (item == 5)
                {
                    num5++;
                }
                else if (item == 6)
                {
                    num6++;
                }
                else if (item == 7)
                {
                    num7++;
                }
                else if (item == 8)
                {
                    num8++;
                }
                else if (item == 9)
                {
                    num9++;
                }
                else if (item == 10)
                {
                    num10++;
                }
                else if (item == 11)
                {
                    num11++;
                }
                else if (item == 12)
                {
                    num12++;
                }
            }

            if (num2 < num3 && num2 < num4 && num2 < num5 && num2 < num6 && num2 < num7 && num2 < num8 && num2 < num9 && num2 < num10 && num2 < num11 && num2 < num12)
            {
                Console.WriteLine("El numeo que más apareció fue el 2");
            }
            else if (num3 < num2 && num3 < num4 && num3 < num5 && num3 < num6 && num3 < num7 && num3 < num8 && num3 < num9 && num3 < num10 && num3 < num11 && num3 < num12)
            {
                Console.WriteLine("El numeo que más apareció fue el 3");
            }
            else if (num4 < num3 && num4 < num2 && num4 < num5 && num4 < num6 && num4 < num7 && num4 < num8 && num4 < num9 && num4 < num10 && num4 < num11 && num4 < num12)
            {
                Console.WriteLine("El numeo que más apareció fue el 4");
            }
            else if (num5 < num3 && num5 < num4 && num5 < num2 && num5 < num6 && num5 < num7 && num5 < num8 && num5 < num9 && num5 < num10 && num5 < num11 && num5 < num12)
            {
                Console.WriteLine("El numeo que más apareció fue el 5");
            }
            else if (num6 < num3 && num6 < num4 && num6 < num5 && num6 < num2 && num6 < num7 && num6 < num8 && num6 < num9 && num6 < num10 && num6 < num11 && num6 < num12)
            {
                Console.WriteLine("El numeo que más apareció fue el 6");
            }
            else if (num7 < num3 && num7 < num4 && num7 < num5 && num7 < num6 && num7 < num2 && num7 < num8 && num7 < num9 && num7 < num10 && num7 < num11 && num7 < num12)
            {
                Console.WriteLine("El numeo que más apareció fue el 7");
            }
            else if (num8 < num3 && num8 < num4 && num8 < num5 && num8 < num6 && num8 < num7 && num8 < num2 && num8 < num9 && num8 < num10 && num8 < num11 && num8 < num12)
            {
                Console.WriteLine("El numeo que más apareció fue el 8");
            }
            else if (num9 < num3 && num9 < num4 && num9 < num5 && num9 < num6 && num9 < num7 && num9 < num8 && num9 < num2 && num9 < num10 && num9 < num11 && num9 < num12)
            {
                Console.WriteLine("El numeo que más apareció fue el 9");
            }
            else if (num10 < num3 && num10 < num4 && num10 < num5 && num10 < num6 && num10 < num7 && num10 < num8 && num10 < num9 && num10 < num2 && num10 < num11 && num10 < num12)
            {
                Console.WriteLine("El numeo que más apareció fue el 10");
            }
            else if (num11 < num3 && num11 < num4 && num11 < num5 && num11 < num6 && num11 < num7 && num11 < num8 && num11 < num9 && num11 < num10 && num11 < num12 && num11 < num12)
            {
                Console.WriteLine("El numeo que más apareció fue el 11");
            }
            else if (num12 < num3 && num12 < num4 && num12 < num5 && num12 < num6 && num12 < num7 && num12 < num8 && num12 < num9 && num12 < num10 && num12 < num11 && num12 < num2)
            {
                Console.WriteLine("El numeo que más apareció fue el 12");
            }
            else
            {
                Console.WriteLine("Se encontraron varios numeros que más se repitieron");
            }
        }
        private void aumentarContadoresResultados(int resultado)
        {
            if ((resultado > 1 && resultado < 5) || (resultado > 9 && resultado < 13))
            {
                _resultadosExtremos++;
            }
            if (resultado > 4 && resultado < 10)
            {
                _resultadosMedios++;
            }
            if (resultado%2 == 0)
            {
                _resultadosPares++;
            }
            if (resultado%2 != 0)
            {
                _resultadosImpares++;
            }
        }
        private bool validaMenu(int opciones, ref int opcionSeleccionada)
        {
            int n;
            if (int.TryParse(Console.ReadLine(), out n))
            {
                if (n <= opciones)
                {
                    opcionSeleccionada = n;
                    return true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opción Invalida.");
                    return false;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("El valor ingresado no es válido, debes ingresar un número.");
                return false;
            }
        }
        private string pedirValorString(string texto)
        {
            string? valor;
            do
            {
                Console.Write($"{texto}: ");
                valor = Console.ReadLine();
                if (valor == null || valor == "")
                {
                    Console.WriteLine("Valor inválido.");
                }
            } while (valor == null || valor == "");
            return valor;
        }
        private int pedirValorInt(string texto)
        {
            int valor;
            Console.Write($"{texto}: ");
            while (!int.TryParse(Console.ReadLine(), out valor) || (valor <= 1 || valor >= 13))
            {
                Console.WriteLine("Valor inválido. Debes ingresar un número. o un número entre 2 y 12");
                Console.Write($"{texto}: ");
            }
            return valor;
        }
        private int pedirApuesta(string texto)
        {
            int valor;
            Console.Write($"{texto}: ");
            while (!int.TryParse(Console.ReadLine(), out valor) || (valor%10 != 0) || (valor > _jugador.dinero))
            {
                Console.WriteLine("Valor inválido. Debes ingresar un número multiplo de 10 o menor a tu dinero.");
                Console.Write($"{texto}: ");
            }
            return valor;
        }
        public void inicializarDatos()
        {
            //_jugador.dinero = 0;
        }
    }
}
