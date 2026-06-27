using EspacioEmpleado;
using espacioCargos;

Empleado[] empleados = new Empleado[]
{
    new Empleado("Juan", "Perez", new DateTime(1980, 10, 11), new DateTime(2000, 11, 22), 2000000, Cargos.Ingeniero, 'C'),
    new Empleado("Maria", "Gomez", new DateTime(1990, 5, 15), new DateTime(2015, 3, 10), 1500000, Cargos.Administrativo, 'S'),
    new Empleado("Carlos", "Lopez", new DateTime(1970, 8, 20), new DateTime(1995, 1, 5), 1800000, Cargos.Especialista, 'C')
};

foreach (var emp in empleados)
{
    Console.WriteLine($"{emp.Nombre} {emp.Apellido} - Edad: {emp.Edad} - Salario: {emp.CalcularSalario():C}");
}
