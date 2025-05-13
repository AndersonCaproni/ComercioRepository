namespace Comercio.Domain
{
    public class PedidoProduto : Base
    {
        private long _pedidoId;
        private Pedido _pedido;
        private long _produtoId;
        private Produto _produto;
        private int _quantidade;

        public long PedidoId
        {
            get { return _pedidoId; }
            set { _pedidoId = value; }
        }

        public Pedido Pedido
        {
            get { return _pedido; }
            set { _pedido = value; }
        }

        public long ProdutoId
        {
            get { return _produtoId; }
            set { _produtoId = value; }
        }

        public Produto Produto
        {
            get { return _produto; }
            set { _produto = value; }
        }

        public int Quantidade
        {
            get { return _quantidade; }
            set { _quantidade = value; }
        }
    }
}