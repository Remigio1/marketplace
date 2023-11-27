namespace WebApplication1.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string CNPJ { get; set; }
        public int Comissao { get; set; }
        public int Endereco_Id { get; set; }
    }
}
