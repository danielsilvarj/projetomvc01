using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoMVC01.Domain.Entities
{
   public class Fornecedor
    {
        public Guid IdFornecedor { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }

        #region Associações

        public List<Produto> Produtos { get; set; }
        
        #endregion

    }
}
