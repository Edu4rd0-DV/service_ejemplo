using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLogic;
using Entities;
namespace BussinesLogic
{
    public class cargoBL
    {
        cargoDAL dal = new cargoDAL();
        public int agregar(cargo pn)
        {
            return dal.agregar(pn);
        }
        public int actualizar(cargo pn)
        {
            return dal.actulalizar(pn);

        }
        public int eliminar (cargo pn)
        {
            return dal.eliminar(pn);
        }
        public List<cargo> mostrar() {
            return dal.mostrar();
        }
    }
}
