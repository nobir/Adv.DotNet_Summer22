using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace Task1.Controllers
{
    public class ValidateModelAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            if(actionContext.ModelState.IsValid == false)
            {
                //var errors = actionContext.ModelState.Where(e => e.Value.Errors.Count > 0).Select(e => new
                //{
                //    Name = e.Key.Split('.').Last(),
                //    Message = e.Value.Errors.First().ErrorMessage
                //}).ToList();

                //actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.BadRequest, new Dictionary<string, object>()
                //{
                //    { "ErrorList", errors }
                //});

                actionContext.Response = actionContext.Request.CreateErrorResponse(HttpStatusCode.BadRequest, actionContext.ModelState);
            }
        }
    }
}