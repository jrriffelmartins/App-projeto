using App.Domain.Entities;
using App.Domain.Interfaces.Application;
using App.Domain.Interfaces.Repositories;
using Cidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Services
{
    public class PessoaService : IPessoaService
    {
        private IRepositoryBase<Pessoa> _repository { get; set; }
        public PessoaService(IRepositoryBase<Pessoa> repository)
        {
            _repository = repository;
        }
        public Pessoa BuscaPorId(Guid id)
        {
            var obj = _repository.Query(x => x.Id == id).FirstOrDefault();
            return obj;
        }

        
        
        public List<Pessoa> listaPessoas()
        {
            return _repository.Query(x => 1 == 1)
            .Select(p => new Pessoa

            {

                Id = p.Id,
                Nome = p.Nome,
                Peso = p.Peso,
                Cidade = new Cidade
                {
                    Nome = p.Cidade.Nome
                }
                }).ToList();
        }
        

        private void Salvar1(Pessoa obj)
        {
            if (String.IsNullOrEmpty(obj.Nome))
            {
                throw new Exception("Informe o nome");
            }
            _repository.Save(obj);
            _repository.SaveChanges();

        }

         void IPessoaService.Salvar(Pessoa obj)
        {
            throw new NotImplementedException();
        }

      

        public void Remover(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}