﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartSchool.API.Data;

namespace SmartSchool.API.Migrations
{
    [DbContext(typeof(SmartContext))]
    partial class SmartContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("SmartSchool.API.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Ativo")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DataFim")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("TEXT");

                    b.Property<int>("Matricula")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Alunos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ativo = true,
                            DataInicio = new DateTime(2021, 1, 30, 10, 2, 57, 97, DateTimeKind.Local).AddTicks(3405),
                            DataNascimento = new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 1,
                            Nome = "Marta",
                            Sobrenome = "Kent",
                            Telefone = "33225555"
                        },
                        new
                        {
                            Id = 2,
                            Ativo = true,
                            DataInicio = new DateTime(2021, 1, 30, 10, 2, 57, 97, DateTimeKind.Local).AddTicks(8798),
                            DataNascimento = new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 2,
                            Nome = "Paula",
                            Sobrenome = "Isabela",
                            Telefone = "3354288"
                        },
                        new
                        {
                            Id = 3,
                            Ativo = true,
                            DataInicio = new DateTime(2021, 1, 30, 10, 2, 57, 97, DateTimeKind.Local).AddTicks(8890),
                            DataNascimento = new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 3,
                            Nome = "Laura",
                            Sobrenome = "Antonia",
                            Telefone = "55668899"
                        },
                        new
                        {
                            Id = 4,
                            Ativo = true,
                            DataInicio = new DateTime(2021, 1, 30, 10, 2, 57, 97, DateTimeKind.Local).AddTicks(8899),
                            DataNascimento = new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 4,
                            Nome = "Luiza",
                            Sobrenome = "Maria",
                            Telefone = "6565659"
                        },
                        new
                        {
                            Id = 5,
                            Ativo = true,
                            DataInicio = new DateTime(2021, 1, 30, 10, 2, 57, 97, DateTimeKind.Local).AddTicks(8907),
                            DataNascimento = new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 5,
                            Nome = "Lucas",
                            Sobrenome = "Machado",
                            Telefone = "565685415"
                        },
                        new
                        {
                            Id = 6,
                            Ativo = true,
                            DataInicio = new DateTime(2021, 1, 30, 10, 2, 57, 97, DateTimeKind.Local).AddTicks(8924),
                            DataNascimento = new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 6,
                            Nome = "Pedro",
                            Sobrenome = "Alvares",
                            Telefone = "456454545"
                        },
                        new
                        {
                            Id = 7,
                            Ativo = true,
                            DataInicio = new DateTime(2021, 1, 30, 10, 2, 57, 97, DateTimeKind.Local).AddTicks(8932),
                            DataNascimento = new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 7,
                            Nome = "Paulo",
                            Sobrenome = "José",
                            Telefone = "9874512"
                        });
                });

            modelBuilder.Entity("SmartSchool.API.Models.AlunoCurso", b =>
                {
                    b.Property<int>("AlunoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CursoId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DataFim")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Nota")
                        .HasColumnType("INTEGER");

                    b.HasKey("AlunoId", "CursoId");

                    b.HasIndex("CursoId");

                    b.ToTable("AlunosCursos");
                });

            modelBuilder.Entity("SmartSchool.API.Models.AlunoDisciplina", b =>
                {
                    b.Property<int>("AlunoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DisciplinaId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DataFim")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Nota")
                        .HasColumnType("INTEGER");

                    b.HasKey("AlunoId", "DisciplinaId");

                    b.HasIndex("DisciplinaId");

                    b.ToTable("AlunosDiciplinas");

                    b.HasData(
                        new
                        {
                            AlunoId = 1,
                            DisciplinaId = 2,
                            DataInicio = new DateTime(2021, 1, 30, 10, 2, 57, 98, DateTimeKind.Local).AddTicks(1804)
                        },
                        new
                        {
                            AlunoId = 1,
                            DisciplinaId = 4,
                            DataInicio = new DateTime(2021, 1, 30, 10, 2, 57, 98, DateTimeKind.Local).AddTicks(3567)
                        },
                        new
                        {
                            AlunoId = 1,
                            DisciplinaId = 5,
                            DataInicio = new DateTime(2021, 1, 30, 10, 2, 57, 98, DateTimeKind.Local).AddTicks(3637)
                        },
                        new
                        {
                            AlunoId = 2,
                            DisciplinaId = 1,
                            DataInicio = new DateTime(2021, 1, 30, 10, 2, 57, 98, DateTimeKind.Local).AddTicks(3640)
                        },
                        new
                        {
                            AlunoId = 2,
                            DisciplinaId = 2,
                            DataInicio = new DateTime(2021, 1, 30, 10, 2, 57, 98, DateTimeKind.Local).AddTicks(3642)
                        },
                        new
                        {
                            AlunoId = 2,
                            DisciplinaId = 5,
                            DataInicio = new DateTime(2021, 1, 30, 10, 2, 57, 98, DateTimeKind.Local).AddTicks(3776)
                        },
                        new
                        {
                            AlunoId = 3,
                            DisciplinaId = 1,
                            DataInicio = new DateTime(2021, 1, 30, 10, 2, 57, 98, DateTimeKind.Local).AddTicks(3780)
                        },
                        new
                        {
                            AlunoId = 3,
                            DisciplinaId = 2,
                            DataInicio = new DateTime(2021, 1, 30, 10, 2, 57, 98, DateTimeKind.Local).AddTicks(3782)
                        },
                        new
                        {
                            AlunoId = 3,
                            DisciplinaId = 3,
                            DataInicio = new DateTime(2021, 1, 30, 10, 2, 57, 98, DateTimeKind.Local).AddTicks(3784)
                        },
                        new
                        {
                            AlunoId = 4,
                            DisciplinaId = 1,
                            DataInicio = new DateTime(2021, 1, 30, 10, 2, 57, 98, DateTimeKind.Local).AddTicks(3788)
                        },
                        new
                        {
                            AlunoId = 4,
                            DisciplinaId = 4,
                            DataInicio = new DateTime(2021, 1, 30, 10, 2, 57, 98, DateTimeKind.Local).AddTicks(3791)
                        },
                        new
                        {
                            AlunoId = 4,
                            DisciplinaId = 5,
                            DataInicio = new DateTime(2021, 1, 30, 10, 2, 57, 98, DateTimeKind.Local).AddTicks(3793)
                        },
                        new
                        {
                            AlunoId = 5,
                            DisciplinaId = 4,
                            DataInicio = new DateTime(2021, 1, 30, 10, 2, 57, 98, DateTimeKind.Local).AddTicks(3797)
                        },
                        new
                        {
                            AlunoId = 5,
                            DisciplinaId = 5,
                            DataInicio = new DateTime(2021, 1, 30, 10, 2, 57, 98, DateTimeKind.Local).AddTicks(3799)
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 1,
                            DataInicio = new DateTime(2021, 1, 30, 10, 2, 57, 98, DateTimeKind.Local).AddTicks(3801)
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 2,
                            DataInicio = new DateTime(2021, 1, 30, 10, 2, 57, 98, DateTimeKind.Local).AddTicks(3803)
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 3,
                            DataInicio = new DateTime(2021, 1, 30, 10, 2, 57, 98, DateTimeKind.Local).AddTicks(3805)
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 4,
                            DataInicio = new DateTime(2021, 1, 30, 10, 2, 57, 98, DateTimeKind.Local).AddTicks(3809)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 1,
                            DataInicio = new DateTime(2021, 1, 30, 10, 2, 57, 98, DateTimeKind.Local).AddTicks(3811)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 2,
                            DataInicio = new DateTime(2021, 1, 30, 10, 2, 57, 98, DateTimeKind.Local).AddTicks(3813)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 3,
                            DataInicio = new DateTime(2021, 1, 30, 10, 2, 57, 98, DateTimeKind.Local).AddTicks(3815)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 4,
                            DataInicio = new DateTime(2021, 1, 30, 10, 2, 57, 98, DateTimeKind.Local).AddTicks(3817)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 5,
                            DataInicio = new DateTime(2021, 1, 30, 10, 2, 57, 98, DateTimeKind.Local).AddTicks(3819)
                        });
                });

            modelBuilder.Entity("SmartSchool.API.Models.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cursos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Tecnologia da Informação"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Sistema de Informação"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Ciência da Computação"
                        });
                });

            modelBuilder.Entity("SmartSchool.API.Models.Disciplina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CargaHoraria")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CursoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PrerequisitoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProfessorId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CursoId");

                    b.HasIndex("PrerequisitoId");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Disciplinas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CargaHoraria = 0,
                            CursoId = 1,
                            Nome = "Matemática",
                            ProfessorId = 1
                        },
                        new
                        {
                            Id = 2,
                            CargaHoraria = 0,
                            CursoId = 3,
                            Nome = "Matemática",
                            ProfessorId = 1
                        },
                        new
                        {
                            Id = 3,
                            CargaHoraria = 0,
                            CursoId = 3,
                            Nome = "Física",
                            ProfessorId = 2
                        },
                        new
                        {
                            Id = 4,
                            CargaHoraria = 0,
                            CursoId = 1,
                            Nome = "Português",
                            ProfessorId = 3
                        },
                        new
                        {
                            Id = 5,
                            CargaHoraria = 0,
                            CursoId = 1,
                            Nome = "Inglês",
                            ProfessorId = 4
                        },
                        new
                        {
                            Id = 6,
                            CargaHoraria = 0,
                            CursoId = 2,
                            Nome = "Inglês",
                            ProfessorId = 4
                        },
                        new
                        {
                            Id = 7,
                            CargaHoraria = 0,
                            CursoId = 3,
                            Nome = "Inglês",
                            ProfessorId = 4
                        },
                        new
                        {
                            Id = 8,
                            CargaHoraria = 0,
                            CursoId = 1,
                            Nome = "Programação",
                            ProfessorId = 5
                        },
                        new
                        {
                            Id = 9,
                            CargaHoraria = 0,
                            CursoId = 2,
                            Nome = "Programação",
                            ProfessorId = 5
                        },
                        new
                        {
                            Id = 10,
                            CargaHoraria = 0,
                            CursoId = 3,
                            Nome = "Programação",
                            ProfessorId = 5
                        });
                });

            modelBuilder.Entity("SmartSchool.API.Models.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Ativo")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DataFim")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<int>("Registro")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Professores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ativo = true,
                            DataInicio = new DateTime(2021, 1, 30, 10, 2, 57, 87, DateTimeKind.Local).AddTicks(4868),
                            DataNascimento = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Lauro",
                            Registro = 1,
                            Sobrenome = "Oliveira"
                        },
                        new
                        {
                            Id = 2,
                            Ativo = true,
                            DataInicio = new DateTime(2021, 1, 30, 10, 2, 57, 89, DateTimeKind.Local).AddTicks(6502),
                            DataNascimento = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Roberto",
                            Registro = 2,
                            Sobrenome = "Soares"
                        },
                        new
                        {
                            Id = 3,
                            Ativo = true,
                            DataInicio = new DateTime(2021, 1, 30, 10, 2, 57, 89, DateTimeKind.Local).AddTicks(6597),
                            DataNascimento = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Ronaldo",
                            Registro = 3,
                            Sobrenome = "Marconi"
                        },
                        new
                        {
                            Id = 4,
                            Ativo = true,
                            DataInicio = new DateTime(2021, 1, 30, 10, 2, 57, 89, DateTimeKind.Local).AddTicks(6600),
                            DataNascimento = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Rodrigo",
                            Registro = 4,
                            Sobrenome = "Carvalho"
                        },
                        new
                        {
                            Id = 5,
                            Ativo = true,
                            DataInicio = new DateTime(2021, 1, 30, 10, 2, 57, 89, DateTimeKind.Local).AddTicks(6603),
                            DataNascimento = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Alexandre",
                            Registro = 5,
                            Sobrenome = "Montanha"
                        });
                });

            modelBuilder.Entity("SmartSchool.API.Models.AlunoCurso", b =>
                {
                    b.HasOne("SmartSchool.API.Models.Aluno", "Aluno")
                        .WithMany()
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartSchool.API.Models.Curso", "Curso")
                        .WithMany()
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SmartSchool.API.Models.AlunoDisciplina", b =>
                {
                    b.HasOne("SmartSchool.API.Models.Aluno", "Aluno")
                        .WithMany("AlunosDisciplinas")
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartSchool.API.Models.Disciplina", "Disciplina")
                        .WithMany("AlunosDisciplinas")
                        .HasForeignKey("DisciplinaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SmartSchool.API.Models.Disciplina", b =>
                {
                    b.HasOne("SmartSchool.API.Models.Curso", "Curso")
                        .WithMany("Disciplinas")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartSchool.API.Models.Disciplina", "Prerequisito")
                        .WithMany()
                        .HasForeignKey("PrerequisitoId");

                    b.HasOne("SmartSchool.API.Models.Professor", "Professor")
                        .WithMany("Disciplinas")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}