using Starint.Data.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Starint.ViewModels
{
    public class CategoryListViewModel
    {
        public IEnumerable<Category> Categories { get; set; }
        public Category Category { get; set; }

    }
}
