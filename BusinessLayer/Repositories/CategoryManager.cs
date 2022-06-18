using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Repositories
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public Category GetByID(int id)
        {
            return _categoryDal.GetByID(id);
        }

        public void KategoriEkle(Category category)
        {
            _categoryDal.Ekle(category);
        }

        public void KategoriGuncelle(Category category)
        {
            _categoryDal.Guncelle(category);
        }

        public void KategoriSil(Category category)
        {
            _categoryDal.Sil(category);
        }

        public List<Category> TumKategorileriGetir()
        {
            return _categoryDal.HepsiniGetir();
        }
    }
}
