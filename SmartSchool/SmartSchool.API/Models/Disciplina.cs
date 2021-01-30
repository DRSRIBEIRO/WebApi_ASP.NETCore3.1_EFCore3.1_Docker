using System.Collections.Generic;

namespace SmartSchool.API.Models
{
    public class Disciplina
    {
        public Disciplina()
        {

        }

        public Disciplina(int id, string nome, int cursoId, int professorId)
        {
            Id = id;
            Nome = nome;
            CursoId = cursoId;
            ProfessorId = professorId;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }
        public int? PrerequisitoId { get; set; } = null;
        public Disciplina Prerequisito { get; set; }
        public int CursoId { get; set; }
        public Curso Curso { get; set; }
        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }
        public IEnumerable<AlunoDisciplina> AlunosDisciplinas { get; set; } 
    }
}
