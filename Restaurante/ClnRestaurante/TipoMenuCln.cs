using CadRestaurante;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnRestaurante
{
    public class TipoMenuCln
    {
        public static int insertar(TipoMenu tipoMenu)
        {
            using (var context = new LabRestauranteEntities())
            {
                context.TipoMenu.Add(tipoMenu);
                context.SaveChanges();
                return tipoMenu.id;
            }
        }
        public static int actualizar(TipoMenu tipoMenu)
        {
            using (var context = new LabRestauranteEntities())
            {
                var existente = context.TipoMenu.Find(tipoMenu.id);
                existente.descripcion = tipoMenu.descripcion;
                existente.usuarioRegistro = tipoMenu.usuarioRegistro;
                return context.SaveChanges();
            }
        }
        public static int eliminar(int id, string usuario)
        {
            using (var context = new LabRestauranteEntities())
            {
                var existe = context.TipoMenu.Find(id);
                existe.estado = -1;
                existe.usuarioRegistro = usuario;
                return context.SaveChanges();
            }
        }
        public static TipoMenu obtener(int id)
        {
            using (var context = new LabRestauranteEntities())
            {
                return context.TipoMenu.Find(id);
            }
        }
        public static List<TipoMenu> listar(string parametro="")
        {
            using (var context = new LabRestauranteEntities())
            {
                return context.TipoMenu
                    .Include("Menu")
                    .Where(x => x.estado == 1)
                    .ToList();
            }
        }
        public static List<paTipoMenuListar_Result> listarPa(string parametro)
        {
            using (var context = new LabRestauranteEntities())
            {
                return context.paTipoMenuListar(parametro).ToList();
            }
        }
        public static bool existeDescripcion(string descripcion)
        {
            using (var context = new LabRestauranteEntities())
            {
                return context.TipoMenu.Any(c => c.descripcion.Equals
                (descripcion, StringComparison.OrdinalIgnoreCase) && c.estado != -1);
            }
        }
    }
}
