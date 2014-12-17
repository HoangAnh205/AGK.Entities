using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AGK.Entities;
using AGK.IServices;
using AGK.Models;

namespace AGK.Service
{
    public class ProductService : IProductService
    {
        private ProductDbContext _productDb;

        // --- Hàm truyền ProductDb 
        public ProductService(ProductDbContext _productDb)
        {
            this._productDb = _productDb;
        }

        // --- Hàm thêm sản phẩm mới từ productDetail
        public bool Add(ProductDetail product)
        {
            try
            {
                // --- Khởi tạo một Product Entity mới
                var pro = new Product()
                {
                    Name = product.Name,
                    Cost = product.Cost,
                    Info = product.Info,
                    Instock = product.InStock
                };
                // --- Lấy category trùng với id category truyền vào
                pro.Category = _productDb.Categories.SingleOrDefault(x => x.ID.Equals(product.CategoryID));

                // --- Nếu không tồn tại thì trả về false
                if (pro.Category == null)
                    return false;
                // --- Lấy Manufacturers trùng với id Manufacturers truyền vào
                pro.Manufacturer = _productDb.Manufacturers.SingleOrDefault(x => x.ID.Equals(product.ManufactureID));

                // --- Nếu không tồn tại thì trả về false
                if (pro.Manufacturer == null)
                    return false;

                // --- Cập nhật product lên cơ sở dữ liệu
                _productDb.Products.Add(pro);
                _productDb.SaveChanges();

                // --- Với mỗi string link hình ảnh thì chuyển thành đối tượng Image
                var images = product.Images.Select(x => new Image() {Link = x, ProductID = pro.ID});
                // --- Cập nhật lại product lên cơ sở dữ liệu
                _productDb.Images.AddRange(images);
                _productDb.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool Delete(Guid product)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductVm> FindAll()
        {
            // --- Tạo ra một list chứa các đối tượng ProductVm từ Product Entity
            var list = _productDb.Products.Select(x => new ProductVm()
            {
                Name = x.Name,
                Category = x.Category.Name,
                Manufacturer = x.Manufacturer.Name,
                Cost = x.Cost,
                ID = x.ID,
                Image = x.Images.FirstOrDefault().Link
            });

            return list;
        }

        public IEnumerable<ProductVm> FindByCategory(int category)
        {
            throw new NotImplementedException();
        }

        public ProductVm FindById(Guid product)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductVm> FindByManuFacturer(int manufactory)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductVm> GetBestSellers(int category)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductVm> GetBestSellers()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductVm> GetNews()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductVm> GetNews(int category)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductVm> GetRandoms(int category)
        {
            throw new NotImplementedException();
        }

        public bool Update(ProductDetail product)
        {
            throw new NotImplementedException();
        }
    }
}
