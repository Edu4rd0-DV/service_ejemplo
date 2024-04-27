using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLogic;
using Entities;
namespace BussinesLogic
{
     public class bitacoraBL
    {
        bitacoraDAL dal = new bitacoraDAL();
        public int agregar(bitacora pn)
        {
            return dal.agregar(pn);
        }
        public int eliminar(bitacora pn)
        {
            return dal.eliminar(pn);
        }
        public List<bitacora> mostrar()
        {
            return dal.mostrar();
        }

    }
}
