using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testplatformu3
{
    internal class CategoryController
    {
        private List<Category> categories = new List<Category>();

        public void AddCategory(string categoryName)
        {
            var category = new Category { Id = categories.Count + 1, CategoryName = categoryName };
            categories.Add(category);
            Console.WriteLine($"Kategori was added: {category.CategoryName}");
        }

        public void RemoveCategory(string categoryName)
        {
            var categoryToRemove = categories.Find(c => c.CategoryName == categoryName);
            if (categoryToRemove != null)
            {
                categories.Remove(categoryToRemove);
                Console.WriteLine($"Category was deleted: {categoryToRemove.CategoryName}");
            }
            else
            {
                Console.WriteLine("Kategori bulunamadı.");
            }
        }

        public List<Category> GetCategories()
        {
            return categories;
        }
    }
}
