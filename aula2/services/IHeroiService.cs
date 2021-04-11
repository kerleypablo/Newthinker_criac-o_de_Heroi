using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula2.entities;

namespace aula2.services
{
     public interface IHeroiService
    {
        bool AdicionarHeroi(Heroi heroi);
        List<Heroi> RetornarListadeHeroi();
        Poderes AdicionarPoderporId(Poderes id);

       Fraquesa AdicionarFraquesaporId(Fraquesa id);

        Fantasia Adicionarfantasiaporid(Fantasia id);

        bool AtualizarHeroi(Heroi heroi);
        bool DeletarHeroi(int id);

        Heroi RetornarHeroiporId(int id);


    }
}
