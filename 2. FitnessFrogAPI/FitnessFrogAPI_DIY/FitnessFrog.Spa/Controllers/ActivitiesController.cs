using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using FitnessFrog.Shared.Data;

namespace FitnessFrog.Spa.Controllers
{
    public class ActivitiesController : ApiController
    {
        private ActivitiesRepository _activitiesRepository = null;

        public ActivitiesController(ActivitiesRepository activitiesRepository)
        {
            _activitiesRepository = activitiesRepository;
        }

        public IHttpActionResult Get()
        {
            return Ok(_activitiesRepository.GetList());
        }
    }
}