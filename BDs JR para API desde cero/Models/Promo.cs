namespace BDs_JR_para_API_desde_cero.Models
{
    public class Promo
    {
        public int PromoID { get; set; }
        public String? Descripcion { get; set; }
        public DateTime FechaPromo { get; set; }
        public int BurgerID { get; set; }
        public Burger? Burger { get; set; }
    }
}
