﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimKampi301.BusinessLayer.Abstract
{
	public interface IGenericService<T> where T : class
	{
		List<T> GetAll();
		T GetById(int id);
		void Add(T entity);
		void Delete(T entity);
		void Update(T entity);

	}
}
