namespace WebApplication1.Models
{
    public class Carrinho
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public float ValorTotal { get; set; }
        public int StatusPedido_Id { get; set; }
        public int Cliente_Id { get; set; }
    }
}
