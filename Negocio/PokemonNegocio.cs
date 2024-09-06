using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class PokemonNegocio
    {

        public List<Pokemon> Listar() 
        {
            List<Pokemon> lista = new List<Pokemon>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;


            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true"; //config de conexion a DB
                comando.CommandType = System.Data.CommandType.Text; //tipo de comando
                comando.CommandText = "SELECT p.Numero, p.Nombre, p.Descripcion, p.UrlImagen, e.Descripcion as Tipo, d.Descripcion as Debilidad FROM POKEMONS p LEFT JOIN ELEMENTOS e ON p.IdTipo = e.Id LEFT JOIN ELEMENTOS d on p.IdDebilidad = d.Id ORDER BY Numero ASC"; //consulta SQL
                comando.Connection = conexion; //conexion que usara el comando

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.Numero = lector.GetInt32(0); //pide especificacion del tipo de dato, asigna columna por indice de la consulta
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    if (lector["UrlImagen"] is DBNull)
                    {
                        aux.UrlImagen = ""; 
                    }
                    else 
                    {
                        aux.UrlImagen = (string)lector["UrlImagen"];
                    }

                    aux.Tipo = new Elemento(); //como no lo hicimos en el contructor de POKEMON creamos el elemento de su composicion
                    aux.Tipo.Descripcion = (string)lector["Tipo"];
                    aux.Debilidad = new Elemento();
                    aux.Debilidad.Descripcion = (string)lector["Debilidad"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conexion.Close(); }

        }
    }
}
