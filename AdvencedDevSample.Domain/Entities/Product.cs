using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdvencedDevSample.Domain.Exceptions;
namespace AdvencedDevSample.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; private set; }
        public decimal Price { get; private set;}
        public bool IsActive { get; private set;}
        public Product (){
            IsActive = true;
        }
        public void ChangePrice(decimal newPrice){
            if(newPrice <= 0){
                throw new DomainException("Le prix doit être positif. ");
            }
            if(!IsActive){
                throw new DomainException("Le produit doit être actif. ");
            }
            Price = newPrice;
        }

    }


    

}