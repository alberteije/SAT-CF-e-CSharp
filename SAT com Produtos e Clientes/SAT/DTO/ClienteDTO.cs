using System;
using System.Text;
using System.Collections.Generic;


namespace NFCe.DTO {
    
    public class ClienteDTO {
        public ClienteDTO() { }
        public int Id { get; set; }
        public int IdTributOperacaoFiscal { get; set; }
        public int IdPessoa { get; set; }
        public int IdAtividadeForCli { get; set; }
        public int IdSituacaoForCli { get; set; }
        public System.Nullable<System.DateTime> Desde { get; set; }
        public System.Nullable<System.DateTime> DataCadastro { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Endereco { get; set; }
        public string Observacao { get; set; }
        public string ContaTomador { get; set; }
        public string GeraFinanceiro { get; set; }
        public string IndicadorPreco { get; set; }
        public System.Nullable<decimal> PorcentoDesconto { get; set; }
        public string FormaDesconto { get; set; }
        public System.Nullable<decimal> LimiteCredito { get; set; }
        public string TipoFrete { get; set; }
        public string ClassificacaoContabilConta { get; set; }
        public System.Nullable<int> IdConvenio { get; set; }
    }
}
