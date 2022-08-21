using BLL.BOs;
using DAL;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public sealed class NewsService
    {
        public static bool Create(NewsModel news)
        {
            var _news = Mapping.Mapper.Map<News>(news);
            return DataAccessFactory.GetNewsDataAccess().Create(_news); ;
        }

        public static List<NewsModel> GetNewsByCategory(string categoryName)
        {
            var news = DataAccessFactory.GetNewsDataAccess().Gets();
            var _news = new List<NewsModel>();

            foreach(var n in news)
            {
                if (n.Category.Name.Equals(categoryName))
                {
                    var tempNews = Mapping.Mapper.Map<NewsModel>(n);
                    _news.Add(tempNews);
                }
            }

            return _news;
        }

        public static List<NewsModel> GetNewsByDate(DateTime datetime)
        {
            var news = DataAccessFactory.GetNewsDataAccess().Gets();
            var _news = new List<NewsModel>();

            foreach (var n in news)
            {
                if (DateTime.Compare(n.Date, datetime) == 0)
                {
                    var tempNews = Mapping.Mapper.Map<NewsModel>(n);
                    _news.Add(tempNews);
                }
            }

            return _news;
        }

        public static List<NewsModel> GetNewsByUser(int id)
        {
            var news = DataAccessFactory.GetNewsDataAccess().Gets();
            var _news = new List<NewsModel>();

            foreach (var n in news)
            {
                if (n.User.Id == id)
                {
                    var tempNews = Mapping.Mapper.Map<NewsModel>(n);
                    _news.Add(tempNews);
                }
            }

            return _news;
        }

        public static List<NewsModel> GetNewsByUserDate(int id, DateTime date)
        {
            var news = DataAccessFactory.GetNewsDataAccess().Gets();
            var _news = new List<NewsModel>();

            foreach (var n in news)
            {
                if (n.User.Id == id && DateTime.Compare(n.Date, date) == 0)
                {
                    var tempNews = Mapping.Mapper.Map<NewsModel>(n);
                    _news.Add(tempNews);
                }
            }

            return _news;
        }

        public static List<NewsModel> GetNewsByUserDateType(int id, DateTime date, string type)
        {
            var news = DataAccessFactory.GetNewsDataAccess().Gets();
            var _news = new List<NewsModel>();

            foreach (var n in news)
            {
                if (n.User.Id == id && DateTime.Compare(n.Date, date) == 0 && n.Type.Equals(type))
                {
                    var tempNews = Mapping.Mapper.Map<NewsModel>(n);
                    _news.Add(tempNews);
                }
            }

            return _news;
        }
    }
}
