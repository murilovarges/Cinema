namespace CinemaApp.Models;

public class SessaoViewModel
{
    public int Id { get; set; }
    public int FilmeId { get; set; }
    public string FilmeNome { get; set; }
    public string Classificacao { get; set; }
    public int SalaId { get; set; }    
    public DateTime Data { get; set; }
    public decimal Preco { get; set; }
}
