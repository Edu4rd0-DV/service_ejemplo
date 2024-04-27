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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        int agregar_cargo(cargo pen);

        [OperationContract]
        int actualizar_cargo(cargo pen);
        [OperationContract]
        int eliminar_cargo(cargo pen);
        [OperationContract]
        List<cargo> mostrar_cargo();
        //-----------------------------------------------------
        [OperationContract]
        int agregar_sexo(sexo pen);

        [OperationContract]
        int actualizar_sexo(sexo pen);
        [OperationContract]
        int eliminar_sexo(sexo pen);
        [OperationContract]
        List<sexo> mostrar_sexo();
        //-------------------------------------------------------
        [OperationContract]
        int agregar_empleado( empleado pen);

        [OperationContract]
        int actualizar_empleado(empleado pen);
        [OperationContract]
        int eliminar_empleado(empleado pen);
        [OperationContract]
        List<empleado> mostrar_empleado();
        //-------------------------------------------------------------------
        [OperationContract]
        int agregar_usuario(usuario pen);

        [OperationContract]
        int actualizar_usuario(usuario pen);
        [OperationContract]
        int eliminar_usuario(usuario pen);
        [OperationContract]
        List<usuario> mostrar_usuario();
        //--------------------------------------------------------------------
        [OperationContract]
        int agregar_bitacora(bitacora  pen);
        int eliminar_bitacora(bitacora pen);
        [OperationContract]
        List<bitacora> mostrar_bitacora();


    }
}
