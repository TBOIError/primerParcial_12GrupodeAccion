using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_LAB2
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion=0, porcentajeDesc = 0, cantidadcamisas = 0, bandera = 0;
            float precio = 0, PrecioConDesc = 0;
            string salir;

            do
            {
                precio = 1000 * cantidadcamisas;
                if (cantidadcamisas >= 3 && cantidadcamisas <= 5)
                {
                    porcentajeDesc = 10;
                }
                else if (cantidadcamisas > 5)
                {
                    porcentajeDesc = 20;
                }
                else
                {
                    porcentajeDesc = 0;
                }

                if (porcentajeDesc == 0)
                {
                    PrecioConDesc = precio;
                }
                else if (porcentajeDesc == 10)
                {
                    PrecioConDesc = precio - (precio/10);
                }
                else
                {
                    PrecioConDesc = precio - (precio/5);
                }

                Console.WriteLine("Camisas PRADBIT - Ventas minoristas y mayoristas");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("MENÚ PRINCPAL:");
                Console.WriteLine("1- Añadir camisa al carro de compras.");
                Console.WriteLine("2- Eliminar camisa del carro de compras.");
                Console.WriteLine("3- Salir.");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("        - Cantidad de camisas en el carro de compras: {0} ", cantidadcamisas);
                Console.WriteLine("        - Precio Unitario: $1000");
                Console.WriteLine("        - Precio total sin descuento: ${0} ", precio);
                Console.WriteLine("        - Tipo de descuento aplicado: %{0} ", porcentajeDesc);
                Console.WriteLine("        - Precio final con descuento: ${0} ", PrecioConDesc);
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Ingrese una opción del menú");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Usted selecciono añadir camisa");
                        cantidadcamisas += 1;
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("Usted selecciono eliminar camisa");
                        if (cantidadcamisas == 0)
                        {
                            Console.WriteLine("No tiene ninguna camisa en el carro, por lo tanto no puede eliminar");
                        }
                        else
                        {
                            cantidadcamisas -= 1;
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        do 
                        { 
                        Console.Clear();
                        Console.WriteLine("Seguro que desea salir? S/N");
                        salir = Console.ReadLine();
                            switch (salir)
                            {
                                case "s":
                                case "S":
                                    Console.WriteLine("Adiós. Gracias por su compra.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    bandera = 1;
                                    break;
                                case "n":
                                case "N":
                                    Console.WriteLine("Volviendo al menú...");
                                    opcion = 0;
                                    Console.ReadKey();
                                    Console.Clear();
                                    bandera = 1;
                                    break;
                                default:
                                    Console.WriteLine("Opción no valida. Responda nuevamente.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                            }
                        } while (bandera == 0);
                        break;

                    default:
                        Console.Clear();
                        break;
                }

            } while (opcion != 3);
        }
    }
}
