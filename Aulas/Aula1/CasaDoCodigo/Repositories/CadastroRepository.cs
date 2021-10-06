using CasaDoCodigo.Models;

namespace CasaDoCodigo.Repositories
{
    public interface ICadastroRepository
    {

    }

    public class CadastroRepository : BaseRepository<Cadastro>, ICadastroRepository
    {
        public CadastroRepository(AppContext context) : base(context)
        {
        }
    }
}
