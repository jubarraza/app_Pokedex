﻿using System;
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
            AccesoDatos datos = new AccesoDatos();


            try
            {
                datos.SetearConsulta("SELECT p.Numero, p.Nombre, p.Descripcion, p.UrlImagen, e.Descripcion as Tipo, d.Descripcion as Debilidad FROM POKEMONS p INNER JOIN ELEMENTOS e ON p.IdTipo = e.Id INNER JOIN ELEMENTOS d on p.IdDebilidad = d.Id ORDER BY Numero ASC");

                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.Numero = datos.Lector.GetInt32(0); //pide especificacion del tipo de dato, asigna columna por indice de la consulta
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    if (!(datos.Lector["UrlImagen"] is DBNull))
                    {
                        aux.UrlImagen = (string)datos.Lector["UrlImagen"];
                    }
                    //if (!(datos.Lector.IsDBNull(datos.Lector.GetOrdinal("UrlImagen"))))
                    //{
                    //    aux.UrlImagen = (string)datos.Lector["UrlImagen"];
                    //}


                    aux.Tipo = new Elemento(); //como no lo hicimos en el contructor de POKEMON creamos el elemento de su composicion
                    aux.Tipo.Descripcion = (string)datos.Lector["Tipo"];
                    aux.Debilidad = new Elemento();
                    aux.Debilidad.Descripcion = (string)datos.Lector["Debilidad"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.CerrarConexion(); }

        }

        public void Agregar(Pokemon nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("INSERT INTO POKEMONS (Numero, Nombre, Descripcion, Activo, IdTipo, IdDebilidad, UrlImagen) VALUES (@Numero, @Nombre, @Descripcion, 1, @IdTipo, @IdDebilidad, @UrlImagen)");
                datos.SetearParametro("@Numero", nuevo.Numero);
                datos.SetearParametro("@Nombre", nuevo.Nombre);
                datos.SetearParametro("@Descripcion", nuevo.Descripcion);
                datos.SetearParametro("@IdTipo", nuevo.Tipo.ID);
                datos.SetearParametro("@IdDebilidad", nuevo.Debilidad.ID);
                datos.SetearParametro("@UrlImagen", nuevo.UrlImagen);
                
                datos.EjecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public void Modificar(Pokemon modificar)
        {

        }
    }
}
