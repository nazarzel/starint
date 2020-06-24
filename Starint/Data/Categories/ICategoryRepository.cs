using System.Collections.Generic;

namespace Starint.Data.Categories
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }

        void Create(Category category);
        void Delete(Category category);
        Category GetById(int id);
        void Update(Category category);
    }
}