using PrimerParcial.Entidades;
using System.ComponentModel.DataAnnotations;

namespace PrimerParcial.Models
{
    public class BarcoModel : Barco
    {
        public int id { get; set; }
        [Required(ErrorMessage ="Campo Requerido")]
        [MaxLength(20,ErrorMessage = "Hasta 20 Caracteres")]
        public string nombre { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        [Range(1, 199,ErrorMessage = "Rango mayor a 0 y menor o igual a 200")]
        public double antiguedad { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        [Range(1, 499, ErrorMessage = "Rango mayor o igual a 1 y menor a 500")]
        public int tripulacionMaxima { get; set; }
        public double tasa { get; set; }
        public BarcoModel() { }
        public BarcoModel(Barco barco)
        {
            id = barco.id;
            nombre= barco.nombre;
            antiguedad= barco.antiguedad;
            tripulacionMaxima = barco.tripulacionMaxima;
            tasa= barco.tasa;
        }
    }
}
