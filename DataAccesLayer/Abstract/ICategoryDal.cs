using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstract
{
    public interface ICategoryDal
    {
        List<Category> TumKategorileriGetir();
        void KategoriEkle(Category category);
        void KategoriSil(Category category);
        void KategoriGuncelle(Category category);
        Category GetByID(int id);
    }
}
