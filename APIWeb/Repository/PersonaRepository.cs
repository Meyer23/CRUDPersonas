using CRUDPersonas.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APIWeb.Repository
{
    public class PersonaRepository : IPersonaRepository

    {
        private readonly OracleDbContext _dbContext; 
        public PersonaRepository(OracleDbContext context)
        {
            _dbContext = context;
        }

        public async Task<IEnumerable<Persona>> GetPersonas() => await _dbContext.Persona.ToListAsync(); 
    }
}
