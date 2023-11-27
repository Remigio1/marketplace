namespace WebApplication1.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Preco { get; set; }
        public string Imagem { get; set; }
        public bool Status { get; set; }
        public int Vendedor_Id { get; set; }
        public int Categoria_Id { get; set; }
    }
}
