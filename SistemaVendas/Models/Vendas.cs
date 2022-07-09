using SistemaVendas.Models.Enums;

namespace SistemaVendas.Models
{
    public class Vendas
    {
        public int VendasId { get; set; }
        public  DateTime Data { get; set; }
        public double Quantidade { get; set; }
        public Status status { get; set; }
        public Vendedor vendedor { get; set; }

        public Vendas()
        {
        }

        public Vendas(int vendasId, DateTime data, double quantidade, Status status, Vendedor vendedor)
        {
            VendasId = vendasId;
            Data = data;
            Quantidade = quantidade;
            this.status = status;
            this.vendedor = vendedor;
        }
    }
}
