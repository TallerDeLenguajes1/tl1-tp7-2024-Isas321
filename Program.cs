using System;
using EspacioCalculadora;
using EspacioEmpleados;
//Enu define un dominio, define los tio de dato

class Program{
  static void Main(){
    int opcionPrincipal;
    do
    {
        Console.WriteLine("Menu:");
        Console.WriteLine("1. Calculadora");
        Console.WriteLine("2. Administracion de empleados");
        Console.WriteLine("0. Salir");

        Console.Write("Seleccione una opción: ");
        opcionPrincipal = int.Parse(Console.ReadLine());

        switch (opcionPrincipal)
        {
            case 1:
                Console.WriteLine("Has seleccionado Calculadora.");
                CalculadoraBasica();
                break;

            case 2:
                Console.WriteLine("Has seleccionado Administracion de empleados.");

                 Random random = new Random();
                string[] nombres = { "Juan", "Pedro", "Luis", "María", "Ana" };
                string[] apellidos = { "Gómez", "Pérez", "Rodríguez", "López", "Martínez" };
                DateTime[] fechasNac = {
                    new DateTime(1985, 3, 12),
                    new DateTime(1990, 7, 24),
                    new DateTime(1982, 11, 3),
                    new DateTime(1975, 5, 15),
                    new DateTime(2000, 2, 28)
                };
                char[] estadosCiviles = { 'C', 'S' };
                DateTime[] fechasIngreso = {
                    new DateTime(2010, 1, 10),
                    new DateTime(2015, 3, 5),
                    new DateTime(2020, 8, 20),
                    new DateTime(2012, 9, 13),
                    new DateTime(2018, 12, 1)
                };
                double[] sueldosBasicos = { 30000, 40000, 50000, 60000, 70000 };

                List<Empleado> empleados = new List<Empleado>();
                for (int i = 0; i < 3; i++)
                {

                  string nombre = nombres[random.Next(nombres.Length)];
                  string apellido = apellidos[random.Next(apellidos.Length)];
                  DateTime fecha_nac = fechasNac[random.Next(fechasNac.Length)];
                  char estado_civil = estadosCiviles[random.Next(estadosCiviles.Length)];
                  DateTime fecha_ingreso = fechasIngreso[random.Next(fechasIngreso.Length)];
                  double sueldo_basico = sueldosBasicos[random.Next(sueldosBasicos.Length)];
                  Empleado.Cargos cargo = (Empleado.Cargos)random.Next(Enum.GetValues(typeof(Empleado.Cargos)).Length);

                  Empleado empleado = new Empleado(nombre, apellido, fecha_nac, estado_civil, fecha_ingreso, sueldo_basico, cargo);
                  empleados.Add(empleado);
                }

                Console.WriteLine("Los empleados cargados son: ");
                foreach (var empleado in empleados)
                {
                  Console.WriteLine();
                  empleado.mostrarEmpleado();
                }

                break;
            
            case 0:
                Console.WriteLine("Saliendo del programa...");
                break;
            
            default:
                Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                break;
        }

        if (opcionPrincipal != 0)
        {
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }

    } while (opcionPrincipal != 0); 
  }

  static void CalculadoraBasica()
  {
      Calculadora calcula = new();
      int opcion;
      double x, valorAntesDeOperar;
      do
      {

          Console.WriteLine("\n\n\nCalculadora\n");
          Console.WriteLine("1-Sumar");
          Console.WriteLine("2-Restar");
          Console.WriteLine("3-Multiplicar");
          Console.WriteLine("4-Dividir");
          Console.WriteLine("5-Limpiar");
          Console.WriteLine("Salir -> Presione cualquier otra tecla");
          Console.Write("\nIngrese opcion: ");
          opcion = ingresaEntero();
          switch (opcion)
          {
              case 1:
                  valorAntesDeOperar = calcula.Resultado;
                  Console.Write("\nValor actual: " + valorAntesDeOperar);
                  Console.Write("\nIngrese numero que desea sumar: ");
                  x = ingresarNumeroReal();
                  calcula.Sumar(x);
                  Console.WriteLine("\nEl resultado de " + valorAntesDeOperar + " + " + x + " es: " + calcula.Resultado);
                  Console.Write("\nPrecione una tecla para continuar\t");
                  Console.ReadKey();
                  break;
              case 2:
                  valorAntesDeOperar = calcula.Resultado;
                  Console.Write("\nValor actual: " + valorAntesDeOperar);
                  Console.Write("\nIngrese numero que desea restar: ");
                  x = ingresarNumeroReal();
                  calcula.Restar(x);
                  Console.WriteLine("\nEl resultado de " + valorAntesDeOperar + " - " + x + " es: " + calcula.Resultado);
                  Console.Write("\nPrecione una tecla para continuar\t");
                  Console.ReadKey();
                  break;
              case 3:
                  valorAntesDeOperar = calcula.Resultado;
                  Console.Write("\nValor actual: " + valorAntesDeOperar);
                  Console.Write("\nIngrese numero por el que desea multiplicar: ");
                  x = ingresarNumeroReal();
                  calcula.Multiplicar(x);
                  Console.WriteLine("\nEl resultado de " + valorAntesDeOperar + " * " + x + " es: " + calcula.Resultado);
                  Console.Write("\nPrecione una tecla para continuar\t");
                  Console.ReadKey();
                  break;
              case 4:
                  valorAntesDeOperar = calcula.Resultado;
                  Console.Write("\nValor actual: " + valorAntesDeOperar);
                  Console.Write("\nIngrese numero por el que desea dividir: ");
                  do
                  {
                      x = ingresarNumeroReal();
                  } while (x == 0);
                  calcula.Dividir(x);
                  Console.WriteLine("\nEl resultado de " + valorAntesDeOperar + " / " + x + " es: " + calcula.Resultado);
                  Console.Write("\nPrecione una tecla para continuar\t");
                  Console.ReadKey();
                  break;
              case 5:
                  Console.WriteLine("\nSaliendo del programa...");
                  break;
          }
      } while (opcion == 1 || opcion == 2 || opcion == 3 || opcion == 4);
  }


  static int ingresaEntero(){
  int num;
  if(int.TryParse(Console.ReadLine(), out num)){
    //int.Tryparse -> devuelve un booleano, si es que se puede converttir da true
    return num;
  } else{
    return -999;
  }
}


  static double ingresaReal(){
  double num;
  if(double.TryParse(Console.ReadLine(), out num)){
    return num;
  } else{
    return -999;
  }
}

  static double ingresarNumeroReal()
  {
      double a;
      do
      {
          a = ingresaReal();
      } while (a == -999);
      return a;
  }
}
