using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class PeliculaMapper
    {
        public static Pelicula Map(SqlDataReader reader, Categoria categoria)
        {
            try
            {
                Pelicula pelicula = new Pelicula()
                {
                    IdPelicula = Convert.ToInt32(reader["ID_PELICULA"].ToString()),
                    Titulo = reader["TITULO"].ToString(),
                    Descripcion = reader["DESCRIPCION"].ToString(),
                    AñoLanzamiento = Convert.ToInt32(reader["ANIO_LANZAMIENTO"].ToString()),
                    Duracion = Convert.ToDecimal(reader["DURACION"].ToString()),
                    Calificacion = Convert.ToInt32(reader["CALIFICACION"].ToString()),
                    FechaAlta = Convert.ToDateTime(reader["FECHA_ALTA"].ToString()),
                    Categoria = categoria
                };
                return pelicula;
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
