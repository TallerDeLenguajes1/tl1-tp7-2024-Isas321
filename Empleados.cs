
namespace EspacioEmpleados;

public class Empleado{

  public enum Cargos{
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador
  }
  private string nombre;
  private string apellido;
  private DateTime fecha_nac;
  private char estado_civil;
  private DateTime fecha_ingreso;
  private double sueldo_basico;
  private Cargos cargo;

  public string Nombre { get => nombre; set => nombre = value; }
  public string Apellido { get => apellido; set => apellido = value; }
  public DateTime Fecha_nac { get => fecha_nac; set => fecha_nac = value; }
  public char Estado_civil { get => estado_civil; set => estado_civil = value; }
  public DateTime Fecha_ingreso { get => fecha_ingreso; set => fecha_ingreso = value; }
  public double Sueldo_basico { get => sueldo_basico; set => sueldo_basico = value; }
  public Cargos Cargo { get => cargo; set => cargo = value; }

  public Empleado(string nombre, string apellido, DateTime fecha_nac, char estado_civil, DateTime fecha_ingreso, double sueldo_basico, Cargos cargo)
  {
      Nombre = nombre;
      Apellido = apellido;
      Fecha_nac = fecha_nac;
      Estado_civil = estado_civil;
      Fecha_ingreso = fecha_ingreso;
      Sueldo_basico = sueldo_basico;
      Cargo = cargo;
  }

  public void mostrarEmpleado(){
    Console.WriteLine($"Apellido y nombre: {Apellido}, {Nombre}");
    Console.WriteLine($"Fecha de nacimiento: {Fecha_nac}");
    Console.WriteLine($"Estado civil: {Estado_civil}");
    Console.WriteLine($"Fecha de ingreso: {Fecha_ingreso}");
    Console.WriteLine($"Sueldo basico: {Sueldo_basico}");
    Console.WriteLine($"Cargo: {Cargo}");
  }
}