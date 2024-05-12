using System.ComponentModel.DataAnnotations;

namespace BDs_JR_para_API_desde_cero.Models
{
    public class Burger
    {
        public int ID { get; set; }
        [Required]
        public string? Name { get; set; }
        public bool WithCheese { get; set; }
        [Range(0.01, 9999.99)]
        public decimal Precio { get; set; }
        public List<Promo>? Promo { get; set; }
    }
}
