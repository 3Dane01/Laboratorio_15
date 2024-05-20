using System.ComponentModel.DataAnnotations;

namespace Laboratorio_15
{
    public class ClaseAnimalAves:claseAnimales
    {
        [Required(ErrorMessage = "Este campo es requerido llenarla")]
        public string Vuela {  get; set; }
        [Required(ErrorMessage = "Este campo es requerido llenarla")]
        public string PeriodoIncubacion { get; set; }
            
    }
}
