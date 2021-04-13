using aula2.DTO.Poder.Deletar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula2.Bordas.UseCase.Poder
{
    public interface IRemoverPoderUseCase
    {
        DeletarPoderResponse Executar(int id);
    }
}
