using EgitimKampi301.BusinessLayer.Abstract;
using EgitimKampi301.DataAccessLayer.Abstract;
using EgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimKampi301.BusinessLayer.Concrete
{
	public class ProductManager : IProductService
	{
		IProductDal _productDal;

		public ProductManager(IProductDal productDal)
		{
			_productDal = productDal;
		}

		public void Add(Product entity)
		{
			_productDal.Insert(entity);
		}

		public void Delete(Product entity)
		{
			_productDal.Delete(entity);
		}

		public List<Product> GetAll()
		{
			return _productDal.GetAll();
		}

		public Product GetById(int id)
		{
			return _productDal.GetById(id);
		}

		public List<Object> GetProductsWithCategory()
		{
			return _productDal.GetProductsWithCategory();
		}

		public void Update(Product entity)
		{
			_productDal.Update(entity);
		}
	}
}