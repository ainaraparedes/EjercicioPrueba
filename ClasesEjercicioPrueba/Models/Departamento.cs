using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesEjercicioPrueba.Models
{
    //Departamento: Id, Nombre, Descripcion.
    public class Departamento
    {
        [Key]
        public int DepartamentoId { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public List<Empleado> empleados { get; set; }
        public Departamento(string nombre, string descripcion)
        {
            this.DepartamentoId = GestorId.ObtenerSiguiente();
            this.nombre = nombre;
            this.descripcion = descripcion;
            empleados = new List<Empleado>();
        }
    }
}
