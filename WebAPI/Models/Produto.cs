using System;

namespace WebAPI.Models

{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public string Caracteristicas { get; set; }
        public double PrecoMedio { get; set; }
        public string Logotipo { get; set; }
        public bool Ativo { get; set; }

        // Referência para classe TipoProduto
        public TipoProduto IdTipoProduto { get; set; }


        public Produto()
        {
        }
        public Produto(int IdProduto, string NomeProduto, string Caracteristicas, double PrecoMedio, string Logotipo, bool Ativo, int IdTipoProduto)

        {
            this.IdProduto = IdProduto;
            this.NomeProduto = NomeProduto;
            this.Caracteristicas = Caracteristicas;
            this.PrecoMedio = PrecoMedio;
            this.Logotipo = Logotipo;
            this.Ativo = Ativo;
            this.IdTipoProduto = IdTipoProduto;

        }
    }
}
