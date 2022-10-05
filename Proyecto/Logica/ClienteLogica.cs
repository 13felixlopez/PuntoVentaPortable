using Proyecto.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVenta.Logica
{
    public class ClienteLogica
    {

        private static ClienteLogica _instancia = null;
        /// <summary>
        /// Constructor vacio
        /// </summary>
        public ClienteLogica()
        {

        }
        /// <summary>
        /// Metodo estatico para instanciar a esta misma clase
        /// </summary>
        public static ClienteLogica Instancia
        {

            get
            {
                if (_instancia == null) _instancia = new ClienteLogica();
                return _instancia;
            }
        }

        /// <summary>
        /// Metodo que lista a todos los clientes y los muestra en el formulario
        /// </summary>
        /// <param name="mensaje"></param>
        /// <returns></returns>
        public List<Cliente> Listar(out string mensaje)
        {
            mensaje = string.Empty;
            List<Cliente> oLista = new List<Cliente>();

            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {
                    conexion.Open();
                    string query = "select IdCliente,NumeroDocumento,NombreCompleto from CLIENTE;";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oLista.Add(new Cliente()
                            {
                                IdCliente = int.Parse(dr["IdCliente"].ToString()),
                                NumeroDocumento = dr["NumeroDocumento"].ToString(),
                                NombreCompleto = dr["NombreCompleto"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                oLista = new List<Cliente>();
                mensaje = ex.Message;
            }
            return oLista;
        }
        /// <summary>
        /// Metodo que valida si el numero de documento ingresado existe en la base de datos
        /// </summary>
        /// <param name="numero"></param>
        /// <param name="defaultid"></param>
        /// <param name="mensaje"></param>
        /// <returns></returns>
        public int Existe(string numero, int defaultid, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;
            using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
            {
                try
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select count(*)[resultado] from CLIENTE where upper(NumeroDocumento) = upper(@pnumero) and IdCliente != @defaultid");

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@pnumero", numero));
                    cmd.Parameters.Add(new SQLiteParameter("@defaultid", defaultid));
                    cmd.CommandType = System.Data.CommandType.Text;

                    respuesta = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                    if (respuesta > 0)
                        mensaje = "El numero de documento ya existe";

                }
                catch (Exception ex)
                {
                    respuesta = 0;
                    mensaje = ex.Message;
                }

            }
            return respuesta;
        }
        /// <summary>
        /// Metodo que se utiliza para guardar un nuevo cliente, se valida que este cliente no exista en la base de datos.
        /// Se declara la variable respuesta=0, en caso que respuesta sea mayor a 1 no se guardara el cliente, en caso que respuesta siga siendo 0 el cliente sera registrado
        /// </summary>
        /// <param name="objeto"></param>
        /// <param name="mensaje"></param>
        /// <returns></returns>
        public int Guardar(Cliente objeto, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;

            using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
            {
                try
                {

                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("insert into CLIENTE(NumeroDocumento,NombreCompleto) values (@pnumero,@pnombre);");
                    query.AppendLine("select last_insert_rowid();");

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@pnumero", objeto.NumeroDocumento));
                    cmd.Parameters.Add(new SQLiteParameter("@pnombre", objeto.NombreCompleto));
                    cmd.CommandType = System.Data.CommandType.Text;

                    respuesta = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                    if (respuesta < 1)
                        mensaje = "No se pudo registrar el cliente";
                }
                catch (Exception ex)
                {
                    respuesta = 0;
                    mensaje = ex.Message;
                }
            }

            return respuesta;
        }
        /// <summary>
        /// Metodo que se utiliza para editar un nuevo cliente, se valida que este cliente exista en la base de datos.
        /// Se declara la variable respuesta=0, en caso que respuesta sea mayor a 1 no se editara el cliente, en caso que respuesta siga siendo 0 el cliente sera actualizado
        /// </summary>
        /// <param name="objeto"></param>
        /// <param name="mensaje"></param>
        /// <returns></returns>
        public int Editar(Cliente objeto, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;

            using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
            {
                try
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update CLIENTE set NumeroDocumento = @pnumero,NombreCompleto = @pnombre where IdCliente = @pidcliente");

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@pidcliente", objeto.IdCliente));
                    cmd.Parameters.Add(new SQLiteParameter("@pnumero", objeto.NumeroDocumento));
                    cmd.Parameters.Add(new SQLiteParameter("@pnombre", objeto.NombreCompleto));
                    cmd.CommandType = System.Data.CommandType.Text;

                    respuesta = cmd.ExecuteNonQuery();
                    if (respuesta < 1)
                        mensaje = "No se pudo editar el cliente";
                }
                catch (Exception ex)
                {
                    respuesta = 0;
                    mensaje = ex.Message;
                }
            }

            return respuesta;
        }

        /// <summary>
        /// Metodo que elimina el cliente, se declara la variable respuesta=0 para validar que el id de cliente ingresado existe y se puede eliminar
        /// En caso que respuesta sea mayor a 1 no se podra eliminar el cliente 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Eliminar(int id)
        {
            int respuesta = 0;
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("delete from CLIENTE where IdCliente= @id;");
                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@id", id));
                    cmd.CommandType = System.Data.CommandType.Text;
                    respuesta = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

                respuesta = 0;
            }

            return respuesta;
        }



    }
}
