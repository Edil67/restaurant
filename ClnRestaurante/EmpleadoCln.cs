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
                var existe = context.Empleado.Find(empleado.id);
                existe.nombre = empleado.nombre;
                existe.primerApellido = empleado.primerApellido;
                existe.segundoApellido = empleado.segundoApellido;
                existe.telefono = empleado.telefono;
                existe.direccion = empleado.direccion;
                existe.cargo = empleado.cargo;
                existe.usuarioRegistro = empleado.usuarioRegistro;
                return context.SaveChanges();
            }
        }
        public static int eliminar(int id, string usuarioRegistro)
        {
            using (var context = new LabRestauranteEntities())
            {
                var existe = context.Empleado.Find(id);
                existe.estado = -1;
                existe.usuarioRegistro = usuarioRegistro;
                return context.SaveChanges();
            }
        }
        public  static Empleado obtener(int id)
        {
            using (var context = new LabRestauranteEntities())
            {
                return context.Empleado.Find(id);
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
