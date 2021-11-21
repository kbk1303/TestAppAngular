using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAppAngular.DataRepository;
using TestAppAngular.DataTransferObjects;
using TestAppAngular.Models;

namespace TestAppAngular.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InformationsController : ControllerBase
    {
        private readonly IInformationRepo repo;

        public readonly IMapper mapper;

        public InformationsController(IInformationRepo repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }
        
        // GET api/informations
        [HttpGet]
        public ActionResult<IEnumerable<Information>> GetAllInformations()
        {
            var items = repo.FetchAllInformations();
            return Ok(mapper.Map<IEnumerable<InformationReadDto>>(items));
        } 
        
        // GEt api/informations/5
        [HttpGet("{id}")]
        public ActionResult<InformationReadDto> getInformationById(int id)
        {
            var result = repo.GetInformationById(id);
            if (result != null)
                return Ok(mapper.Map<InformationReadDto>(result)); 
            return NotFound(); 
        }

    }
}
