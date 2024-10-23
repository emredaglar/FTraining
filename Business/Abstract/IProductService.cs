using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        
        IDataResult<List<Product>> getAll();

        IResult Add(Product product);

        IDataResult<List<Product>> getAllByCategoryId(int id);
        IDataResult<List<Product>> getByUnitPrice(decimal min,decimal max);
        IDataResult<List<ProductDetailDto>> GetProductDetail();

    }
}
