using System;
using System.Threading.Tasks;

namespace Padrao_MVVM
{
    public class ProdutoViewModel
    {
        private readonly ProdutoRepositorio repositorio = new ProdutoRepositorio();
        public string Criterio { get; set; }
        public Produto[] Produtos { get; private set; }

        public ProdutoViewModel()
        {
        }

        public async Task Procurar()
        {
            if (string.IsNullOrEmpty(Criterio))
                Produtos = null;
            else
                Produtos = await repositorio.ProcuraProdutos(Criterio);
        }
    }
}
