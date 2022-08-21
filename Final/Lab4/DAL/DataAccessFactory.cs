using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.EF;
using DAL.Repo;
using DAL.Interfaces;

namespace DAL
{
    public sealed class DataAccessFactory
    {
        private static readonly FinalLab4Task1Context db = new FinalLab4Task1Context();

        // Can't create instance (kind of singleton)
        private DataAccessFactory() { }

        public static IRepo<News, int, bool> GetNewsDataAccess()
        {
            return new NewsRepo(DataAccessFactory.db);
        }
    }
}
