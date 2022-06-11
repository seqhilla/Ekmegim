using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        Context c = new Context();
        public Category GetByID(int id)
        {
            return c.Categories.Find(id);
        }

        public void KategoriEkle(Category category)
        {
            c.Add(category);
            c.SaveChanges();
        }

        public void KategoriGuncelle(Category category)
        {
            c.Update(category);
            c.SaveChanges();
        }

        public void KategoriSil(Category category)
        {
            c.Remove(category);
            c.SaveChanges();
        }

        public List<Category> TumKategorileriGetir()
        {
            return c.Categories.ToList();
        }
    }
}
