﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartSchool.API.Data;
using SmartSchool.API.Models;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmartSchool.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        public readonly IRepository _repo;

        public AlunoController(IRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _repo.GetAllAlunos(true);
            return Ok(result);
        }

        // GET api/1
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var aluno = _repo.GetAllAlunoById(id, false);

            if (aluno == null)
            {
                return BadRequest("Aluno não foi encontrado");
            }

            return Ok(aluno);
        }

        //[HttpGet("ByName")]
        //public IActionResult GetByName(string nome, string sobrenome)
        //{
        //    var aluno = _context.Alunos.FirstOrDefault(a => a.Nome.Contains(nome) && a.Sobrenome.Contains(sobrenome));

        //    if (aluno == null)
        //    {
        //        return BadRequest("Aluno não foi encontrado");
        //    }

        //    return Ok(aluno);
        //}

        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
            _repo.Add(aluno);            
            if (_repo.SaveChanges())
            {
                return Ok(aluno);
            }

            return BadRequest("Aluno não cadastrado!");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno)
        {
            var alu = _repo.GetAllAlunoById(id);
            if (alu == null)
            {
                return BadRequest("Aluno não encontrado");
            }

            _repo.Update(aluno);
            if (_repo.SaveChanges())
            {
                return Ok(aluno);
            }

            return BadRequest("Aluno não atualizado!");
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Aluno aluno)
        {
            var alu = _repo.GetAllAlunoById(id);
            if (alu == null)
            {
                return BadRequest("Aluno não encontrado");
            }

            _repo.Update(aluno);
            if (_repo.SaveChanges())
            {
                return Ok(aluno);
            }

            return BadRequest("Aluno não atualizado!");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var aluno = _repo.GetAllAlunoById(id);
            if (aluno == null)
            {
                return BadRequest("Aluno não encontrado");
            }

            _repo.Delete(aluno);
            if (_repo.SaveChanges())
            {
                return Ok(aluno);
            }

            return BadRequest("Aluno não deletado!");

        }        
    }
}
