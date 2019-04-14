/********************************************************************************
Title: AlbertEijePDV
Description: Pesquisa por produto e importacao para a venda.

The MIT License

Copyright: Copyright (C) 2012 Albert Eije

Permission is hereby granted, free of charge, to any person
obtaining a copy of this software and associated documentation
files (the "Software"), to deal in the Software without
restriction, including without limitation the rights to use,
copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the
Software is furnished to do so, subject to the following
conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
OTHER DEALINGS IN THE SOFTWARE.

       The author may be contacted at:
           alberteije@gmail.com

@author Albert Eije
@version 1.0
********************************************************************************/


using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NFCe.DTO;
using NFCe.Controller;
using NFCe.Util;

namespace NFCe.View
{

    public partial class FCadastroProduto : Form
    {

        private static List<ProdutoDTO> ListaProduto;

        public FCadastroProduto()
        {
            // Required for Windows Form Designer support
            InitializeComponent();
            EditLocaliza.Focus();
            ListaProduto = new List<ProdutoDTO>();
            GridPrincipal.AutoGenerateColumns = false;
        }

        private void botaoCancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SpeedButton1_Click(object sender, EventArgs e)
        {
            Localiza();
        }

        private void FImportaProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Localiza();
            if (e.KeyCode == Keys.Escape)
                botaoCancela.PerformClick();
        }

        public void Localiza()
        {
            string ProcurePor = "%" + EditLocaliza.Text + "%";
            string Filtro = "Nome like " + Biblioteca.QuotedStr(ProcurePor);
            ListaProduto = (List<ProdutoDTO>)ProdutoController.ConsultaProdutoLista(Filtro);
            Label2.Text = ListaProduto.Count.ToString() + " produtos localizados.";
            GridPrincipal.DataSource = ListaProduto;
            if (ListaProduto.Count > 0)
                GridPrincipal.Focus();
        }

        private void GridPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                EditLocaliza.Focus();
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            ProdutoDTO produto = new ProdutoDTO();
            produto.UnidadeProduto = new UnidadeProdutoDTO();

            produto.Gtin = textBoxGtin.Text;
            produto.Nome = textBoxNome.Text;
            produto.DescricaoPdv = textBoxNome.Text;
            produto.ValorVenda = Convert.ToDecimal(textBoxValorUnitario.Text);
            produto.Iat = comboBoxIAT.Text.Substring(0, 1);
            produto.Ippt = comboBoxIPPT.Text.Substring(0, 1);
            produto.CodigoInterno = textBoxCodigoInterno.Text;
            produto.Ncm = textBoxNCM.Text;

            // Os campos abaixo precisam de um valor. Caso queira deixá-los sem valor, marque no banco de dados como "Null=Yes"
            produto.UnidadeProduto.Id = 1;
            produto.IdSubGrupo = 1;


            ProdutoController.GravaProduto(produto);
            
            Localiza();
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            ProdutoDTO produto = new ProdutoDTO();
            produto.UnidadeProduto = new UnidadeProdutoDTO();

            produto.Id = Convert.ToInt32(textBoxId.Text);
            produto.Gtin = textBoxGtin.Text;
            produto.Nome = textBoxNome.Text;
            produto.DescricaoPdv = textBoxNome.Text;
            produto.ValorVenda = Convert.ToDecimal(textBoxValorUnitario.Text);
            produto.Iat = comboBoxIAT.Text.Substring(0, 1);
            produto.Ippt = comboBoxIPPT.Text.Substring(0, 1);
            produto.CodigoInterno = textBoxCodigoInterno.Text;
            produto.Ncm = textBoxNCM.Text;

            // Os campos abaixo precisam de um valor. Caso queira deixá-los sem valor, marque no banco de dados como "Null=Yes"
            produto.UnidadeProduto.Id = 1;
            produto.IdSubGrupo = 1;


            ProdutoController.GravaProduto(produto);

            Localiza();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o produto selecionado?", "Pergunta do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ProdutoDTO produto = new ProdutoDTO();
                produto.Id = Convert.ToInt32(textBoxId.Text);
                ProdutoController.ExcluiProduto(produto);
                Localiza();
            }
        }

        private void GridPrincipal_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (GridPrincipal.RowCount > 1)
            {
                //ID
                if (GridPrincipal.Rows[GridPrincipal.SelectedCells[0].RowIndex].Cells[0].Value != null)
                    textBoxId.Text = GridPrincipal.Rows[GridPrincipal.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
                else
                    textBoxId.Text = "";

                //GTIN
                if (GridPrincipal.Rows[GridPrincipal.SelectedCells[0].RowIndex].Cells[1].Value != null)
                    textBoxGtin.Text = GridPrincipal.Rows[GridPrincipal.SelectedCells[0].RowIndex].Cells[1].Value.ToString();
                else
                    textBoxGtin.Text = "";

                //Nome
                if (GridPrincipal.Rows[GridPrincipal.SelectedCells[0].RowIndex].Cells[2].Value != null)
                    textBoxNome.Text = GridPrincipal.Rows[GridPrincipal.SelectedCells[0].RowIndex].Cells[2].Value.ToString();
                else
                    textBoxNome.Text = "";

                //Valor Unitário
                if (GridPrincipal.Rows[GridPrincipal.SelectedCells[0].RowIndex].Cells[3].Value != null)
                    textBoxValorUnitario.Text = GridPrincipal.Rows[GridPrincipal.SelectedCells[0].RowIndex].Cells[3].Value.ToString();
                else
                    textBoxValorUnitario.Text = "";

                //IPPT
                if (GridPrincipal.Rows[GridPrincipal.SelectedCells[0].RowIndex].Cells[5].Value != null)
                    comboBoxIPPT.Text = GridPrincipal.Rows[GridPrincipal.SelectedCells[0].RowIndex].Cells[5].Value.ToString();
                else
                    comboBoxIPPT.Text = "";

                //IAT
                if (GridPrincipal.Rows[GridPrincipal.SelectedCells[0].RowIndex].Cells[6].Value != null)
                    comboBoxIAT.Text = GridPrincipal.Rows[GridPrincipal.SelectedCells[0].RowIndex].Cells[6].Value.ToString();
                else
                    comboBoxIAT.Text = "";

                //NCM
                if (GridPrincipal.Rows[GridPrincipal.SelectedCells[0].RowIndex].Cells[7].Value != null)
                    textBoxNCM.Text = GridPrincipal.Rows[GridPrincipal.SelectedCells[0].RowIndex].Cells[7].Value.ToString();
                else
                    textBoxNCM.Text = "";

                //Código Interno
                if (GridPrincipal.Rows[GridPrincipal.SelectedCells[0].RowIndex].Cells[8].Value != null)
                    textBoxCodigoInterno.Text = GridPrincipal.Rows[GridPrincipal.SelectedCells[0].RowIndex].Cells[8].Value.ToString();
                else
                    textBoxCodigoInterno.Text = "";
            }
        }


    }

}
