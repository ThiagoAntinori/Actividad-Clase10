using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CategoriaBusiness
    {
        private CategoriaDao CategoriaDao = new CategoriaDao();

        public List<Categoria> GetCategorias()
        {
            try
            {
                return CategoriaDao.GetCategorias();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Categoria GetById(int id) 
        {
            try
            {
                if (id <= 0)
                {
                    throw new Exception("El ID no es valido");
                }
                return CategoriaDao.GetById(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
