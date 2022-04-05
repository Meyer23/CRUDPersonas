using CRUDPersonas.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APIWeb.Repository
{
    public interface IPersonaRepository
    {
        Task<IEnumerable<Persona>> GetPersonas(); 
    }
}
