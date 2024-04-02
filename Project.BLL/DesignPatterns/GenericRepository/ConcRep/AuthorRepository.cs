using Project.BLL.DesignPatterns.GenericRepository.EFBaseRep;
using Project.ENTITES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.GenericRepository.ConcRep
{
    public class AuthorRepository : BaseRepository<Author>
    {
        /// <summary>
        /// Bu metot kullanıldığında yazarın makalelerine 2 adet makale ekleyecektir.
        /// </summary>
        /// <param name="item"></param>
        public void SpecialAdd(Author item)
        {
            Article articte1 = new Article
            {
                Title = "Test1"
            };

            Article articte2 = new Article
            {
                Title = "Test2"
            };
            item.Articles.Add(articte1);
            item.Articles.Add(articte2);
            _db.Authors.Add(item);
            Save();
        }
    }
}
