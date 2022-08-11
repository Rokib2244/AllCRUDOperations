using AutoMapper;
using InventorySystem.Training.BusinessObjects;
using InventorySystem.Training.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Training.Services
{
    public class ProductService : IProductService
    {
        private readonly ITrainingUnitOfWork _trainingUnitOfWork;
        //private readonly IDateTimeUtility _dateTimeUtility;
        private readonly IMapper _mapper;
        public ProductService(ITrainingUnitOfWork trainingUnitOfWork,
           IMapper mapper)
        {
            _trainingUnitOfWork = trainingUnitOfWork;
            _mapper = mapper;
        }

        public void AddProduct(Product product)
        {
            if (product == null)
                throw new InvalidOperationException("Product Was not Found");
            if(IsProductAlreadyExisted(product.Name))
                throw new InvalidOperationException("Product Name Already Used");
            _trainingUnitOfWork.Products.Add(
                _mapper.Map<Entities.Product>(product));
            _trainingUnitOfWork.Save();
        }
        public bool IsProductAlreadyExisted(string productName) =>

            _trainingUnitOfWork.Products.GetCount(x => x.Name == productName) > 0;
        public bool IsProductAlreadyExisted(string productName, int id) =>

            _trainingUnitOfWork.Products.GetCount(x => x.Name == productName && x.Id == id) > 0;

    }
}
