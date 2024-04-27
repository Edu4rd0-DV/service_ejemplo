using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccesLogic;
namespace BussinesLogic
{
     public class empleadoBL
    {
        empleadoDAL dal = new empleadoDAL();
        public int agregar(empleado pn)
        {
            return dal.agregar(pn);
        }
        public int actualizar(empleado pn)
        {
            return dal.actualizar(pn);

        }
        public int eliminar(empleado pn)
        {
            return dal.eliminar(pn);
        }
        public List<empleado> mostrar()
        {
            return dal.mostrar();
        }
    }
}
