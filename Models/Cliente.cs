namespace WebApplication1.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CPF { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public Endereco Endereco { get; set; }
    }
}
