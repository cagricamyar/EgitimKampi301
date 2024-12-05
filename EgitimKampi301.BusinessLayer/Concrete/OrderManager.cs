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
	public class OrderManager : IOrderService
	{
		IOrderDal _orderDal;

		public OrderManager(IOrderDal orderDal)
		{
			_orderDal = orderDal;
		}


		public void Add(Order entity)
		{
			_orderDal.Insert(entity);
		}

		public void Delete(Order entity)
		{
			_orderDal.Delete(entity);
		}

		public List<Order> GetAll()
		{
			return _orderDal.GetAll();
		}

		public Order GetById(int id)
		{
			return _orderDal.GetById(id);
		}

		public void Update(Order entity)
		{
			_orderDal.Update(entity);
		}
	}
}