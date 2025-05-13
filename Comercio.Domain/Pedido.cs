namespace Comercio.Domain
{
    public class Pedido : Base
    {
        #region Atributos

        private DateTime _dataPedido;
        private string _cliente;
        private List<PedidoProduto> _pedidosProdutos;

        #endregion 

        #region Propriedades

        public DateTime DataPedido
        {
            get { return _dataPedido; }
            set { _dataPedido = value; }
        }

        public string Cliente
        {
            get { return _cliente; }
            set { _cliente = value; }
        }

        public List<PedidoProduto> PedidosProdutos
        {
            get { return _pedidosProdutos; }
            set { _pedidosProdutos = value; }
        }

        #endregion

        #region Construtores

        public Pedido()
        {
            PedidosProdutos = new List<PedidoProduto>();
        }
        
        #endregion
    }

}