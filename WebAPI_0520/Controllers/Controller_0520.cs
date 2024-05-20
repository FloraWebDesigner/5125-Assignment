using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_0520.Controllers
{
    public class AddtenController : ApiController
    {
        // GET api/Addten/{id}
        public int Get(int id)
        {
            int Addten = id + 10;
            return Addten;
        }
    }
    public class SquareController : ApiController
    {
        // GET api/Square/{id}
        public int Get(int id)
        {
            int Square = id * id;
            return Square;
        }
    }
    public class GreetigController : ApiController
    {
        // POST api/Greeting
        public void Post([FromBody] string value)
        {
        }
    }
}
