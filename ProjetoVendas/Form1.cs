using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoVendas
{
    public partial class Form1 : Form
    {
        public partial class Form1 : Form
        {
            private Vendedores vendedores = new Vendedores();

            public Form1()
            {
                InitializeComponent();
            }

            private void btnCadastrar_Click(object sender, EventArgs e)
            {
                if (vendedores.ListarVendedores().Count >= 10)
                {
                    MessageBox.Show("Número máximo de vendedores atingido.");
                    return;
                }
                Vendedor vendedor = new Vendedor
                {
                    Id = int.Parse(txtId.Text),
                    Nome = txtNome.Text,
                    PercComissao = double.Parse(txtComissao.Text)
                };
                if (vendedores.AddVendedor(vendedor))
                {
                    MessageBox.Show("Vendedor cadastrado com sucesso.");
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar vendedor.");
                }
            }

            private void btnConsultar_Click(object sender, EventArgs e)
            {
                int id = int.Parse(txtId.Text);
                Vendedor vendedor = vendedores.SearchVendedor(id);
                if (vendedor != null)
                {
                    txtNome.Text = vendedor.Nome;
                    lblValorVendas.Text = $"Valor Total das Vendas: {vendedor.ValorVendas():C}";
                    lblValorComissao.Text = $"Comissão: {vendedor.ValorComissao():C}";
                    lblValorMedio.Text = $"Valor Médio: {vendedor.ValorMedio():C}";
                }
                else
                {
                    MessageBox.Show("Vendedor não encontrado.");
                }
            }

            private void btnExcluir_Click(object sender, EventArgs e)
            {
                int id = int.Parse(txtId.Text);
                Vendedor vendedor = vendedores.SearchVendedor(id);
                if (vendedor != null && vendedores.DelVendedor(vendedor))
                {
                    MessageBox.Show("Vendedor excluído com sucesso.");
                }
                else
                {
                    MessageBox.Show("Erro ao excluir vendedor. Verifique se ele possui vendas registradas.");
                }
            }

            private void btnRegistrarVenda_Click(object sender, EventArgs e)
            {
                int id = int.Parse(txtId.Text);
                int dia = int.Parse(txtDia.Text);
                Venda venda = new Venda
                {
                    Qtde = int.Parse(txtQtde.Text),
                    Valor = double.Parse(txtValor.Text)
                };
                Vendedor vendedor = vendedores.SearchVendedor(id);
                if (vendedor != null)
                {
                    vendedor.RegistrarVenda(dia, venda);
                    MessageBox.Show("Venda registrada com sucesso.");
                }
                else
                {
                    MessageBox.Show("Vendedor não encontrado.");
                }
            }

            private void btnListar_Click(object sender, EventArgs e)
            {
                dgvVendedores.Rows.Clear();
                foreach (var vendedor in vendedores.ListarVendedores())
                {
                    dgvVendedores.Rows.Add(vendedor.Id, vendedor.Nome, vendedor.ValorVendas(), vendedor.ValorComissao());
                }
                lblTotalVendas.Text = $"Total das Vendas: {vendedores.ValorVendas():C}";
                lblTotalComissao.Text = $"Total da Comissão: {vendedores.ValorComissao():C}";
            }
        }
    }
}
