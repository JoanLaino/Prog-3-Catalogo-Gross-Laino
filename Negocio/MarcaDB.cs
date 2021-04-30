using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    class MarcaDB
    {
		public List<Marca> Listar()
		{
			List<Marca> lista = new List<Marca>();
			AccesoDatos datos = new AccesoDatos();

			try
			{
				datos.SetearConsulta("select Id, Descripcion from MARCAS");
				datos.EjecutarLectura();

				while (datos.Lector.Read())
				{
					lista.Add(new Marca((int)datos.Lector["Id"], (string)datos.Lector["Descripcion"]));
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
	}
}
