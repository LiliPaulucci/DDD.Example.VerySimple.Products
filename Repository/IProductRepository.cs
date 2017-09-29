using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IProductRepository
    {
        void Add(Product product);
        void Save(Product product);
        IEnumerable<Product> ListAll();
        Product SearchFor(int idProduct);
    }
}
