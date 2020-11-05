using Projeto.Business.Dto;
using Projeto.Business.Interfaces.Repositorio;
using Projeto.Infra.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Projeto.Infra.Repositorio
{
    public class Repositorio : IRepositorio
    {
        public Repositorio() { }

        bool IRepositorio.CadastrarAluno(Aluno aluno)
        {
            try
            {
                using (DbContexto db = new DbContexto())
                {
                    db.Alunos.Add(aluno);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        IList<Aluno> IRepositorio.ListarAlunos()
        {
            try
            {
                using (DbContexto db = new DbContexto())
                {
                    return db.Alunos.ToList();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        bool IRepositorio.ExcluirAluno(Aluno aluno)
        {
            try
            {
                using (DbContexto db = new DbContexto())
                {
                    db.Entry(aluno).State = System.Data.Entity.EntityState.Deleted;
                    db.Alunos.Remove(aluno);

                    db.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        bool IRepositorio.AtualizarAluno(Aluno aluno)
        {
            try
            {
                using (DbContexto db = new DbContexto())
                {
                    db.Entry(aluno).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Aluno ObterAlunoPorId(int idAluno)
        {
            using (DbContexto db = new DbContexto())
            {
                return db.Alunos.Where(x => x.Id == idAluno).FirstOrDefault();
            }
        }
    }
}
