using System;
using System.Collections.Generic;
using AdvencedDevSample.Domain.Entities;
using AdvencedDevSample.Domain.Interfaces;

namespace AdvencedDevSample.Application.Services
{
    public class ProductService
    {
        private readonly IProductRepository _repo;

        public ProductService(IProductRepository repo)
        {
            _repo = repo;
        }

        public void ChangeProductPrice(Guid productId, ChangePriceRequest request)
        {
            var product = GetProductById(productId);

            product.ChangePrice(request.NewPrice);
            _repo.Save(product);
        }

        private Product GetProductById(Guid id)
        {
            return _repo.GetById(id) ?? throw new ApplicationServiceException("Product not found", System.Net.HttpStatusCode.NotFound);
        }
    }
}