using DiscountAPI.Context;
using DiscountAPI.Models;
using DiscountAPI.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DiscountAPI.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext context;
        public CategoryRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public bool CategoryExists(string name)
        {
            throw new NotImplementedException();
        }

        public bool CategoryExists(int id)
        {
            throw new NotImplementedException();
        }

        public bool CreateCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetAllCategory()
        {
            return context.Category.ToList();
        }

        public Category GetCategory(int id)
        {
            return context.Category.FirstOrDefault(c => c.Id == id);

        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool UpdateCategory(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
