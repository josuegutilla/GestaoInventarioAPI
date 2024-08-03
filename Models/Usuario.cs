using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoEstoqueAPI.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }

        // 1 usuario -> 1 endereco
        public Endereco Endereco { get; set; }
        public int EnderecoId { get; set; }

        // 1 usuario -> N produtos
        public ICollection<Produto> Produtos { get; set; }
    }
}