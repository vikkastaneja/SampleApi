using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShapeApi.Shape;
using ShapeApi.Json;
using System.Runtime.Serialization.Json;
using System.IO;

namespace ShapeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<string> Get(string shape, int side1, int side2)
        {
            var jshape = new JsonShape();
            jshape.shape = shape.ToLower();
            
            jshape.side1 = side1;
            jshape.side2 = side2;

            if (String.IsNullOrEmpty(shape))
            {
                jshape.result = "Fail";
                return GetResultString(jshape);
            }

            var result = 0;
            Shape.Shape s = null;
            switch (shape.ToLower())
            {
                case "square":
                    s = new Square(side1 == 0 ? side2 : side1);
                    result = s.Area();
                    jshape.result = "Success";
                    break;
                case "rectangle":
                    s = new Rectangle(side1, side2);
                    result = s.Area();
                    jshape.result = "Success";
                    break;
                default:
                    jshape.result = "Fail";
                    break;
                    
            }

            jshape.area = result;

            return GetResultString(jshape);
            
        }

        private string GetResultString(JsonShape jshape)
        {
            var stream1 = new MemoryStream();
            var ser = new DataContractJsonSerializer(typeof(JsonShape));

            ser.WriteObject(stream1, jshape);

            stream1.Position = 0;
            var sr = new StreamReader(stream1);


            return sr.ReadToEnd();
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
