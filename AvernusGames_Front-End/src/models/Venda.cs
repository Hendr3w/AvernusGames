namespace Avernus_Games_Store.src.models
{
    public class Venda
    {
        public int Id { get; set; }
        public Cliente? Cliente { get; set; }
        public string? Nf { get; set; }
        public List<ItemVenda>? Itens { get; set; }

        public Venda() { }

        public Venda(int id, Cliente cliente, string nf, List<ItemVenda> itens)
        {
            Id = id;
            Cliente = cliente;
            Nf = nf;
            Itens = itens;
        }
    }
}