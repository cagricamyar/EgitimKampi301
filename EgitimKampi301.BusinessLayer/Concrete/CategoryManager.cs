﻿using EgitimKampi301.BusinessLayer.Abstract;
using EgitimKampi301.DataAccessLayer.Abstract;
using EgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimKampi301.BusinessLayer.Concrete
{
	public class CategoryManager : ICategoryService
	{

		ICategoryDal _categoryDal;

		public CategoryManager(ICategoryDal categoryDal)
		{
			_categoryDal = categoryDal;
		}

		public void Add(Category entity)
		{
			_categoryDal.Insert(entity);
		}

		public void Delete(Category entity)
		{
			_categoryDal.Delete(entity);
		}

		public List<Category> GetAll()
		{
			return _categoryDal.GetAll();
		}

		public Category GetById(int id)
		{
			return _categoryDal.GetById(id);
		}

		public void Update(Category entity)
		{
			_categoryDal.Update(entity);
		}
	}
}