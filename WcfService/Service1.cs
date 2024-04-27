using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BussinesLogic;
using Entities;
namespace WcfService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class Service1 : IService1
    {
        cargoBL _bl = new cargoBL();
        public int agregar_cargo(cargo pen)
        {
            return _bl.agregar(pen);
        }
        public int actualizar_cargo(cargo pen)
        {
            return _bl.actualizar(pen);
        }
        public int eliminar_cargo(cargo pen)
        {
            return _bl.eliminar(pen);
        }
        public List<cargo> mostrar_cargo()
        {
            return _bl.mostrar();
        }
        //-----------------------------------------
        sexoBL _bl2 = new sexoBL();
        public int agregar_sexo(sexo pen2)
        {
            return _bl2.agregar(pen2);
        }
        public int actualizar_sexo(sexo pen2)
        {
            return _bl2.actualizar(pen2);
        }
        public int eliminar_sexo(sexo pen2)
        {
            return _bl2.eliminar(pen2);
        }
        public List<sexo> mostrar_sexo()
        {
            return _bl2.mostrar();
        }
        //---------------------------------------------------
        empleadoBL _bl3 = new empleadoBL();
        public int agregar_empleado(empleado pen3)
        {
            return _bl3.agregar(pen3);
        }
        public int actualizar_empleado(empleado pen3)
        {
            return _bl3.actualizar(pen3);
        }
        public int eliminar_empleado(empleado pen3)
        {
            return _bl3.eliminar(pen3);
        }
        public List<empleado> mostrar_empleado()
        {
            return _bl3.mostrar();
        }
        //--------------------------------------------------------
        usuarioBL _bl4 = new usuarioBL ();
        public int agregar_usuario(usuario pen4)
        {
            return _bl4.agregar(pen4);
        }
        public int actualizar_usuario(usuario pen4)
        {
            return _bl4.actualizar(pen4);
        }
        public int eliminar_usuario(usuario pen4)
        {
            return _bl4.eliminar(pen4);
        }
        public List<usuario> mostrar_usuario()
        {
            return _bl4.mostrar();
        }
        //---------------------------------------------------------------
        bitacoraBL _bl5 = new bitacoraBL();
        public int agregar_bitacora(bitacora  pen5)
        {
            return _bl5.agregar(pen5);
        }
        public int eliminar_bitacora(bitacora pen5)
        {
            return _bl5.eliminar(pen5);
        }
        public List<bitacora> mostrar_bitacora()
        {
            return _bl5.mostrar();
        }
    }
}
