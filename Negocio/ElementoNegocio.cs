﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ElementoNegocio
    {
        public List<ElementoNegocio> listar() {
        
            List<Elemento> lista = new List<Elemento>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("SELECT Id, Descripcion From ELEMENTOS");
                datos.EjecutarLectura();
                
                while (datos.Lector.Read())
                {
                    Elemento aux = new Elemento();
                    aux.ID = (int) datos.Lector["Id"];
                    aux.Descripcion =(string) datos.Lector["Descripcion"];

                    lista.Add(aux);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
            
            
            
            
            return new List<ElementoNegocio>();
        }
    }
}
