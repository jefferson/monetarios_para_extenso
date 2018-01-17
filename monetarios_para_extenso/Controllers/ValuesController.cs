using monetarios_para_extenso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace monetarios_para_extenso.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values/5
        [HttpGet]
        public string Convert(double number)
        {
            return ConverteNumero.convert(number);
        }

    }
}
