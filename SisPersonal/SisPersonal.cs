// See https://aka.ms/new-console-template for more information

namespace GestionEmpleados
{
    public enum Cargos
    {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }
    public class Empleado
    {
        private string? nombre;
        private string? apellido;
        private DateTime fechaNacimiento;
        private char estadoCivil;
        private DateTime fechaIngreso;
        private double sueldoBasico;
        private Cargos cargo;

        public Empleado(string nombre, string apellido, DateTime fechaNacimiento, char estadoCivil,
                        DateTime fechaIngreso, double sueldoBasico, Cargos cargo)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.FechaNacimiento = fechaNacimiento;
            this.EstadoCivil = estadoCivil;
            this.FechaIngreso = fechaIngreso;
            this.SueldoBasico = sueldoBasico;
            this.Cargo = cargo;
        }

        public string? Nombre
        {
            get => nombre;
            set => nombre = value;
        }
        public string? Apellido
        {
            get => apellido;
            set => apellido = value;
        }
        public DateTime FechaNacimiento
        {
            get => fechaNacimiento;
            set => fechaNacimiento = value;
        }
        public char EstadoCivil
        {
            get => estadoCivil;
            set => estadoCivil = value;
        }
        public DateTime FechaIngreso
        {
            get => fechaIngreso;
            set => fechaIngreso = value;
        }
        public double SueldoBasico
        {
            get => sueldoBasico;
            set => sueldoBasico = value;
        }
        public Cargos Cargo
        {
            get => cargo;
            set => cargo = value;
        }

        public int ObtenerAntiguedad()
        {
            int antiguedad = DateTime.Now.Year - FechaIngreso.Year;
            if (DateTime.Now.Date < FechaIngreso.AddYears(antiguedad))
                antiguedad--;
            return antiguedad;
        }

        public int ObtenerEdad()
        {
            int edad = DateTime.Now.Year - FechaNacimiento.Year;
            if(DateTime.Now.Date < FechaNacimiento.AddYears(edad))
                edad --;
            return edad;
        }

        public int aniosJubi()
        {
            int edad = ObtenerEdad();
            if (edad >= 65)
            {
                return 0;
            }else
            {
                return 65 - edad;
            }
        }

        public double CalcularSalario()
        {
            double adicional = 0;

            int antiguedad = ObtenerAntiguedad();
            if (antiguedad <= 20)
            {
                adicional = SueldoBasico * (0.01 * antiguedad);
            }
            else
            {
                adicional = SueldoBasico * 0.25;
            }

            if (Cargo == Cargos.Ingeniero || Cargo == Cargos.Especialista)
            {
                adicional *= 1.5;
            }

            if (EstadoCivil == 'C' || EstadoCivil == 'c')
            {
                adicional += 150000;
            }

            return SueldoBasico + adicional;
        }
    }
}