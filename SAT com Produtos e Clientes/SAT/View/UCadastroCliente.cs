/********************************************************************************
Title: AlbertEijePDV
Description: Pesquisa por Cliente e importacao para a venda.

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

    public partial class FCadastroCliente : Form
    {

        private static List<ClienteDTO> ListaCliente;

        public FCadastroCliente()
        {
            // Required for Windows Form Designer support
            InitializeComponent();
            EditLocaliza.Focus();
            ListaCliente = new List<ClienteDTO>();
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

        private void FImportaCliente_KeyDown(object sender, KeyEventArgs e)
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
            ListaCliente = (List<ClienteDTO>)ClienteController.ConsultaClienteLista(Filtro);
            Label2.Text = ListaCliente.Count.ToString() + " Clientes localizados.";
            GridPrincipal.DataSource = ListaCliente;
            if (ListaCliente.Count > 0)
                GridPrincipal.Focus();
        }

        private void GridPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                EditLocaliza.Focus();
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            ClienteDTO Cliente = new ClienteDTO();

            Cliente.Nome = textBoxNome.Text;
            Cliente.Cpf = textBoxCpf.Text;
            Cliente.LimiteCredito = Convert.ToDecimal(textBoxLimiteCredito.Text);
            Cliente.Rg = textBoxRg.Text;
            Cliente.Endereco = textBoxEndereco.Text;

            // Os campos abaixo precisam de um valor. Caso queira deixá-los sem valor, marque no banco de dados como "Null=Yes"
            Cliente.IdPessoa = 1;
            Cliente.IdAtividadeForCli = 1;
            Cliente.IdSituacaoForCli = 1;


            ClienteController.GravaCliente(Cliente);
            
            Localiza();
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            ClienteDTO Cliente = new ClienteDTO();

            Cliente.Id = Convert.ToInt32(textBoxId.Text);
            Cliente.Nome = textBoxNome.Text;
            Cliente.Cpf = textBoxCpf.Text;
            Cliente.LimiteCredito = Convert.ToDecimal(textBoxLimiteCredito.Text);
            Cliente.Rg = textBoxRg.Text;
            Cliente.Endereco = textBoxEndereco.Text;

            // Os campos abaixo precisam de um valor. Caso queira deixá-los sem valor, marque no banco de dados como "Null=Yes"
            Cliente.IdPessoa = 1;
            Cliente.IdAtividadeForCli = 1;
            Cliente.IdSituacaoForCli = 1;

            ClienteController.GravaCliente(Cliente);

            Localiza();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o Cliente selecionado?", "Pergunta do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClienteDTO Cliente = new ClienteDTO();
                Cliente.Id = Convert.ToInt32(textBoxId.Text);
                ClienteController.ExcluiCliente(Cliente);
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

                //Nome
                if (GridPrincipal.Rows[GridPrincipal.SelectedCells[0].RowIndex].Cells[1].Value != null)
                    textBoxNome.Text = GridPrincipal.Rows[GridPrincipal.SelectedCells[0].RowIndex].Cells[1].Value.ToString();
                else
                    textBoxNome.Text = "";

                //CPF
                if (GridPrincipal.Rows[GridPrincipal.SelectedCells[0].RowIndex].Cells[2].Value != null)
                    textBoxCpf.Text = GridPrincipal.Rows[GridPrincipal.SelectedCells[0].RowIndex].Cells[2].Value.ToString();
                else
                    textBoxCpf.Text = "";

                //RG
                if (GridPrincipal.Rows[GridPrincipal.SelectedCells[0].RowIndex].Cells[3].Value != null)
                    textBoxRg.Text = GridPrincipal.Rows[GridPrincipal.SelectedCells[0].RowIndex].Cells[3].Value.ToString();
                else
                    textBoxRg.Text = "";

                //Limite de Crédito
                if (GridPrincipal.Rows[GridPrincipal.SelectedCells[0].RowIndex].Cells[4].Value != null)
                    textBoxLimiteCredito.Text = GridPrincipal.Rows[GridPrincipal.SelectedCells[0].RowIndex].Cells[4].Value.ToString();
                else
                    textBoxLimiteCredito.Text = "";

                //Endereço
                if (GridPrincipal.Rows[GridPrincipal.SelectedCells[0].RowIndex].Cells[5].Value != null)
                    textBoxEndereco.Text = GridPrincipal.Rows[GridPrincipal.SelectedCells[0].RowIndex].Cells[5].Value.ToString();
                else
                    textBoxEndereco.Text = "";

            }
        }


    }

}
