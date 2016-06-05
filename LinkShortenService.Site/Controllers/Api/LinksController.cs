using LinkShortenService.Core.Services.Links;
using LinkShortenService.Models.WebService.Links;
using LinkShortenService.Site.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LinkShortenService.Site.Controllers.Api
{
    public class LinksController : ApiController
    {
        [HttpGet]
        [Route("api/links")]
        public HttpResponseMessage Get(int page = 10, int pageSize = 20)
        {
            var service = new LinksService(HttpContextHelper.LinkShortenContext);
            try
            {
                var result = service.GetLinks(page, pageSize);
                return this.Request.CreateResponse(HttpStatusCode.OK, result);
            } catch (Exception ex)
            {
                return this.Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/links")]
        public HttpResponseMessage Get(string shortenUrl)
        {
            var service = new LinksService(HttpContextHelper.LinkShortenContext);
            try
            {
                var result = service.LinkFollowed(shortenUrl);
                var response = Request.CreateResponse(HttpStatusCode.Found);
                response.Headers.Location = new Uri(result);
                return response;
            }
            catch (Exception ex)
            {
                return this.Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/links")]
        public HttpResponseMessage Post(string originUrl)
        {
            var service = new LinksService(HttpContextHelper.LinkShortenContext);
            try
            {
                var result = service.CreateLink(originUrl);
                return this.Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return this.Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
