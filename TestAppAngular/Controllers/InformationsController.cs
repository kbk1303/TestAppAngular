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

        // GET api/informations/{id}
        [HttpGet("{id}", Name = "GetInformationById")]
        public ActionResult<InformationReadDto> GetInformationById(int id)
        {
            var result = repo.GetInformationById(id);
            if (result != null)
                return Ok(mapper.Map<InformationReadDto>(result));
            return NotFound();
        }

        //POST api/informations
        [HttpPost]
        public ActionResult<InformationReadDto> CreateInformation(InformationCreateDto info)
        {
            var InfoModel = mapper.Map<Information>(info);
            this.repo.CreateInformation(InfoModel);
            this.repo.SaveChanges();

            var ReadDto = mapper.Map<InformationReadDto>(InfoModel);

            return CreatedAtRoute(nameof(GetInformationById), new { Id = ReadDto.Id }, ReadDto);

            //return Ok(ReadDto);
        }

        //PUT api/informations/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateInformation(int id, InformationUpdateDto UpdatedInfo)
        {
            var exists = repo.GetInformationById(id);
            if (exists.Equals(null))
                return NotFound();
            mapper.Map(UpdatedInfo, exists);
            repo.UpdateInformation(exists);
            repo.SaveChanges();
            return NoContent();
        }

        //DELETE api/informations/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteInformation(int id)
        {
            var exists = repo.GetInformationById(id);
            if (exists.Equals(null))
                return NotFound();

            repo.DeleteInformation(exists);
            repo.SaveChanges();
            return NoContent();

        }
    }
}
