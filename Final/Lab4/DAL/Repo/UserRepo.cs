using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF;
using DAL.Interfaces;

namespace DAL.Repo
{
    internal class UserRepo : IRepo<User, int, bool>
    {
        private static FinalLab4Task1Context db;

        public UserRepo(FinalLab4Task1Context db)
        {
            UserRepo.db = db;
        }

        public bool Create(User obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public User Get(int id)
        {
            return UserRepo.db.Users.Find(id);
        }

        public List<User> Gets()
        {
            return UserRepo.db.Users.ToList();
        }

        public bool Update(User obj)
        {
            throw new NotImplementedException();
        }
    }
}
