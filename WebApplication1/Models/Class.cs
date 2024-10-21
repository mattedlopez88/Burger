namespace WebApplication1.Models
{
    public class Burger
    {
        public int Id { get; set; }
        public string? Name { get; set; }//? lo convierte en un campo obligaotio
        public bool withCheese { get; set; }
        public decimal Price { get; set; }
    }
}
