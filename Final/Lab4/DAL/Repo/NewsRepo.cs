using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF;
using DAL.Interfaces;

namespace DAL.Repo
{
    internal class NewsRepo : IRepo<News, int, bool>
    {
        private static FinalLab4Task1Context db;

        public NewsRepo(FinalLab4Task1Context db)
        {
            NewsRepo.db = db;
        }

        public bool Create(News obj)
        {
            NewsRepo.db.News.Add(obj);

            return NewsRepo.db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var news = NewsRepo.db.News.Find(id);

            if(news == null)
            {
                return false;
            }

            NewsRepo.db.News.Remove(news);

            return NewsRepo.db.SaveChanges() > 0;

        }

        public News Get(int id)
        {
            return NewsRepo.db.News.Find(id);
        }

        public List<News> Gets()
        {
            return NewsRepo.db.News.ToList();
        }

        public bool Update(News obj)
        {
            var news = NewsRepo.db.News.Where(n => n.Id == obj.Id).FirstOrDefault();

            if(news == null)
            {
                return false;
            }

            NewsRepo.db.Entry(news).CurrentValues.SetValues(obj);

            return NewsRepo.db.SaveChanges() > 0;
        }
    }
}
