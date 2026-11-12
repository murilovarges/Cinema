namespace CinemaApp.Models;

public class IngressoViewModel
{
    public int Id { get; set; }
    public int SessaoId { get; set; }
    public string FormaPagamento { get; set; }
    public string Filme { get; set; }
    public string Classificacao { get; set; }
    public DateTime DataCompra { get; set; }
    public decimal ValorTotal { get; set; }
}
