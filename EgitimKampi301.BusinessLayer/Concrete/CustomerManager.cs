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
	public class CustomerManager : ICustomerService
	{
		ICustomerDal _customerDal;

		public CustomerManager(ICustomerDal customerDal)
		{
			_customerDal = customerDal;
		}

		public void Add(Customer entity)
		{
			if (entity.CustomerName == "" && entity.CustomerName.Length >= 3 && entity.CustomerCity != null && entity.CustomerSurname == "" && entity.CustomerName.Length <= 30)
			{
				_customerDal.Insert(entity);
			}
			else
			{
				Console.WriteLine("Ekleme Basarisiz");
			}

		}

		public void Delete(Customer entity)
		{
			_customerDal.Delete(entity);
		}

		public List<Customer> GetAll()
		{
			return _customerDal.GetAll();
		}

		public Customer GetById(int id)
		{
			return _customerDal.GetById(id);
		}

		public void Update(Customer entity)
		{
			_customerDal.Update(entity);
		}
	}
}