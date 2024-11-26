using EgitimKampi301.DataAccessLayer.Abstract;
using EgitimKampi301.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimKampi301.DataAccessLayer.Repositories
{
	public class GenericRepository<T> : IGenericDal<T> where T : class
	{
		CampContext campContext = new CampContext();
		private readonly DbSet<T> _object;

		public GenericRepository()
		{
			_object = campContext.Set<T>();
		}
		public void Delete(T entity)
		{
			var deletedEntity = campContext.Entry(entity);
			deletedEntity.State = EntityState.Deleted;
			campContext.SaveChanges();
		}

		public List<T> GetAll()
		{
			return _object.ToList();
		}

		public T GetById(int id)
		{
			return _object.Find(id);
		}

		public void Insert(T entity)
		{
			var addedEntity = campContext.Entry(entity);
			addedEntity.State = EntityState.Added;
			campContext.SaveChanges();
		}

		public void Update(T entity)
		{
			var updatedEntity = campContext.Entry(entity);
			updatedEntity.State = EntityState.Modified;
			campContext.SaveChanges();
		}
	}
}
