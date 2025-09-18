using ClasesEjercicioPrueba.Data1;
using ClasesEjercicioPrueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesGestionEmpresa.Repository
{
    public static class DepartamentoRepository
    {
        public static bool ExisteDepartamento(string nombreDep)
        {
            using var context = new ApplicationDbContext();
            return context.departamentos.Any(d => d.nombre == nombreDep);
        }
        public static void RegistrarDepartamento(Departamento departamento)
        {
            using var context = new ApplicationDbContext();
            if (departamento.nombre != null)
            {
                context.departamentos.Add(departamento);
            }
            context.SaveChanges();
        }
    }
}
