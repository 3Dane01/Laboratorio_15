using System.ComponentModel.DataAnnotations;

namespace Laboratorio_15
{
    public class claseAnimales
    {
        [Required(ErrorMessage = "Este campo es requerido llenarla")]
        public string NombreAnimal {  get; set; }
        [Required(ErrorMessage = "Este campo es requerido llenarla")]
        public string Especie {  get; set; }
        [Required(ErrorMessage = "Este campo es requerido llenarla")]
        public string TipoAlimentacion { get; set; }
        [Required(ErrorMessage = "Este campo es requerido llenarla")]
        public string TiempoMaximaVida {  get; set; }

    }
}
