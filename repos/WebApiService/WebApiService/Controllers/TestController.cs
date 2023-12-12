using System.Collections.Generic;
using System.Web.Http;

namespace WebApiService.Controllers
{
    public class TestController : ApiController
    {
        static List<string> colors = new List<string>()
        {
            "Red","Blue","Green","Black","White","Grey"
        };
        public IEnumerable<string> Get()
        {
            return colors;
        }
        public string Get(int id)
        {
            return colors[id];
        }
        public string Post([FromBody]string color)
        {
            colors.Add(color);
            return "Color is Added";
        }
        public string Put(int id, [FromBody]string color)
        {
            colors[id]=color;
            return "Color is Updated";
        }
        public string Delete(int id)
        {
            colors.RemoveAt(id);
            return "Color is Deleted";

        }
    }
}