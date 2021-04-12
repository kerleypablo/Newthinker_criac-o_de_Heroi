using aula2.context;
using aula2.entities;


namespace aula2.Repositorio
{
    public class RepositorioHeroi : IRepositorioHeroi
    {
        private readonly LocalDBContext _local;

        public RepositorioHeroi(LocalDBContext local)
        {
            _local = local;
        }

        public void Add(Heroi request)
        {
            _local.heroi.Add(request);
            _local.SaveChanges();
        }
    }
}
