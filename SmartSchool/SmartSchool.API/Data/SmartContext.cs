﻿using Microsoft.EntityFrameworkCore;
using SmartSchool.API.Models;

namespace SmartSchool.API.Data
{
    public class SmartContext : DbContext
    {
        public SmartContext(DbContextOptions<SmartContext> options) : base(options)
        {

        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<Aluno> AlunosDiciplinas { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AlunoDisciplina>()
                .HasKey(AD => new { AD.AlunoId, AD.DisciplinaID });
        }
    }
}