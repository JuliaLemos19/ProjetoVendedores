public class Venda
{
    public int Qtde { get; set; }
    public double Valor { get; set; }

    public double ValorMedio()
    {
        return Qtde > 0 ? Valor / Qtde : 0;
    }
}