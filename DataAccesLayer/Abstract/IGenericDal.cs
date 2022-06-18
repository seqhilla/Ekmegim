using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstract
{
    internal interface IGenericDal<T> where T : class
    {
        List<T> HepsiniGetir();
        void Ekle(T t);
        void Sil(T t);
        void Guncelle(T t);
        T GetByID(int id);
    }
}
