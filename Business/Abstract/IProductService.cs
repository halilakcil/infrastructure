using Entities.Concrete;
using System.Collections.Generic;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<Product> GetById(int id);
        IDataResult<IList<Product>> GetList();
        IDataResult<IList<Product>> GetListByCategoryId(int categoryId);
        IResult Add(Product product);
        IResult Update(Product product);
        IResult Delete(Product product);

    }
}
