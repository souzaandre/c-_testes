using System;
namespace Padrao_MVVM
{
    public class Produto
    {
        public int Id { get; set; }         // Identificador
        public string Nome { get; set; }    // Nome do produto
        public float Preco { get; set; }    // Preco do produto

        public Produto()
        {
        }
    }
}
