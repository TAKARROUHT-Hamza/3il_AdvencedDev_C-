using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvencedDevSample.Domain.Entities;


namespace AdvencedDevSample.Domain.Interfaces.Products
{
    public interface IProductRepository
    {
        Product GetById(Guid id);
        void Save(Product product);
    }
}
