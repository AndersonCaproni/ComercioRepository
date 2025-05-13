namespace Comercio.Domain
{
    public class Produto : Base
    {
        private string _nome;
        private string _descricao;
        private decimal _valor;
        private List<PedidoProduto> _pedidosProdutos;

        public string Nome 
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

        public decimal Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }

        public List<PedidoProduto> PedidosProdutos
        {
            get { return _pedidosProdutos; }
            set { _pedidosProdutos = value; }
        }

        public Produto()
        {
            PedidosProdutos = new List<PedidoProduto>();
        }
    }
}