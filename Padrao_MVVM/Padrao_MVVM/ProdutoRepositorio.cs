﻿using System;
using System.Linq;
using System.Threading.Tasks;

namespace Padrao_MVVM
{
    public class ProdutoRepositorio
    {
        public ProdutoRepositorio()
        {
        }

        // uma lista de produtos para simular os dados
        private Produto[] produtos = new[]
        {
            new Produto { Id = 1, Nome = "Camisa", Preco = 39.99f },
            new Produto { Id = 2, Nome = "Sapato", Preco = 95.99f },
            new Produto { Id = 3, Nome = "Blusa", Preco = 49.99f },
        };

        public async Task<Produto[]> ProcuraProdutos(string criterio)
        {
            // Aguarda 2 segundos para simular uma requisição
            await Task.Delay(2000);

            // Usando Linq-to-objects para procurar
            criterio = criterio.ToLower();

            return produtos.Where(p => p.Nome.ToLower().Contains(criterio)).ToArray();
        }
    }
}
