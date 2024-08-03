using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoEstoqueAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GestaoEstoqueAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) 
            : base(options)
        {
            
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
    }
}