using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace APICatalogo.Models
{
    public class Categoria
    {
        //quando tem definição de coleção (public icollection), tem que definir a inicialização dessa coleção
        //faz a chamada public categoria porque é responsabilidade da entidade categoria inicializar os produtos
        //normalmente nao inicializa, mas é uma boa prática
        public Categoria()
        {
            //minha propriedade Produtos é um new Collection de produto
            Produtos = new Collection<Produto>();
        }
        public int CategoriaId { get; set; }
        public string Nome { get; set; }
        public string ImagemUrl { get; set; }

        // uma categoria possui muitos produtos, entao defino uma coleção de produtos em categorias
        public ICollection<Produto> Produtos { get; set; }
    }
}