using System.ComponentModel.DataAnnotations;

namespace Laboratorio_15
{
    public class ClaseAnimalSerpientes : claseAnimales
    {
        [Required(ErrorMessage = "Este campo es requerido llenarla")]
        public string Venenosa { get; set; }
        [Required(ErrorMessage = "Este campo es requerido llenarla")]
        public string Longuitud {  get; set; }
    }
}
