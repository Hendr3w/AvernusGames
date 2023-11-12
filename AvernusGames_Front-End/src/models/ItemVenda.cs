namespace Avernus_Games_Store.src.models
{
    public class ItemVenda
    {
        public int Id { get; set; }
        public Produto? Produto { get; set; }
        public int Qtd { get; set; }

        public ItemVenda() { }

        public ItemVenda(Produto produto, int qtd)
        {
            Produto = produto;
            Qtd = qtd;

        }


    }
}