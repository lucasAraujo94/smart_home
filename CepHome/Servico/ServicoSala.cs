using CepHome.Contextos;
using CepHome.Modelos;
using Microsoft.EntityFrameworkCore;

namespace CepHome.Servico
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
