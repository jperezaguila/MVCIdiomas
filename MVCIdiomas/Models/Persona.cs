using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using MVCIdiomas.Idiomas;

namespace MVCIdiomas.Models
{
   
    public class Persona
    {
        [Display(ResourceType = typeof(Personas),Name = "nombre")]
        [Required(ErrorMessageResourceType = typeof(Personas), ErrorMessageResourceName = "nombre_o")]
        public String Nombre { get; set; }
        
        
        
        [Display(ResourceType = typeof(Personas),Name ="saldo" )]
        [DataType(DataType.Currency, ErrorMessageResourceType = typeof(Personas), ErrorMessageResourceName = "saldo_c")]
        [Required(ErrorMessageResourceType = typeof(Personas), ErrorMessageResourceName = "saldo_o")]
        public double Saldo { get; set; }
    }
}
