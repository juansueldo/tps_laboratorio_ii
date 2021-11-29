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
        private const string localHost = "Data Source=JUAN; Database = TP4RECUPERATORIO; Trusted_Connection = true;";
        private static SqlCommand comando;
        public static SqlConnection conexion = new SqlConnection();

        static ConexionBD()
        {
            conexion.ConnectionString = localHost;
            comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.Connection = conexion;
        }
        public static List<Programador> Leer()
        {
            Proyecto proyecto = new Proyecto();
            Programador programador = new Programador();
            try
            {
                comando.CommandText = "Select * from ListaProgramadores";
                conexion.Open();
                SqlDataReader myReader = comando.ExecuteReader();
                while (myReader.Read())
                {
                    programador.Legajo = (short)myReader["idLegajo"];
                    programador.Nombre = myReader["nombre"].ToString();
                    programador.Apellido = myReader["apellido"].ToString();
                    programador.Genero = (Genero)Enum.Parse(typeof(Genero),myReader["genero"].ToString());
                    programador.Edad = (short)myReader["edad"]; 
                    programador.Puesto = (Puesto)Enum.Parse(typeof(Puesto),myReader["puesto"].ToString());
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
            return proyecto.Programadores;
        }
        public static bool Guardar(Programador programador)
        {
            string insert = $"INSERT INTO Programadores(idLegajo,nombre,apellido,genero,edad,puesto) ";
            string parameters = $" VALUES(@idLegajo,@nombre,@apellido,@genero,@edad,@puesto)";
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
                comando.Parameters.AddWithValue("@edad", (int)programador.Edad);
                comando.Parameters.AddWithValue("@puesto", (int)programador.Puesto);
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
    }
}
