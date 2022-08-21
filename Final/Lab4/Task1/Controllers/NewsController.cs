using BLL.BOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Task1.Controllers
{
    [EnableCors("*", "*", "*")]
    public class NewsController : ApiController
    {
        
        [Route("api/news/create")]
        [ValidateModel]
        [HttpPost]
        public HttpResponseMessage Create(NewsModel news)
        {
            var isCreated = NewsService.Create(news);
            return isCreated ? Request.CreateResponse(HttpStatusCode.OK, new { Message = "News Created successfully" }) : Request.CreateResponse(HttpStatusCode.BadRequest, new { Message = "News Create unsuccessfully" });
        }

        [Route("api/news/category/{name}")]
        [HttpGet]
        public HttpResponseMessage GetNewsByCategory(string category)
        {
            var data = NewsService.GetNewsByCategory(category);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/news/date/{date}")]
        [HttpGet]
        public HttpResponseMessage GetNewsByDate(string date)
        {
            var _date = new DateTime();
            bool isItPossible;
            try
            {
                _date = DateTime.Parse(date);
                isItPossible = true;
            }
            catch (Exception)
            {
                isItPossible = false;
            }

            var data = isItPossible ? NewsService.GetNewsByDate(_date) : new List<NewsModel>();

            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/news/user/{id}")]
        [HttpGet]
        public HttpResponseMessage GetNewsByUser(int id)
        {
            var data = NewsService.GetNewsByUser(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/news/user/{id}/date/{date}")]
        [HttpGet]
        public HttpResponseMessage GetNewsByUser(int id, string date)
        {
            var _date = new DateTime();
            bool isItPossible;
            try
            {
                _date = DateTime.Parse(date);
                isItPossible = true;
            }
            catch (Exception)
            {
                isItPossible = false;
            }

            var data = isItPossible ? NewsService.GetNewsByUserDate(id, _date) : new List<NewsModel>();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/news/user/{id}/date/{date}/type/{type}")]
        [HttpGet]
        public HttpResponseMessage GetNewsByUser(int id, string date, string type)
        {
            var _date = new DateTime();
            bool isItPossible;
            try
            {
                _date = DateTime.Parse(date);
                isItPossible = true;
            }
            catch (Exception)
            {
                isItPossible = false;
            }

            var data = isItPossible ? NewsService.GetNewsByUserDateType(id, _date, type) : new List<NewsModel>();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
