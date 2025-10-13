using CadRestaurante;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnRestaurante
{
    public class MenuCln
    {
        private static object[] id;

        public static int insertar(Menu menu)
        {
            using (var context = new LabRestauranteEntities())
            {
                context.Menu.Add(menu);
                context.SaveChanges();
                return context.SaveChanges();
            }
        }
        public static int actualizar(Menu menu)
        {
            using (var context = new LabRestauranteEntities())
            {
                var existente = context.Menu.Find(menu.id);
                existente.idTipoMenu = menu.idTipoMenu;
                existente.nombre = menu.nombre;
                existente.descripcion = menu.descripcion;
                existente.precio = menu.precio;
                existente.usuarioRegistro = menu.usuarioRegistro;
                return context.SaveChanges();
            }
        }
        public static int eliminar(int id, string usuarioRegistro)
        {
            using (var context = new LabRestauranteEntities())
            {
                var existe = context.Menu.Find(id);
                existe.estado = -1;
                existe.usuarioRegistro = usuarioRegistro;
                return context.SaveChanges();
            }
        }
        public static Menu obtener(int id)
        {
            using (var context = new LabRestauranteEntities())
            {
                return context.Menu.Find(id);
            }
        }
        public static List<Menu>listar()
        {
             using (var context = new LabRestauranteEntities())
            {
                return context.Menu.Where(x => x.estado == 1).ToList();
            }
        }
        public static List<paMenuListar_Result> listarPa(string parametro)
        {
            using (var context = new LabRestauranteEntities())
            {
                return context.paMenuListar(parametro).ToList();
            }
        }
    }
}
