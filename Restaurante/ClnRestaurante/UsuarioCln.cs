using CadRestaurante;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnRestaurante
{
    public class UsuarioCln
    {
        public static int insertar(Usuarios usuario)
        {
            using (var context = new LabRestauranteEntities())
            {
                context.Usuarios.Add(usuario);
                context.SaveChanges();
                return usuario.id;
            }
        }
        public static int actualizar(Usuarios usuario)
        {
            using (var context = new LabRestauranteEntities())
            {
                var existente = context.Usuarios.Find(usuario.id);
                existente.usuario=usuario.usuario;
                existente.usuarioRegistro = usuario.usuarioRegistro;
                return context.SaveChanges();
            }
        }
        public static int eliminar(int id, string usuarioRegistro)
        {
            using (var context = new LabRestauranteEntities())
            {
                var existe = context.Usuarios.Find(id);
                existe.estado = -1;
                existe.usuarioRegistro = usuarioRegistro;
                return context.SaveChanges();
            }
        }
        public static Usuarios obtener(int id)
        {
            using (var context = new LabRestauranteEntities())
            {
                return context.Usuarios.Find(id);
            }
        }
        public static Usuarios validar(string usuario, string clave)
        {
            using (var context = new LabRestauranteEntities())
            {
                return context.Usuarios
                    .Where(x => x.usuario == usuario && x.clave == clave && x.estado == 1).FirstOrDefault();
            }
        }
    }
}
