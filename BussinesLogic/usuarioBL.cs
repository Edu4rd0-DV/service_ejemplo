using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccesLogic;
namespace BussinesLogic
{
     public class usuarioBL
    {
        usuarioDAL dal = new usuarioDAL();
        public int agregar(usuario pn)
        {
            return dal.agregar(pn);
        }
        public int actualizar(usuario pn)
        {
            return dal.actualizar(pn);

        }
        public int eliminar(usuario pn)
        {
            return dal.eliminar(pn);
        }
        public List<usuario> mostrar()
        {
            return dal.mostrar();
        }
    }
}
