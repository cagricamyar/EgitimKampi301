using EgitimKampi301.BusinessLayer.Abstract;
using EgitimKampi301.BusinessLayer.Concrete;
using EgitimKampi301.DataAccessLayer.EntityFramework;
using EgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EgitimKampi301.PresentationLayer
{   
    public partial class FrmCategory : Form
    {
        private readonly ICategoryService _categoryService;
        public FrmCategory()
        {
            _categoryService = new CategoryManager(new EfCategoryDal());
            InitializeComponent();
        }

		private void btnList_Click(object sender, EventArgs e)
		{
            var categoryValues = _categoryService.GetAll();
            dataGridView1.DataSource = categoryValues;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
            Category category = new Category();
            category.CategoryName = txtCategoryName.Text;
            category.CategoryStatus = true;
            _categoryService.Add(category);
            MessageBox.Show("Ekleme Basarili");
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
            int id = int.Parse(txtCategoryId.Text);
            var deletedValues = _categoryService.GetById(id);
            _categoryService.Delete(deletedValues);
            MessageBox.Show("Silme Basarili");
		}

		private void btnGetById_Click(object sender, EventArgs e)
		{
            int id = int.Parse(txtCategoryId.Text);
            var values = _categoryService.GetById(id);
            _categoryService.Update(values);
            dataGridView1.DataSource = values;
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
            int updatedId= int.Parse(txtCategoryId.Text);
            var updatedValue = _categoryService.GetById(updatedId);
            updatedValue.CategoryName = txtCategoryName.Text;
            updatedValue.CategoryStatus = true;
            _categoryService.Update(updatedValue);
		}
	}
}
