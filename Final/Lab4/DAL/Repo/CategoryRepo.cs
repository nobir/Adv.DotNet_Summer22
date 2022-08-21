using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF;
using DAL.Interfaces;

namespace DAL.Repo
{
    internal class CategoryRepo : IRepo<Category, int, bool>
    {
        private static FinalLab4Task1Context db;

        public CategoryRepo(FinalLab4Task1Context db)
        {
            CategoryRepo.db = db;
        }

        public bool Create(Category obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Category Get(int id)
        {
            return CategoryRepo.db.Categories.Find(id);
        }

        public List<Category> Gets()
        {
            return CategoryRepo.db.Categories.ToList();
        }

        public bool Update(Category obj)
        {
            throw new NotImplementedException();
        }
    }
}
