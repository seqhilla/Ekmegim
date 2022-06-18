using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Ekle(T t)
        {
            using var c = new Context();
            c.Add(t);
            c.SaveChanges();
        }

        public T GetByID(int id)
        {
            using var c = new Context();
            return c.Set<T>().Find(id);
        }

        public void Guncelle(T t)
        {
            throw new NotImplementedException();
        }

        public List<T> HepsiniGetir()
        {
            using var c = new Context();
            return c.Set<T>().ToList();
        }

        public void Sil(T t)
        {
            using var c = new Context();
            c.Remove(t);
            c.SaveChanges();
        }
    }
}
