using System;
using espacioCargos;

namespace EspacioEmpleado;

public class Empleado
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public DateTime FechaDeNacimiento { get; set; }
    public char EstadoCivil { get; set; }

    public DateTime FechaDeIngreso { get; set; }
    public double SueldoBasico { get; set; }

    public Cargos Cargo { get; set; }

    public Empleado(string nombre, string apellido, DateTime fechaNac, 
                    DateTime fechaIng, double sueldo, Cargos cargo, char estadoCivil)
    {
        Nombre = nombre;
        Apellido = apellido;
        FechaDeNacimiento = fechaNac;
        FechaDeIngreso = fechaIng;
        SueldoBasico = sueldo;
        Cargo = cargo;
        EstadoCivil = estadoCivil;
    }

    // se calcula la fecha de hoy el anios menos los anos de la fecha de ingreso
    public int Antiguedad => DateTime.Now.Year - FechaDeIngreso.Year;
    public int Edad => DateTime.Now.Year - FechaDeNacimiento.Year;
     public int AñosParaJubilarse => Math.Max(0, 65 - Edad);
    // Método con lógica de negocio
    public double CalcularSalario()
    {
        /*Calcular salario
        decimal Salario;
        decimal Adicional;
            1% del sueldo basico por cada anio de antiguedad
            seria sacar el 1% del sueldo basico multiplicalo por la cantidad
            de anios hasta los 20  si es mayor fijar el porcentaje en 25% devuelve
            porcentaje de aumento al sueldo bruto
            aumentoAntiguedad

            si anios de atiguedad < 20
                aumentoAntiguedad <- sacar 1% sueldo basico por anios de antiguedad
            sino
                aumentoAntiguedad <- sueldo basico aumento 25%
                
            finsi
            Adicional = aumentoAntiguedad
            
            aumento por cargo 
            si el cargo es ingeniero o especialista 
             adicional <- adicional * 1.5 

            si estado civil es casado 
             adicional <- adicional + 150mil

            Salario = sueldobasico + adicional

            retorna Salario
        */
        double Salario;
        double Adicional;
        double AumentoporAntiguedad;
        
        if (Antiguedad >= 20)
        {
            AumentoporAntiguedad = SueldoBasico * 0.25;
        }
        else
        {
            AumentoporAntiguedad = SueldoBasico * 0.01 * Antiguedad;
        }
        Adicional = AumentoporAntiguedad;

        if (Cargo == Cargos.Ingeniero || Cargo == Cargos.Especialista)
        {
            Adicional *= 1.50;
        }
        if (EstadoCivil == 'C')
        {
            Adicional += 150000;
        }
        
        return Salario = SueldoBasico + Adicional;
    }
}