using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface ICategoryRepository
    {
        void Add(Category category);
        void SalSavevar(Category category);
        IEnumerable<Category> ListAll();
        Category SearchFor(int idCategory);
    }
}
