namespace SmartSchool.API.Models
{
    public class AlunoDisciplina
    {
        public AlunoDisciplina()
        {

        }

        public AlunoDisciplina(int alunoId, int disciplinaID)
        {
            AlunoId = alunoId;
            DisciplinaID = disciplinaID;
        }

        public int AlunoId { get; set; }

        public Aluno Aluno { get; set; }

        public int DisciplinaID { get; set; }

        public Disciplina Disciplina { get; set; }
    }
}
