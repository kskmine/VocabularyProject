using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VocabularyProject.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class WordController : ControllerBase
    {
        IWordDefinitionRepository _wordDefRepo;

        public WordController(IWordDefinitionRepository wordDefRepo)
        {
            _wordDefRepo = wordDefRepo;
        }

        // GET: api/<WordController>
        [HttpGet]
        public List<WordDefinition> Get()
        {
            return _wordDefRepo.List();
        }

        // GET api/<WordController>/5
        [HttpGet("{id}")]
        public WordDefinition Get(int id)
        {
            return _wordDefRepo.GetById(id);
        }

        // POST api/<WordController>
        [HttpPost]
        public IActionResult Post([FromForm] WordDefinition value)
        {
            if (value.Id>0)
            {
                _wordDefRepo.Update(value);
               return Accepted(true);
            }
            else
            {
                _wordDefRepo.Add(value);
                return Created("", value);
            }            
        }

        // PUT api/<WordController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<WordController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _wordDefRepo.Delete(id);
            return NoContent();
        }
    }
}
