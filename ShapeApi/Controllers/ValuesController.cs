using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShapeApi.Shape;


namespace ShapeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get(string shape, int param1, int param2)
        {
            if (String.IsNullOrEmpty(shape))
            {
                return new string[1] { "Unsupported shape" };
            }

            int result = 0;
            Shape.Shape s = null;
            switch (shape.ToLower())
            {
                case "square":
                    s = new Square(param1);
                    result = s.Area();
                    break;
                case "rectangle":
                    s = new Rectangle(param1, param2);
                    result = s.Area();
                    break;
                default:
                    return new string[1]{ "Unsupported shape"};
                    
            }

            string [] returnValue = { "Area : " + result.ToString() };
            return returnValue;
        }

        //// GET api/values/5
        //[HttpGet("{id}")]
        //public ActionResult<string> Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //    throw new HttpResponseException("Unsupported operation", HttpStatusCode.BadRequest);
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
