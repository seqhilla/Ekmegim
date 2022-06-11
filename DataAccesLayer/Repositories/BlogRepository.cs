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
    public class BlogRepository : IBlogDal
    {
        Blog b = new Blog();

        public void BlogEkle(Blog blog)
        {
            using var c = new Context();
            c.Add(blog);
            c.SaveChanges();
        }

        public void BlogGuncelle(Blog blog)
        {
            using var c = new Context();
            c.Update(blog);
            c.SaveChanges();
        }

        public void BlogiSil(Blog blog)
        {
            using var c = new Context();
            c.Remove(blog);
            c.SaveChanges();
        }

        public Blog GetByID(int id)
        {
            using var c = new Context();
            return c.Blogs.Find(id);
        }

        public List<Blog> TumBloglariGetir()
        {
            using var c = new Context();
            return c.Blogs.ToList();
        }
    }
}
