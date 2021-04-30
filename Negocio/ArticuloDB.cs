using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class ArticuloDB
    {      
        public List<Articulo> Listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            
            try
            {
                datos.SetearConsulta("select Codigo, Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, ImagenUrl, Precio from ARTICULOS A, MARCAS M, CATEGORIAS C WHERE A.IdMarca = M.Id AND C.Id = A.IdCategoria");
                datos.EjecutarLectura();

                while(datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = datos.Lector.GetString(2);
                    aux.Marca = (string)datos.Lector["Marca"];
                    aux.Categoria = (string)datos.Lector["Categoria"];
                    aux.Imagen = (string)datos.Lector["ImagenUrl"];
                    aux.Precio = Math.Truncate((decimal)datos.Lector["Precio"] * 100) /100;
                    

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
    }
}
