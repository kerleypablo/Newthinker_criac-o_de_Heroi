using aula2.DTO.Poder;
using aula2.DTO.Poder.Adicionar;
using aula2.DTO.Poder.Atulizar;
using aula2.entities;


namespace aula2.Bordas.Adapter
{
    public interface IPoderAdapter
    {

        Poder ConvertAdicionarPoderRequestParaPoder(AdicionarPoderRequest request);

        Poder ConvertAtualizarPoderRequestParaPoder(AtualizarPoderRequest request);

        PoderResponse ConvertPoderParaPoderResponse(Poder poder);

        Poder ConvertRequestParaPoder(PoderRequest request);

    }
}
