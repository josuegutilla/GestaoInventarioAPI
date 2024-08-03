using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoEstoqueAPI.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public string? Rua { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }

        // 1 endereco -> 1 usuario
        public Usuario Usuario { get; set; }
    }
}