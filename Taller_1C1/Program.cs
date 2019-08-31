using System;

namespace Taller_1C1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int menu = 1;
            while (menu > 0)
            {
                Console.Clear();
                Console.WriteLine("Taller1C1 \n");
                Console.WriteLine("Opciones disponibles\n");
                Console.WriteLine("1  Cuota estacionamiento ");
                Console.WriteLine("2  Convertir Centigrados/Farenheit ");
                Console.WriteLine("3  Puntos de calidad  ");
                Console.WriteLine("4  Salir \n");
                Console.WriteLine("Ingrese el numero de la opcion deseada:");
                string opc = Console.ReadLine().Trim();

                if (opc == "1")
                {
                    CalcularCargos();
                    VolverAMenu();
                }
                else if (opc == "2")
                {
                    Conversion_grados();
                }
                else if (opc == "3")
                {
                    PuntosCalidad();
                    VolverAMenu();
                }
                else if (opc == "4")
                {
                    menu = 0;

                }
                else
                {
                    Console.WriteLine("opcion invalida, presione enter para intentar de nuevo");
                    Console.ReadLine();
                }
            }
        }
        static void CalcularCargos()
        {
            Console.Clear();
            Console.WriteLine("Cuota de estacionamiento \n");
            Console.WriteLine("Ingrese la cantidad de horas de estacionamiento: ");
            string string_horas = Console.ReadLine();
            float horas;
            
            if (float.TryParse(string_horas, out horas))
            {
                float cuotaMinima = 2.00f;
                float adicional = 0.50f;
                float precio = 0.0f;

                if (horas > 0 && horas <= 3)
                {
                    Console.WriteLine("La cuota de estacionamiento es de $" + cuotaMinima);
                }
                else if (horas > 3 && horas <= 24)
                {
                    float contador = 0.00f;
                    while (horas > 3)
                    {
                        contador++;
                        horas--;
                    }
                    precio = cuotaMinima + (contador * adicional);
                    Console.WriteLine("La cuota de estacionamiento es de $" + precio);
                }
                else
                {
                    Console.WriteLine("Numero de horas invalido");
                }
            }
            else
            {
                Console.WriteLine("No ha ingresado un numero ");
                
            }
        }

        static void Conversion_grados()
        {
            Console.Clear();
            Console.WriteLine("Convertir centigrados/farenheit \n");          
            Console.WriteLine("1  para convertir grados fahrenheit a centigrados ");
            Console.WriteLine("2  para convertir grados centigrados a fahrenheit \n");
            Console.WriteLine("Ingrese el numero de la operacion que desea realizar \n");

            string op = Console.ReadLine();
            if (op == "1")
            {
                Centigrados();
                VolverAMenu();
            }
            else if (op == "2")
            {
                Fahrenheit();
                VolverAMenu();
            }
            else
            {
                Console.WriteLine("opcion invalida: ");
                VolverAMenu();
            }
        }

        static void Centigrados()
        {
            Console.WriteLine("ingrese el numero de grados fahrenheit: ");
            string string_fah = Console.ReadLine();
            float fah;
            if(float.TryParse(string_fah, out fah))
            {
                float cent = (fah - 32) * 5 / 9;
                Console.WriteLine("{0} grados fahrenheit es igual a {1} grados centigrados", fah, cent);
            }
            else
            {
                Console.WriteLine("no ha ingresado un numero ");
            }
        }

        static void Fahrenheit()
        {
            Console.WriteLine("ingrese el numero de grados centigrados: ");
            string string_cent = Console.ReadLine();
            float cent;
            if (float.TryParse(string_cent, out cent))
            {
                float fah = (cent * 9 / 5) + 32;
                Console.WriteLine("{0} grados centigrados es igual a {1} grados fahrenheit", cent, fah);
            }
            else
            {
                Console.WriteLine("No ha ingresado un numero ");
            }
        }

        static void PuntosCalidad()
        {
            Console.Clear();
            Console.WriteLine("Puntos de calidad \n");
            Console.WriteLine("Ingrese su promedio: ");
            string string_prom = Console.ReadLine();
            float prom;
            if(float.TryParse(string_prom,out prom))
            {
                if (prom >= 90 && prom <= 100)
                {
                    Console.WriteLine("puntos de calidad es igual a: 4 ");
                }
                else if (prom >= 80 && prom <= 89)
                {
                    Console.WriteLine("puntos de calidad es igual a: 3 ");
                }
                else if (prom >= 70 && prom <= 79)
                {
                    Console.WriteLine("puntos de calidad es igual a: 2 ");
                }
                else if (prom >= 60 && prom <= 69)
                {
                    Console.WriteLine("puntos de calidad es igual a: 1 ");
                }
                else if (prom < 60)
                {
                    Console.WriteLine("puntos de calidad es igual a: 0 ");
                }
                else
                {
                    Console.WriteLine("dato erroneo");
                }

            }

            else
            {
                Console.WriteLine("No ha ingresado un numero");
            }
        }

        static void VolverAMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("Presione enter para volver al menu");
            Console.ReadLine();
        }
    }
}

