namespace SOLID_Exercise4
{
    public abstract class Produto
    {
        public string Nome { get; set; }

        public decimal Preco { get; set; }

        protected IPromocao promocao;

        public Produto(IPromocao _promocao)
        {
            promocao = _promocao;
        }

        public decimal PrecoVenda()
        {
            return Preco - (Preco * DescontoPromocao());
        }

        public decimal DescontoPromocao()
        {
            return promocao.Desconto();
        }
    }
}
