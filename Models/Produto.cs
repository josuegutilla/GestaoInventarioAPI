using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoEstoqueAPI.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public decimal Preco { get; set; }

        // 1 Produto -> 1 Usuario
        public Usuario Usuario { get; set; }
        public int UsuarioId { get; set; }
    }
}