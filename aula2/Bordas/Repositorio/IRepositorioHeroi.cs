using aula2.DTO.Heroi.AdicionarHeroi;
using aula2.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula2.Repositorio
{
    public interface IRepositorioHeroi 
    {
         void Add(Heroi request);
    }   
}
