using ClasesEjercicioPrueba.Data1;
using ClasesEjercicioPrueba.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesEjercicioPrueba.Repository
{
    public static class EmpleadoRepository
    {
        public static void RegistrarEmpleado(Empleado empleado)
        {
            using var context = new ApplicationDbContext();
            if (empleado.email != null)
            {
                context.empleados.Add(empleado);
                context.SaveChanges();
            }
            
        }

        public static void ActualizarSalario(string email, decimal nuevoSalario)
        {
            using var context = new ApplicationDbContext();
            var empleado = context.empleados.Find(email);
            if (empleado != null)
            {
                empleado.salario = nuevoSalario;
                context.SaveChanges();
            }
        }
        public static bool EliminarPorEmail(string emailEliminar)
        {
            using var context = new ApplicationDbContext();
            var empleado = context.empleados.FirstOrDefault(e => e.email == emailEliminar);
            if (empleado == null) return false;

            context.empleados.Remove(empleado);
            context.SaveChanges();
            return true;
        }

        public static void ObtenerEstadisticas(Empleado empleado)
        {
            using var context = new ApplicationDbContext();
            var empleados = context.empleados.ToList();
            int total = empleados.Count;
            if (total <= 0)
            {
                Console.WriteLine("No hay empleados registrados.");
                return;
            }

        }


    }
}
