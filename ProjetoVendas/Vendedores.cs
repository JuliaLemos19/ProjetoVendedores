public class Vendedores
{
    private List<Vendedor> OsVendedores = new List<Vendedor>();
    private const int Max = 10;

    public bool AddVendedor(Vendedor v)
    {
        if (OsVendedores.Count < Max)
        {
            OsVendedores.Add(v);
            return true;
        }
        return false;
    }

    public bool DelVendedor(Vendedor v)
    {
        if (OsVendedores.Contains(v) && v.ValorVendas() == 0)
        {
            OsVendedores.Remove(v);
            return true;
        }
        return false;
    }

    public Vendedor SearchVendedor(int id)
    {
        return OsVendedores.Find(v => v.Id == id);
    }

    public double ValorVendas()
    {
        return OsVendedores.Sum(v => v.ValorVendas());
    }

    public double ValorComissao()
    {
        return OsVendedores.Sum(v => v.ValorComissao());
    }

    public List<Vendedor> ListarVendedores()
    {
        return OsVendedores;
    }
}