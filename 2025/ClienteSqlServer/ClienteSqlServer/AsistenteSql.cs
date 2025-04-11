using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ClienteSqlServer
{
    public class AsistenteSql
    {
        private readonly string _cadenaDeConexion;

        /// <summary>
        /// Contructor de la clase.
        /// </summary>
        /// <param name="cadenaDeConexion">Cadena de conexión para base de datos SQL Server.</param>
        public AsistenteSql(string cadenaDeConexion)
        {
            this._cadenaDeConexion = cadenaDeConexion;
        }

        /// <summary>
        /// Ejecuta una consulta SQL y devuelve los resultados en una DataTable
        /// </summary>
        /// <param name="consulta">Consulta SELECT de SQL a ejecutar</param>
        /// <returns>DataTable</returns>
        /// <exception cref="Exception"></exception>
        public DataTable EjecutarConsulta(string consulta, SqlParameter[] parametros = null)
        {
            DataTable tablaDeDatos = new DataTable();

            try
            {
                using (SqlConnection conexion = new SqlConnection(this._cadenaDeConexion))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        if (parametros != null)
                            comando.Parameters.AddRange(parametros);

                        using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                        {
                            adaptador.Fill(tablaDeDatos);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al conectar o ejecutar consulta: {ex.Message}");
            }

            return tablaDeDatos;
        }

        /// <summary>
        /// Ejecuta consulta SQL y devuelve resultados mapeados a una lista de objetos 
        /// de tipo especificado.
        /// </summary>
        /// <typeparam name="T">Tipo de objeto al que se mapearan los resultados.</typeparam>
        /// <param name="consulta">Consulta SQL a ejecutar</param>
        /// <returns>Lista de objetos especificados</returns>
        /// <exception cref="Exception"></exception>
        public List<T> EjecutarConsulta<T>(string consulta, SqlParameter[] parametros = null) where T : new()
        {
            List<T> registros = new List<T>();

            try
            {
                using (SqlConnection conexion = new SqlConnection(this._cadenaDeConexion))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        if (parametros != null)
                            comando.Parameters.AddRange(parametros);

                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                object[] fila = new object[lector.FieldCount];
                                lector.GetValues(fila);

                                T instancia = new T();
                                EstablecerPropiedades(instancia, fila);

                                registros.Add(instancia);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al conectar o ejecutar consulta: {ex.Message}");
            }

            return registros;
        }

        /// <summary>
        /// Establece las propiedades de un onjeto basándose en un arreglo de valores.
        /// </summary>
        /// <typeparam name="T">Tipo de objeto</typeparam>
        /// <param name="instancia">Objeto cuya propiedades se establecerán.</param>
        /// <param name="valores">Arreglo de valores.</param>
        private void EstablecerPropiedades<T>(T instancia, object[] valores)
        {
            var propiedades = typeof(T).GetProperties();

            for (int i = 0; i < valores.Length; i++)
            {
                if (i < propiedades.Length)
                {
                    propiedades[i].SetValue(instancia, valores[i]);
                }
            }
        }

        /// <summary>
        /// Ejecuta una consulta que no devuelve un conjunto de resultados.
        /// Por ejemplo instrucciones de inserción, actualización o eliminación.
        /// </summary>
        /// <param name="consulta">Consulta SQL a Ejecutar</param>
        /// <returns>Número de filas afectadas</returns>
        /// <exception cref="Exception"></exception>
        public int EjecutarNoConsulta(string consulta, SqlParameter[] parametros = null)
        {
            int filasAfectadas = 0;

            try
            {
                using (SqlConnection conexion = new SqlConnection(this._cadenaDeConexion))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        if (parametros != null)
                            comando.Parameters.AddRange(parametros);

                        filasAfectadas = comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al conectar o ejecutar consulta: {ex.Message}");
            }

            return filasAfectadas;
        }
    }
}
