using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AGK.Models;

namespace AGK.IServices
{
    public interface IProductService
    {

        IEnumerable<ProductVm> FindAll();
        IEnumerable<ProductVm> FindByCategory(int category);
        IEnumerable<ProductVm> FindByManuFacturer(int manufactory);
        ProductVm FindById(Guid product);
        IEnumerable<ProductVm> GetRandoms(int category);
        IEnumerable<ProductVm> GetNews(int category);
        IEnumerable<ProductVm> GetNews();
        IEnumerable<ProductVm> GetBestSellers();
        IEnumerable<ProductVm> GetBestSellers(int category);
        bool Add(ProductDetail product);
        bool Update(ProductDetail product);
        bool Delete(Guid product);

    }
}
