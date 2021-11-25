using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Data;

namespace Entidades
{
    public static class ConexionBD
    {
        private const string localHost = "JUAN";
        private static SqlCommand comando;
        private static SqlConnection conexion;

        static ConexionBD()
        {
            conexion = new SqlConnection(@"Server=" + localHost + "\\SQLEXPRESS; Database = TP4; Trusted_Connection = true;");
            comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.Connection = conexion;
        }
        public static Proyecto Leer()
        {
            Proyecto proyecto = new Proyecto();
            Programador programador;
            try
            {
                comando.CommandText = "Select * from Programadores";
                conexion.Open();
                SqlDataReader myReader = comando.ExecuteReader();
                while (myReader.Read())
                {
                    programador = new Programador((short)myReader["idLegajo"],myReader["nombre"].ToString(), myReader["apellido"].ToString(),(Genero)myReader["genero"],
                        (short)myReader["edad"],(Puesto)myReader["puesto"]);
                    proyecto += programador;
                }

                myReader.Close();
                conexion.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error de SQL", ex);
            }
            finally
            {
                conexion.Close();
            }
            return proyecto;
        }
        public static bool Guardar(Programador programador)
        {
            string insert = $"INSERT INTO Programadores(idLegajo,nombre,apellido,genero,puesto,edad) ";
            string parameters = $" VALUES(@idLegajo,@nombre,@apellido,@genero,@puesto,@edad)";
            string fullQuery = $"{insert}{parameters}";

            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                comando.CommandText = fullQuery;
                comando.Parameters.AddWithValue("@idLegajo", (int)programador.Legajo);
                comando.Parameters.AddWithValue("@nombre", programador.Nombre);
                comando.Parameters.AddWithValue("@apellido", programador.Apellido);
                comando.Parameters.AddWithValue("@genero", (int)programador.Genero);
                comando.Parameters.AddWithValue("@puesto", (int)programador.Puesto);
                comando.Parameters.AddWithValue("@edad", (int)programador.Edad);
                int rows = comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar SQL.", ex);
            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
        }
        public static void Insertar(Programador p)
        {
            try
            {
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO Paquetes VALUES(@idLegajo, @nombre, @apellido, @genero, @puesto, @edad)";
                comando.Parameters.Clear();
                comando.Parameters.Add(new SqlParameter("nombre", p.Legajo));
                comando.Parameters.Add(new SqlParameter("apellido", p.Nombre));
                comando.Parameters.Add(new SqlParameter("genero", p.Apellido));
                comando.Parameters.Add(new SqlParameter("puesto", p.Genero));
                comando.Parameters.Add(new SqlParameter("legajo", p.Puesto));
                comando.Parameters.Add(new SqlParameter("edad", p.Edad));
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                comando.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                throw new Exception("Error de SQL", ex);
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
