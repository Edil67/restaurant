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
        public static List<TipoMenu> listar()
        {
            using (var context = new LabRestauranteEntities())
            {
                return context.TipoMenu
                    .Where(x => x.estado == 1)
                    .OrderBy(x => x.descripcion)
                    .ToList();
            }
        }
    }
}
