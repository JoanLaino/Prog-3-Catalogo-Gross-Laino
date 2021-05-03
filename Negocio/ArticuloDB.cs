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
        private AccesoDatos datos;
        public List<Articulo> Listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            
            try
            {
                datos.SetearConsulta("select A.Id Id, Codigo, Nombre, A.Descripcion, M.Id IdMarca, M.Descripcion Marca, C.Id IdCategoria, C.Descripcion Categoria, ImagenUrl, Precio from ARTICULOS A, MARCAS M, CATEGORIAS C WHERE A.IdMarca = M.Id AND C.Id = A.IdCategoria");
                datos.EjecutarLectura();

                while(datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = datos.Lector.GetString(3);
                    aux.Marca = new Marca((string)datos.Lector["Marca"]);
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Categoria = new Categoria((string)datos.Lector["Categoria"]);
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Imagen = (string)datos.Lector["ImagenUrl"];
                    aux.Precio = Math.Truncate((decimal)datos.Lector["Precio"] * 100) /100;
                    
                    lista.Add(aux);
                }

                return lista;
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

        public List<Articulo> ListarDetalles(string Codigo)
        {
            List<Articulo> fila = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("select Codigo, Nombre, A.Descripcion, M.Id IdMarca, M.Descripcion Marca, C.Id IdCategoria, C.Descripcion Categoria, ImagenUrl, Precio from ARTICULOS A, MARCAS M, CATEGORIAS C WHERE A.IdMarca = M.Id AND C.Id = A.IdCategoria and Codigo = '" + Codigo + "'");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = datos.Lector.GetString(2);
                    aux.Marca = new Marca((string)datos.Lector["Marca"]);
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Categoria = new Categoria((string)datos.Lector["Categoria"]);
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Imagen = (string)datos.Lector["ImagenUrl"];
                    aux.Precio = Math.Truncate((decimal)datos.Lector["Precio"] * 100) / 100;

                    fila.Add(aux);
                }

                return fila;
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

        public void agregarArticulo(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string valores = "values('" + articulo.Codigo + "', '" + articulo.Nombre + "', '" + articulo.Descripcion + "', " + articulo.Marca.Id + ", " + articulo.Categoria.Id + ", '" + articulo.Imagen + "', " + articulo.Precio + ")";
                datos.SetearConsulta("insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) " + valores);

                datos.EjectutarAccion();
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

        public void EliminarArticulo(string codigo)
        {
            datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("delete from ARTICULOS WHERE Codigo = '" + codigo + "'");
                datos.EjectutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
                datos = null;
            }
        }

        public void modificarArticulo(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("update ARTICULOS set Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, ImagenUrl = @Imagen, Precio = @Precio WHERE Id = @Id");
                datos.setearParametro("@Codigo", articulo.Codigo);
                datos.setearParametro("@Nombre", articulo.Nombre);
                datos.setearParametro("@Descripcion", articulo.Descripcion);
                datos.setearParametro("@IdMarca", articulo.Marca.Id);
                datos.setearParametro("@IdCategoria", articulo.Categoria.Id);
                datos.setearParametro("@Imagen", articulo.Imagen);
                datos.setearParametro("@Precio", articulo.Precio);
                datos.setearParametro("@Id", articulo.Id);

                datos.EjectutarAccion();
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

        public void agregarMarca(Marca marca)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string valores = "values('" + marca.Nombre + "')";
                datos.SetearConsulta("insert into MARCAS (Descripcion)" + valores);

                datos.EjectutarAccion();
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

        public void agregarCategoria(Categoria categoria)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string valores = "values('" + categoria.Nombre + "')";
                datos.SetearConsulta("insert into CATEGORIAS (Descripcion)" + valores);

                datos.EjectutarAccion();
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
    }
}
