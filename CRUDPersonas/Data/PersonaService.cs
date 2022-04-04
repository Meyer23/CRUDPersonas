using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace CRUDPersonas.Data
{
    public class PersonaService
    {
        #region Property 
        private readonly OracleDbContext _appDBContext;
        #endregion

        #region Constructor 
        public PersonaService(OracleDbContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion

        #region Listar Personas
        public async Task<List<Persona>> GetAllPersonasAsync()
        {
            return await _appDBContext.Persona.ToListAsync();
        }
        #endregion
        #region Insertar Persona
        public async Task<bool> InsertPersonaAsync(Persona persona)
        {
            var findPersonaByEmail = await _appDBContext.Persona.FirstOrDefaultAsync(p => p.Correo_Electronico.Equals(persona.Correo_Electronico));
            var findPersonaByDocumento = await _appDBContext.Persona.FirstOrDefaultAsync(p => p.Nro_Documento.Equals(persona.Nro_Documento));
            if(findPersonaByEmail == null && findPersonaByDocumento == null)
            {
                await _appDBContext.Persona.AddAsync(persona);
                await _appDBContext.SaveChangesAsync();
                return true;
            }
            return false;
        }
        #endregion
        #region Obtener persona por Id 
        public async Task<Persona> GetPersonaAsync(int Id)
        {
            Persona persona = await _appDBContext.Persona.FirstOrDefaultAsync(p => p.Id.Equals(Id));
            return persona; 
        }
        #endregion
        #region Actualizar datos de una persona 
        public async Task<bool> UpdatePersonaAsync(Persona persona)
        {
            _appDBContext.Persona.Update(persona);
            await _appDBContext.SaveChangesAsync();
            return true; 
        }
        #endregion
        #region Eliminar Persona 
        public async Task<bool> DeletePersonaAsync(Persona persona)
        {
            _appDBContext.Remove(persona); 
            await _appDBContext.SaveChangesAsync();
            return true; 
        }
        #endregion
    }
}
