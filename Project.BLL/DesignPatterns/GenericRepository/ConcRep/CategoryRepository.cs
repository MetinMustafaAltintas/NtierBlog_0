using Project.BLL.DesignPatterns.GenericRepository.EFBaseRep;
using Project.ENTITES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.GenericRepository.ConcRep
{
    public class CategoryRepository : BaseRepository<Category>
    {
        /// <summary>
        /// Bu metod  seçilen kaatgorinin makalelerine 2 adet makale ekler 
        /// </summary>
        /// <param name="item"></param>
        public void SpecialAdd(Category item)
        {
            Article makale1 = new Article
            {
                Title = "Korku",            
            };

            Article makale2 = new Article
            {
                Title = "Macera"
            };
            item.Articles.Add(makale1);
            item.Articles.Add(makale2);
            _db.Categories.Add(item);
            Save();
        }
    }
}
