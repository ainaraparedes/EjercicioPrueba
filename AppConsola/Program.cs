using ClasesEjercicioPrueba.Models;
using ClasesEjercicioPrueba.Repository;
using ClasesGestionEmpresa.Repository;
class Program
{
    static void Main(string[] args)
    {
        bool salir = false;
        while(!salir)
        {
            Console.WriteLine("---MENÚ PRINCIPAL---");
            Console.WriteLine("1. Registrar nuevo Empleado");
            Console.WriteLine("2. Actualizar salario de empleado");
            Console.WriteLine("3. Eliminar empleado");
            Console.WriteLine("4. Registrar nuevo departamento");
            Console.WriteLine("5. Estadísticas de empleados");
            Console.WriteLine("6. Salir");
            Console.WriteLine("Selecciona una opción: ");
            string opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Ingrese el nombre del empleado: ");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese el email del empleado: ");
                    string email = Console.ReadLine();
                    Console.WriteLine("Ingrese el salario del empleado: ");
                    decimal salario = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Ingrese el ID del departamento del empleado: ");
                    int departamentoId = Convert.ToInt32(Console.ReadLine());
                    Empleado empleado1 = new Empleado(nombre, email, salario, departamentoId);
                    EmpleadoRepository.RegistrarEmpleado(empleado1);
                    break;
                case "2":
                    Console.WriteLine("Ingresa el email del empleado: ");
                    string emailActualizar = Console.ReadLine();
                    Console.WriteLine("Ingresa el nuevo salario: ");
                    decimal nuevoSalario = Convert.ToDecimal(Console.ReadLine());
                    EmpleadoRepository.ActualizarSalario(emailActualizar, nuevoSalario);
                    break;
                case "3":
                    Console.WriteLine("Ingrese el email del empleado: ");
                    string emailEliminar = Console.ReadLine();
                    bool eliminado = EmpleadoRepository.EliminarPorEmail(emailEliminar);
                    if (eliminado)
                    {
                        Console.WriteLine("Empleado eliminado correctamente.");
                    }
                    else
                    {
                        Console.WriteLine("No se encontró un empleado con ese email.");
                    }
                    break;
                case "4":
                    Console.WriteLine("---NUEVO DEPARTAMENTO A REGISTRAR---");
                    Console.WriteLine("Ingrese nombre del departamento: ");
                    string nombreDepartamento = Console.ReadLine();
                    Console.WriteLine("Ingrese descripción del departamento: ");
                    string descripcionDepartamento = Console.ReadLine();
                    if (DepartamentoRepository.ExisteDepartamento(nombreDepartamento))
                    {
                        Console.WriteLine("Ese departamento ya existe.");
                    }
                    Departamento departamento = new Departamento( nombreDepartamento, descripcionDepartamento);
                    DepartamentoRepository.RegistrarDepartamento(departamento);
                    break;
                case "5":

                    break;
                case "6":
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        }
    }
    


}
