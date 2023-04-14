using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertidor_de_monedas_cnl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            {
                double cantidad = 0.0;
                string monedaOrigen, monedaDestino;

                try
                {
                    Console.Write("Ingrese la cantidad a convertir: ");
                    cantidad = double.Parse(Console.ReadLine());
                }
                 catch (FormatException)
                {
                    Console.WriteLine("Error: debe ingresar un número válido.");
                    return;
                }

                try
                {
                    Console.Write("Ingrese la moneda de origen (DOP, USD, EUR, GBP): ");
                    monedaOrigen = Console.ReadLine().ToUpper();
                    if (!(monedaOrigen == "DOP" || monedaOrigen == "USD" || monedaOrigen == "EUR" || monedaOrigen == "GBP"))
                    {
                        throw new ArgumentException();
                    }
                }
             
                catch (Exception)
                {
                    Console.WriteLine("Error: se produjo un error al leer la moneda de origen.");
                    return;
                }

                try
                {
                    Console.Write("Ingrese la moneda de destino (DOP, USD, EUR, GBP): ");
                    monedaDestino = Console.ReadLine().ToUpper();
                    if (!(monedaDestino == "DOP" || monedaDestino == "USD" || monedaDestino == "EUR" || monedaDestino == "GBP"))
                    {
                        throw new ArgumentException();
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Error: moneda de destino no válida.");
                    return;
                }
                catch (Exception)
                {
                    Console.WriteLine("Error: se produjo un error al leer la moneda de destino.");
                    return;
                }

                double resultado = 0.0;

                switch (monedaOrigen)
                {
                    case "DOP":
                        switch (monedaDestino)
                        {
                            case "DOP":
                                resultado = cantidad;
                                break;
                            case "USD":
                                resultado = cantidad / 54.91;
                                break;
                            case "EUR":
                                resultado = cantidad / 60.72;
                                break;
                            case "GBP":
                                resultado = cantidad / 68.63;
                                break;
                        }
                        break;
                    case "USD":
                        switch (monedaDestino)
                        {
                            case "DOP":
                                resultado = cantidad * 54.91;
                                break;
                            case "USD":
                                resultado = cantidad;
                                break;
                            case "EUR":
                                resultado = cantidad * 0.90;
                                break;
                            case "GBP":
                                resultado = cantidad * 0.72;
                                break;
                        }
                        break;
                    case "EUR":
                        switch (monedaDestino)
                        {
                            case "DOP":
                                resultado = cantidad * 60.72;
                                break;
                            case "USD":
                                resultado = cantidad * 1.18;
                                break;
                            case "EUR":
                                resultado = cantidad;
                                break;
                            case "GBP":
                                resultado = cantidad * 0.85;
                                break;
                        }
                        break;
                    case "GBP":
                        switch (monedaDestino)
                        {
                            case "DOP":
                                resultado = cantidad * 68.14;
                                break;
                            case "USD":
                                resultado = cantidad * 1.38;
                                break;
                            case "EUR":
                                resultado = cantidad * 1.18;
                                break;
                            case "GBP":
                                resultado = cantidad;
                                break;
                        }
                        break;
                }

                Console.WriteLine($"{cantidad} {monedaOrigen} equivale a {resultado} {monedaDestino}.");

                Console.ReadLine();
            }

        }

    }

}

        
               
    

