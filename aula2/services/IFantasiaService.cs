using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula2.entities;

namespace aula2.services
{
     public interface IFantasiaService
    {
        bool AdicionarFantasia(Fantasia fantasia);
        List<Fantasia> RetornarListadeFantasia();
        Poder AdicionarPoderporId(Poder id);

       Fraquesa AdicionarFraquesaporId(Fraquesa id);

        bool AtualizarFantasia(Fantasia fantasia);
        bool DeletarFantasia(int id);

        Heroi RetornarfantasiaporId(int id);


    }
}
