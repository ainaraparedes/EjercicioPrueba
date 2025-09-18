namespace ClasesEjercicioPrueba.Models
{
    //Empleado: Id, Nombre, Email, id Departamento, Salario.
    public class Empleado
    {
        public int EmpleadoId { get; set; }
        public string nombre { get; set; }
        public string email { get; set; }
        public decimal salario { get; set; }
        public int departamentoId { get; set; }
        public Empleado( string nombre, string email, decimal salario, int departamentoId)
        {
            this.EmpleadoId = GestorId.ObtenerSiguiente();
            this.nombre = nombre;
            this.email = email;
            this.salario = salario;
            this.departamentoId = departamentoId;
        }

    }
}
