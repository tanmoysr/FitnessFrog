using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using FitnessFrog.Shared.Models;

namespace FitnessFrog.Spa.Controllers
{
    public class IntensitiesController : ApiController
    {
        public IHttpActionResult Get()
        {
            var results = Enum.GetValues(typeof(Entry.IntensityLevel))
                .Cast<Entry.IntensityLevel>()
                .Select(il => new { id = (int)il, name = il.ToString() })
                .ToList();

            return Ok(results);
        }
    }
}