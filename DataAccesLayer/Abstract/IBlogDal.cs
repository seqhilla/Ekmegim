using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstract
{
    public interface IBlogDal
    {
        List<Blog> TumBloglariGetir();
        void BlogEkle(Blog blog);
        void BlogiSil(Blog blog);
        void BlogGuncelle(Blog blog);
        Blog GetByID(int id);
    }
}
