namespace ProjetoVendas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtComissao = new System.Windows.Forms.TextBox();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dgvVendedores = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.lblTotalComissao = new System.Windows.Forms.Label();
            this.lblTotalVendas = new System.Windows.Forms.Label();
            this.lblValorMedio = new System.Windows.Forms.Label();
            this.lblValorComissao = new System.Windows.Forms.Label();
            this.lblValorVendas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedores)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(209, 97);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 0;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(209, 123);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtComissao
            // 
            this.txtComissao.Location = new System.Drawing.Point(209, 149);
            this.txtComissao.Name = "txtComissao";
            this.txtComissao.Size = new System.Drawing.Size(100, 20);
            this.txtComissao.TabIndex = 2;
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(209, 175);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(100, 20);
            this.txtDia.TabIndex = 3;
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(209, 201);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(100, 20);
            this.txtQtde.TabIndex = 4;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(209, 227);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Insira o id do vendedor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Insira o nome do vendedor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Insira o percentual de comissão: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Insira o dia da venda:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Insira a quantidade de itens vendidos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Insira o valor total da venda:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(426, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Cadastrar Vendedor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCadastrar);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(426, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Consultar Vendedor";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnConsultar);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(426, 171);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Excluir Vendedor";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnExcluir);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(426, 201);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Registrar Venda";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnRegistraVenda);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(426, 230);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 23);
            this.button5.TabIndex = 17;
            this.button5.Text = "Listar Vendedores";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnListar);
            // 
            // dgvVendedores
            // 
            this.dgvVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendedores.Location = new System.Drawing.Point(263, 288);
            this.dgvVendedores.Name = "dgvVendedores";
            this.dgvVendedores.Size = new System.Drawing.Size(240, 150);
            this.dgvVendedores.TabIndex = 18;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(444, 87);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 20;
            this.button6.Text = "Sair";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btnSair);
            // 
            // lblTotalComissao
            // 
            this.lblTotalComissao.AutoSize = true;
            this.lblTotalComissao.Location = new System.Drawing.Point(27, 413);
            this.lblTotalComissao.Name = "lblTotalComissao";
            this.lblTotalComissao.Size = new System.Drawing.Size(213, 13);
            this.lblTotalComissao.TabIndex = 22;
            this.lblTotalComissao.Text = "Total de comissão de todos os vendedores:";
            // 
            // lblTotalVendas
            // 
            this.lblTotalVendas.AutoSize = true;
            this.lblTotalVendas.Location = new System.Drawing.Point(31, 388);
            this.lblTotalVendas.Name = "lblTotalVendas";
            this.lblTotalVendas.Size = new System.Drawing.Size(209, 13);
            this.lblTotalVendas.TabIndex = 23;
            this.lblTotalVendas.Text = "Total das vendas de todos os vendedores:";
            // 
            // lblValorMedio
            // 
            this.lblValorMedio.AutoSize = true;
            this.lblValorMedio.Location = new System.Drawing.Point(14, 363);
            this.lblValorMedio.Name = "lblValorMedio";
            this.lblValorMedio.Size = new System.Drawing.Size(246, 13);
            this.lblValorMedio.TabIndex = 24;
            this.lblValorMedio.Text = "Valor médio das vendas dos vendedor consultado:";
            // 
            // lblValorComissao
            // 
            this.lblValorComissao.AutoSize = true;
            this.lblValorComissao.Location = new System.Drawing.Point(26, 339);
            this.lblValorComissao.Name = "lblValorComissao";
            this.lblValorComissao.Size = new System.Drawing.Size(214, 13);
            this.lblValorComissao.TabIndex = 25;
            this.lblValorComissao.Text = "Valor da comissão do vendador consultado:";
            // 
            // lblValorVendas
            // 
            this.lblValorVendas.AutoSize = true;
            this.lblValorVendas.Location = new System.Drawing.Point(41, 313);
            this.lblValorVendas.Name = "lblValorVendas";
            this.lblValorVendas.Size = new System.Drawing.Size(178, 13);
            this.lblValorVendas.TabIndex = 26;
            this.lblValorVendas.Text = "ValorTotal do Vendedor Consultado:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblValorVendas);
            this.Controls.Add(this.lblValorComissao);
            this.Controls.Add(this.lblValorMedio);
            this.Controls.Add(this.lblTotalVendas);
            this.Controls.Add(this.lblTotalComissao);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dgvVendedores);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtQtde);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.txtComissao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtId);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtComissao;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dgvVendedores;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label lblTotalComissao;
        private System.Windows.Forms.Label lblTotalVendas;
        private System.Windows.Forms.Label lblValorMedio;
        private System.Windows.Forms.Label lblValorComissao;
        private System.Windows.Forms.Label lblValorVendas;
    }
}

