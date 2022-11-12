using WpfShop.Data.Dao;
using WpfShop.Utils;
using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;

namespace WpfShop.Data.Impl
{
    public class CategoryDaoImpl : CategoryDao
    {
        private DBDataContext db;
        public CategoryDaoImpl()
        {
            db = new DBDataContext(Constants.DB_CONNECT_STRING);
        }
        public int count()
        {
            var query = from category in db.GetTable<Category>() select category;
            List<Category> categoryList = query.ToList<Category>();
            return categoryList.Count();
        }

        public void deleteById(int id)
        {
            Category find = db.Categories.Single(c => c.Id == id);
            db.Categories.DeleteOnSubmit(find);
            db.SubmitChanges();
        }

        public List<Category> findAll()
        {
            var all = from category in db.GetTable<Category>() select category;
            var categoryList = all.ToList();
            return categoryList;
        }

        public Category findById(int id)
        {
            return db.Categories.Single(c => c.Id == id);
        }

        public void insert(Category category)
        {
            db.Categories.InsertOnSubmit(category);
            db.SubmitChanges();
        }

        public void insert(Dao.Category category)
        {
            throw new NotImplementedException();
        }

        public void update(Category category)
        {
            Category find = db.Categories.Single(c => c.Id == category.Id);
            find.Name = category.Name;
            find.Description = category.Description;
            db.SubmitChanges();
        }

        public void update(Dao.Category category)
        {
            throw new NotImplementedException();
        }

        List<Dao.Category> CategoryDao.findAll()
        {
            throw new NotImplementedException();
        }

        Dao.Category CategoryDao.findById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
