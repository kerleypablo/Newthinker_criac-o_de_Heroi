using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula2.entities;

namespace aula2.services
{
    public interface IProdutoService
    {

        bool AdicionarProduto(Produto produto);
        List<Produto> RetornarListadeproduto();
        Produto RetornarProdutoporId(int id);
        bool AtualizarProduto(Produto produto);
        bool Deletarproduto(int id);



    }
}
