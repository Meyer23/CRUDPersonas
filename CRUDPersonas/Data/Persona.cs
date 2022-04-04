using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace CRUDPersonas.Data
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Nombre { get; set; }
        [Required, StringLength(50)]
        public string Apellido { get; set; }
        [Required]
        public int Nro_Documento { get; set; }
        [Required, EmailAddress]
        public string Correo_Electronico { get; set; }
        [Phone]
        public string Telefono  { get; set; }
        [Required]
        public DateTime Fecha_Nacimiento { get; set; }
    }
}
