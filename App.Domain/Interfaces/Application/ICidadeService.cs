using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cidades;

namespace App.Domain.Interfaces.Application
{
    public interface ICidadesService
    {
        Cidade BuscaPorId(Guid id);
        List<Cidade> listaCidades();
        void Salvar(Cidade obj);
        void Remover(Guid id);
    }



   
}
