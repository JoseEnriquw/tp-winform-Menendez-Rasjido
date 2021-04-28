﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Bussines
{
   public class ArticulosBussines
    {
        public List<Articulo> listar(string where)
        {
            List<Articulo> lista= new List<Articulo>();
            AccessData accessdata = new AccessData("data source=DESKTOP-Q2KI0EM\\SQLEXPRESS;initial catalog=CATALOGO_DB;integrated security=true;") ;
            try
            {
                string consulta = "Select  .Id,A.Codigo,A.Nombre,A.Descripcion,M.Descripcion 'Marca',C.Descripcion 'Categoria'," +
                    "A.ImagenUrl,A.Precio from Articulos A " +
                    "inner join Marcas M on M.Id=A.IdMarca " +
                    "inner join Categorias C on C.Id=A.IdCategoria";
                accessdata.setearConsulta(consulta);
                accessdata.ejecutarLectura();
                while (accessdata.Lector.Read())
                {
                    Articulo articulo = new Articulo();

                    articulo.ID = (int)accessdata.Lector["Id"];
                    articulo.CodigoArticulo=(string)accessdata.Lector["Codigo"];
                    articulo.Nombre=(string)accessdata.Lector["Nombre"];
                    articulo.Descripcion=(string)accessdata.Lector["Descripcion"];
                    articulo.Marca=(string)accessdata.Lector["Marca"];
                    articulo.Categoria=(string)accessdata.Lector["Categoria"];
                    articulo.URLimagen=(string)accessdata.Lector["ImagenUrl"];
                    articulo.precio= (decimal)accessdata.Lector["Precio"];
                   
                    lista.Add(articulo);

                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                accessdata.cerrarConexion();
            }
        }



    }
}