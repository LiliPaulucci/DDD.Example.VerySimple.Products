using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.Data.Entity;

namespace Repository
{
    public class ProductRepository : IProductRepository
    {

       private DbProductContext _context;

        public ProductRepository(DbProductContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> Products
        {
            get { return _context.Products; }
        }

        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> ListAll()
        {
            throw new NotImplementedException();
        }

        public void Save(Product product)
        {
            throw new NotImplementedException();
        }

        public Product SearchFor(int idProduct)
        {
            throw new NotImplementedException();
        }
    }
}
