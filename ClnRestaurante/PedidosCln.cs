using CadRestaurante;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace ClnRestaurante
{
    public class PedidosCln
    {
        public static int insertar(Pedidos pedidos)
        {
            using (var context = new LabRestauranteEntities())
            {
                context.Pedidos.Add(pedidos);
                context.SaveChanges();
                return pedidos.id;
            }
        }
        public static int actualizar(Pedidos pedidos)
        {
            using (var context = new LabRestauranteEntities())
            {
                var existente = context.Pedidos.Find(pedidos.id);
                existente.fechaPedido = pedidos.fechaPedido;
                existente.total = pedidos.total;
                existente.estado = pedidos.estado;
                existente.usuarioRegistro = pedidos.usuarioRegistro;
                return context.SaveChanges();
            }
        }
        public static int eliminar(int id, string usuario)
        {
            using (var context = new LabRestauranteEntities())
            {
                var existe = context.Pedidos.Find(id);
                existe.estado = -1;
                existe.usuarioRegistro = usuario;
                return context.SaveChanges();
            }
        }
        public static Pedidos obtener(int id)
        {
            using (var context = new LabRestauranteEntities())
            {
                return context.Pedidos.Find(id);
            }
        }
        public static List<Pedidos> listar()
        {
            using (var context = new LabRestauranteEntities())
            {
                return context.Pedidos.Where(x => x.estado == 1).ToList();
            }
        }
        public static List<paPedidosListar_Result> listarPa(string parametro)
        {
            using (var context = new LabRestauranteEntities())
            {
                return context.paPedidosListar(parametro).ToList();
            }
        }
    }
}
