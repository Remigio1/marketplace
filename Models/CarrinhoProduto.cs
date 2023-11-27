namespace WebApplication1.Models
{
    public class CarrinhoProduto
    {
        public int Quantidade { get; set; }
        public float Total { get; set; }
        public int Carrinho_Id { get; set; }
        public int Produto_Id { get; set; }
    }
}
