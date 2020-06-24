using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Starint.Data.Categories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _appDbContext;

        public CategoryRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Category> AllCategories
        {
            get
            {
                return _appDbContext.Category.ToList();
            }
        }
        public Category GetById(int id)
        {
            return _appDbContext.Category.Where(o => o.Id == id).FirstOrDefault();
        }
        public void Update(Category category)
        {
            _appDbContext.Category.Update(category);
            _appDbContext.SaveChanges();
        }
        public void Create(Category category)
        {
            _appDbContext.Category.Add(category);
            _appDbContext.SaveChanges();
        }
        public void Delete(Category category)
        {
            _appDbContext.Category.Remove(category);
            _appDbContext.SaveChanges();
        }
    }
}
