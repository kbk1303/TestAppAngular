using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAppAngular.DataRepository;
using TestAppAngular.Models;

namespace TestAppAngular.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InformationsController : ControllerBase
    {
        private readonly IInformationRepo repo;
        public InformationsController(IInformationRepo repo)
        {
            this.repo = repo;
        }
        
        // GET api/informations
        [HttpGet]
        public ActionResult<IEnumerable<Information>> GetAllInformations()
        {
            return Ok(repo.FetchAllInformations());
        } 
        
        // GEt api/informations/5
        [HttpGet("{id}")]
        public ActionResult<Information> getInformationById(int id)
        {
            return Ok(repo.GetInformationById(id));
        }

    }
}
