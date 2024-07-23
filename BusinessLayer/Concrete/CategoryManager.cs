using BusinessLayer.Abstarct;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.Repositories;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        //IHeadingDal _headingDal;
        //IWriterDal _writerDal;
        //public EfCategoryDal efCategoryDal;

        //public CategoryManager(ICategoryDal categoryDal, IHeadingDal headingDal, IWriterDal writerDal)
        //{
        //    _categoryDal = categoryDal;
        //    _headingDal = headingDal;
        //    _writerDal = writerDal;
        //}
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal ?? throw new ArgumentNullException(nameof(categoryDal));
        }

        //public CategoryManager(EfCategoryDal efCategoryDal)
        //{
        //    this.efCategoryDal = efCategoryDal;
        //}

        public void CategoryAdd(Category category)
        {
            _categoryDal.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            _categoryDal.Delete(category);
        }

      


        public Category GetByID(int id)
        {
            return _categoryDal.Get(x=>x.CategoryID == id);
        }

        public List<Category> GetList()
        {
            return _categoryDal.List();
        }


        public int GetCategoryCount()
        {            
            return _categoryDal.List().Count();
        }

        //public int CategoryCountYl(string categoryName)
        //{
        //    var category = _categoryDal.Get(x => x.CategoryName == categoryName);
        //    if(category != null)
        //    {
        //        return _headingDal.List(x=>x.CategoryID == category.CategoryID).Count;
        //    }
        //    return 0;
        //}
        //public int CategoryWriterACount()
        //{
        //    var writer = _writerDal.List(x => x.WriterName.Contains("a") || x.WriterName.Contains("A"));
        //    return writer != null ? writer.Count : 0;
        //}
        //public string GetCategoryWithMostHeadings()
        //{
        //    return _headingDal.List().GroupBy(h => h.CategoryID).OrderByDescending(g => g.Count()).Select(g => _categoryDal.Get(c => c.CategoryID == g.Key).CategoryName).FirstOrDefault() ?? "No categories found";

        //}
        public int CategoryStatusFark()
        {
            var categoryStatusTrue = _categoryDal.List(x => x.CategoryStatus == true).Count;
            var categoryStatusFalse = _categoryDal.List(x=>x.CategoryStatus == false).Count;
            var fark = categoryStatusTrue-categoryStatusFalse;

            return fark;
        }

        public void CategoryUpdate(Category category)
        {
            _categoryDal.Update(category);
        }









        //GenericRepository<Category> repo = new GenericRepository<Category>();

        //public List<Category> GetAllBL()
        //{
        //    return repo.List();
        //}
        //public void CategoryAddBL(Category p)
        //{

        //    if (p.CategoryName == "" || p.CategoryName.Length <= 3 || p.CategoryDescription == "" || p.CategoryName.Length >= 51)
        //    {
        //        // hata mesajı

        //    }
        //    else
        //    {
        //        repo.Insert(p);
        //    }
        //}

    }
}
