namespace SistemaVendas.Models
{
    public class Vendedor
    {
        public int VendedorId { get; set; }
        public String Nome { get; set; }
        public String Email { get; set; }
       
        public DateTime DataNascimento { get; set; }

        public double SalarioBase { get; set; }
        public Departamento departamento { get; set; }

        public ICollection<Vendas> vendas { get; set; } = new List<Vendas>();

        public Vendedor()
        {
        }

        public Vendedor(int vendedorId, string nome, string email, DateTime dataNascimento, double salarioBase, Departamento departamento)
        {
            VendedorId = vendedorId;
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            SalarioBase = salarioBase;
            this.departamento = departamento;
        }

        public void addVenda(Vendas ven)
        {
            vendas.Add(ven);
        }
        public void removeVenda(Vendas ven)
        {
            vendas.Remove(ven); 
        }

        public double TotalVendas(DateTime inicio,DateTime final)
        {
            return vendas.Where(ven => ven.Data >= inicio && ven.Data <= final).Sum(ven => ven.Quantidade);
        }
    }
}
