using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entities;
namespace DataAccesLogic
{
   public class empleadoDAL
    {
        public int agregar(empleado pn)
        {
            IDbConnection _con = conexion.cnbd();
            _con.Open();
            SqlCommand comando = new SqlCommand("ingresar_empleado", _con as SqlConnection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add(new SqlParameter("@nombre", pn.nombre));
            comando.Parameters.Add(new SqlParameter("@apellido", pn.apellido));
            comando.Parameters.Add(new SqlParameter("@fechan", pn.fecha_nacimiento));
            comando.Parameters.Add(new SqlParameter("@dui", pn.dui));
            comando.Parameters.Add(new SqlParameter("@contacto", pn.contacto));
            comando.Parameters.Add(new SqlParameter("@dirrecion", pn.dirrecion));
            comando.Parameters.Add(new SqlParameter("@cargo", pn.fk_cargo));
            int resultado = comando.ExecuteNonQuery();
            _con.Close();
            return resultado;

        }
        public int actualizar(empleado pn)
        {
            IDbConnection _con = conexion.cnbd();
            _con.Open();
            SqlCommand comando = new SqlCommand("actualizar_empleados", _con as SqlConnection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add(new SqlParameter("@id", pn.id));
            comando.Parameters.Add(new SqlParameter("@nombre", pn.nombre));
            comando.Parameters.Add(new SqlParameter("@apellido", pn.apellido));
            comando.Parameters.Add(new SqlParameter("@fechan", pn.fecha_nacimiento));
            comando.Parameters.Add(new SqlParameter("@dui", pn.dui));
            comando.Parameters.Add(new SqlParameter("@contacto", pn.contacto));
            comando.Parameters.Add(new SqlParameter("@dirrecion", pn.dirrecion));
            comando.Parameters.Add(new SqlParameter("@cargo", pn.fk_cargo));
            int resultado = comando.ExecuteNonQuery();
            _con.Close();
            return resultado;

        }

        public int eliminar(empleado pn)
        {
            IDbConnection _con = conexion.cnbd();
            _con.Open();
            SqlCommand comando = new SqlCommand("eliminar_empleado", _con as SqlConnection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add(new SqlParameter("@id", pn.id));
            int resultado = comando.ExecuteNonQuery();
            _con.Close();
            return resultado;

        }

        public List<empleado> mostrar()
        {
            IDbConnection _con = conexion.cnbd();
            _con.Open();
            SqlCommand comando = new SqlCommand("mostrar_empledo", _con as SqlConnection);
            comando.CommandType = CommandType.StoredProcedure;
            IDataReader lector = comando.ExecuteReader();
            List<empleado> lista = new List<empleado>();
            while (lector.Read())
            {
                empleado c = new empleado();
                c.id = lector.GetInt32(0);
                c.nombre = lector.GetString(1);
                c.apellido = lector.GetString(2);
                c.fecha_nacimiento = lector.GetDateTime(3);
                c.sexo = lector.GetInt32(4);
                c.dui = lector.GetInt32(5);
                c.contacto = lector.GetString(6);
                c.dirrecion = lector.GetString(7);
                c.fk_cargo = lector.GetInt32(8);
                c.nombresexo = lector.GetString(8);
                c.nombrecargo = lector.GetString(9);
                lista.Add(c);

            }
            _con.Close();
            return lista;

        }

    }
}
