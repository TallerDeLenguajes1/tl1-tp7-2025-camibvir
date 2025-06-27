using System;
using GestionEmpleados;

class AppMain
{
    static void Main(string[] args)
    {
        Empleado [] empleados = new Empleado [3];

        empleados [0] = new Empleado ("José", "Ruiz", new DateTime(1995, 3, 15), 'C', new DateTime(2020, 2, 15),
                        580000, Cargos.Ingeniero);
        empleados [1] = new Empleado ("Martin", "Araoz", new DateTime(1972, 10, 3), 'C', new DateTime(1995, 5, 27),
                        580000, Cargos.Especialista);
        empleados [2] = new Empleado ("José", "Ruiz", new DateTime(2000, 12, 20), 'S', new DateTime(2024, 9, 20),
                        580000, Cargos.Administrativo);
        
        double totalSalarios = 0;

        for (int i = 0; i < empleados.Length; i++)
        {
            double salario = empleados[i].CalcularSalario();
            totalSalarios += salario;
        }

        Console.WriteLine($"Monto total pagado en salarios: ${totalSalarios}");

        Empleado proximoJubilado = empleados[0];
        int minAniosParaJubilarse = empleados[0].aniosJubi();

        for (int i = 1; i < empleados.Length; i++)
        {
            int aniosRestantes = empleados[i].aniosJubi();
            if (aniosRestantes < minAniosParaJubilarse)
            {
                minAniosParaJubilarse = aniosRestantes;
                proximoJubilado = empleados[i];
            }
        }

        Console.WriteLine("Empleado más próximo a jubilarse:");
        Console.WriteLine($"Nombre: {proximoJubilado.Nombre} {proximoJubilado.Apellido}");
        Console.WriteLine($"Edad: {proximoJubilado.ObtenerEdad()} años");
        Console.WriteLine($"Antigüedad: {proximoJubilado.ObtenerAntiguedad()} años");
        Console.WriteLine($"Años para jubilarse: {proximoJubilado.aniosJubi()}");
        Console.WriteLine($"Salario final: ${proximoJubilado.CalcularSalario()}");
    }
}