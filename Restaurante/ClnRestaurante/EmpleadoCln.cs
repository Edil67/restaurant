using CadRestaurante;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnRestaurante
{
    public class EmpleadoCln
    {
        public static int insertar(Empleado empleado)
        {
            using (var context = new LabRestauranteEntities())
            {
                context.Empleado.Add(empleado);
                context.SaveChanges();
                return context.SaveChanges();
            }
        }
        public static int actualizar(Empleado empleado) 
        {
            using (var context = new LabRestauranteEntities())
            {

            }
        }
        public static List<CadRestaurante.Empleado> listar()
        {
            using (var context = new LabRestauranteEntities())
            {
                return context.Empleado.Where(x => x.estado != -1).ToList();
            }
        }
        public static List<paEmpleadoListar_Result> listarPa(string parametro)
        {
            using (var context = new LabRestauranteEntities())
            {
                return context.paEmpleadoListar(parametro).ToList();
            }
        }

    }
}
