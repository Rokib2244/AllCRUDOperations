using System;
using InventorySystem.Training.UnitOfWorks;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventorySystem.Training.BusinessObjects;

namespace InventorySystem.Training.Services
{
    public interface IProductService
    {
        void AddProduct(Product product);
    }
}
