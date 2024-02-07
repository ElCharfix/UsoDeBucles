using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Elija un subprograma (1-4):");
        Console.WriteLine("1. Mostrar los números descendentes del 1 al 100 de dos en dos");
        Console.WriteLine("2. Pedir un número y que muestre la tabla del 1 al 12 de dicho número");
        Console.WriteLine("3. Preguntar la cantidad de montos, pida dichos montos y calcule la sumatorio y el promedio");
        Console.WriteLine("4. Opción Sorpresa");
        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                MostrarNumerosDescendentes();
                break;
            case 2:
                MostrarTablaMultiplicar();
                break;
            case 3:
                CalcularSumaYPromedio();
                break;
            case 4:
                RepetirNombre();
                break;
            default:
                Console.WriteLine("Opción no válida");
                break;
        }
    }

    static void MostrarNumerosDescendentes()
    {
        Console.WriteLine("Subprograma 1: Mostrar números descendentes del 1 al 100 de dos en dos");

        Console.WriteLine("Elija el tipo de bucle (1: While, 2: Do/While, 3: For):");
        int tipoBucle = int.Parse(Console.ReadLine());

        switch (tipoBucle)
        {
            case 1:
                int i = 100;
                while (i >= 1)
                {
                    Console.WriteLine(i);
                    i -= 2;
                }
                break;

            case 2:
                int j = 100;
                do
                {
                    Console.WriteLine(j);
                    j -= 2;
                } while (j >= 1);
                break;

            case 3:
                for (int k = 100; k >= 1; k -= 2)
                {
                    Console.WriteLine(k);
                }
                break;

            default:
                Console.WriteLine("Tipo de bucle no válido");
                break;
        }
    }

    static void MostrarTablaMultiplicar()
    {
        Console.WriteLine("Subprograma 2: Mostrar tabla de multiplicar");

        Console.WriteLine("Ingrese un número para mostrar su tabla de multiplicar:");
        int numero = int.Parse(Console.ReadLine());

        Console.WriteLine("Elija el tipo de bucle (1: While, 2: Do/While, 3: For):");
        int tipoBucle = int.Parse(Console.ReadLine());

        switch (tipoBucle)
        {
            case 1:
                int i = 1;
                while (i <= 12)
                {
                    Console.WriteLine($"{numero} x {i} = {numero * i}");
                    i++;
                }
                break;

            case 2:
                int j = 1;
                do
                {
                    Console.WriteLine($"{numero} x {j} = {numero * j}");
                    j++;
                } while (j <= 12);
                break;

            case 3:
                for (int k = 1; k <= 12; k++)
                {
                    Console.WriteLine($"{numero} x {k} = {numero * k}");
                }
                break;

            default:
                Console.WriteLine("Tipo de bucle no válido");
                break;
        }
    }

    static void CalcularSumaYPromedio()
    {
        Console.WriteLine("Subprograma 3: Calcular suma y promedio");

        Console.WriteLine("Ingrese la cantidad de montos:");
        int cantidadMontos = int.Parse(Console.ReadLine());

        int suma = 0;

        Console.WriteLine("Elija el tipo de bucle (1: While, 2: Do/While, 3: For):");
        int tipoBucle = int.Parse(Console.ReadLine());

        switch (tipoBucle)
        {
            case 1:
                int i = 1;
                while (i <= cantidadMontos)
                {
                    Console.WriteLine($"Ingrese el monto #{i}:");
                    int monto = int.Parse(Console.ReadLine());
                    suma += monto;
                    i++;
                }
                break;

            case 2:
                int j = 1;
                do
                {
                    Console.WriteLine($"Ingrese el monto #{j}:");
                    int monto = int.Parse(Console.ReadLine());
                    suma += monto;
                    j++;
                } while (j <= cantidadMontos);
                break;

            case 3:
                for (int k = 1; k <= cantidadMontos; k++)
                {
                    Console.WriteLine($"Ingrese el monto #{k}:");
                    int monto = int.Parse(Console.ReadLine());
                    suma += monto;
                }
                break;

            default:
                Console.WriteLine("Tipo de bucle no válido");
                break;
        }

        double promedio = (double)suma / cantidadMontos;

        Console.WriteLine($"La suma de los montos es: {suma}");
        Console.WriteLine($"El promedio de los montos es: {promedio}");
    }

    static void RepetirNombre()
    {
        Console.WriteLine("Subprograma 4: Adivina el nombre");

        int contadorNombres = 0;

        Console.WriteLine("Elija el tipo de bucle (1: While, 2: Do/While, 3: For):");
        int tipoBucle = int.Parse(Console.ReadLine());

        switch (tipoBucle)
        {
            case 1:
                while (true)
                {
                    Console.WriteLine("Ingrese un nombre (va a tener un maximo de 7 intentos para adivinar):");
                    string nombre = Console.ReadLine();

                    if (nombre.ToLower() == "jose" || contadorNombres >= 7)
                        break;

                    contadorNombres++;
                }
                break;

            case 2:
                do
                {
                    Console.WriteLine("Ingrese un nombre (va a tener un maximo de 7 intentos para adivinar):");
                    string nombre = Console.ReadLine();

                    if (nombre.ToLower() == "jose" || contadorNombres >= 7)
                        break;

                    contadorNombres++;
                } while (true);
                break;

            case 3:
                for (int i = 0; i < 7; i++)
                {
                    Console.WriteLine("Ingrese un nombre (va a tener un maximo de 7 intentos para colocar jose):");
                    string nombre = Console.ReadLine();

                    if (nombre.ToLower() == "jose" || contadorNombres >= 7)
                        break;

                    contadorNombres++;
                }
                break;

            default:
                Console.WriteLine("Tipo de bucle no válido");
                break;
        }
    }
}