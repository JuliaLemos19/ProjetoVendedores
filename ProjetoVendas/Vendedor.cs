public class Vendedor
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public double PercComissao { get; set; }
    private Venda[] AsVendas = new Venda[31]; // 31 dias do mês

    public void RegistrarVenda(int dia, Venda venda)
    {
        if (dia >= 1 && dia <= 31)
        {
            AsVendas[dia - 1] = venda;
        }
    }

    public double ValorVendas()
    {
        double total = 0;
        foreach (var venda in AsVendas)
        {
            if (venda != null)
            {
                total += venda.Valor;
            }
        }
        return total;
    }

    public double ValorComissao()
    {
        return ValorVendas() * PercComissao / 100;
    }

    public double ValorMedio()
    {
        int diasComVenda = 0;
        double total = 0;
        foreach (var venda in AsVendas)
        {
            if (venda != null)
            {
                diasComVenda++;
                total += venda.ValorMedio();
            }
        }
        return diasComVenda > 0 ? total / diasComVenda : 0;
    }
}
