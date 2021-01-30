using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartSchool.API.Data;
using SmartSchool.API.Models;
using System.Linq;

namespace SmartSchool.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorController : ControllerBase
    {
        public readonly IRepository _repo;

        public ProfessorController(IRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _repo.GetAllProfessores(true);
            return Ok(result);
        }

        // GET api/5
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var professor = _repo.GetAllProfessorById(id);

            if (professor == null)
            {
                return BadRequest("Professor não foi encontrado");
            }

            return Ok(professor);
        }

        //[HttpGet("ByName")]
        //public IActionResult GetByName(string nome, string sobrenome)
        //{
        //    var professor = _context.Professores.FirstOrDefault(a => a.Nome.Contains(nome));

        //    if (professor == null)
        //    {
        //        return BadRequest("Professor não foi encontrado");
        //    }

        //    return Ok(professor);
        //}

        [HttpPost]
        public IActionResult Post(Professor professor)
        {
            _repo.Add(professor);
            if (_repo.SaveChanges())
            {
                return Ok(professor);
            }

            return BadRequest("Professor não cadastrado!");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Professor professor)
        {
            var prof = _repo.GetAllProfessorById(id);
            if (prof == null)
            {
                return BadRequest("Professor não encontrado");
            }

            _repo.Update(professor);
            if (_repo.SaveChanges())
            {
                return Ok(professor);
            }

            return BadRequest("Professor não atualizado!");
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Professor professor)
        {
            var prof = _repo.GetAllProfessorById(id);
            if (prof == null)
            {
                return BadRequest("Professor não encontrado");
            }

            _repo.Update(professor);
            if (_repo.SaveChanges())
            {
                return Ok(professor);
            }

            return BadRequest("Professor não atualizado!");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var professor = _repo.GetAllProfessorById(id);
            if (professor == null)
            {
                return BadRequest("Professor não encontrado");
            }

            _repo.Delete(professor);
            if (_repo.SaveChanges())
            {
                return Ok(professor);
            }

            return BadRequest("Professor não deletado!");
        }
    }
}
