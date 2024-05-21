using EspacioCalculadora;
//Enu define un dominio, define los tio de dato
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
    Console.WriteLine("Salir -> Presione cualquier tecla");
    Console.Write("\nIngrese opcion: ");
    opcion = ingresaEntero();
    switch (opcion)
    {
        case 1:
            valorAntesDeOperar=calcula.Resultado;
            Console.Write("\nValor actual: "+valorAntesDeOperar);
            Console.Write("\nIngrese numero que desea sumar: ");
            x = ingresarNumeroReal();
            calcula.Sumar(x);
            Console.WriteLine("\nEl resultado de "+valorAntesDeOperar+" + "+x+" es: "+calcula.Resultado);
            Console.Write("\nPrecione una tecla para continuar\t");
            Console.ReadKey();
            break;
        case 2:
        break;
      case 3:
        break;
      case 4:
        break;
      default:
        Console.WriteLine("\nOpcion no valida. Saliendo del programa");
        return 0; //Termina el programa
    }
} while (opcion==1 || opcion==2 || opcion==3 || opcion==4);
return 0;

int ingresaEntero(){
  int num;
  if(int.TryParse(Console.ReadLine(), out num)){
    //int.Tryparse -> devuelve un booleano, si es que se puede converttir da true
    return num;
  } else{
    return -999;
  }
}

double ingresaReal(){
  double num;
  if(double.TryParse(Console.ReadLine(), out num)){
    return num;
  } else{
    return -999;
  }
}

double ingresarNumeroReal()
{
    double a;
    do
    {
        a = ingresaReal();
    } while (a == -999);
    return a;
}