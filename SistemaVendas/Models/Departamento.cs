namespace SistemaVendas.Models
{
    public class Departamento
    {
        public int DepartamentoId { get; set; }
        public String Nome { get; set; }

        public ICollection<Vendedor> Vendedores { get; set; } = new List<Vendedor>();

        public Departamento()
        {
        }

        public Departamento(int departamentoId, string nome)
        {
            DepartamentoId = departamentoId;
            Nome = nome;
        }

        public void AddVendedor(Vendedor vendedor)
        {
           Vendedores.Add(vendedor);
        }
        public double totalVendas(DateTime inicial,DateTime final)
        {
            return Vendedores.Sum(Vendedor => Vendedor.TotalVendas(inicial,final));
        }
    }
}
