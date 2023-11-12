namespace Avernus_Games_Store.src.models
{
    public class Endereco
    {
        public string? Pais { get; set; }
        public string? Estado { get; set; }
        public string? Cidade { get; set; }
        public string? Rua { get; set; }
        public string? Num { get; set; }

        public Endereco() { }
        public Endereco(string estado, string cidade, string rua, string num)
        {
            Pais = "Brasil";
            Cidade = cidade;
            Estado = estado;
            Rua = rua;
            Num = num;
        }

        public Endereco(string pais, string estado, string cidade, string rua, string num)
        {
            Pais = pais;
            Cidade = cidade;
            Estado = estado;
            Rua = rua;
            Num = num;
        }
    }
}