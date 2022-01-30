using smartHome.Contextos;
using smartHome.Modelos;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace smartHome.Servico
{
    public class ServicoSala
    {
        protected readonly Contexto Db;
        protected readonly DbSet<Sala> DbSet;

        public ServicoSala(Contexto db)
        {
            Db = db;
            DbSet = db.Set<Sala>();
        }


        public async Task<Sala> ObterPorId(int id)
        {
            return await DbSet.FindAsync(id);
        }
    }
}
