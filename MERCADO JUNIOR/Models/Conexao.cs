using System.Data.Entity;

namespace MERCADO_JUNIOR.Models
{
    public class Conexao : DbContext
    {
        public Conexao() : base("CadastroClientes")
        {

        }

        public DbSet<Cliente> Cliente { get; set; }
    }
}