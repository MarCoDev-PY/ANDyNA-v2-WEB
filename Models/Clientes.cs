namespace ANDyNA_v2.Models
{
    public class Clientes
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int CI { get; set; }
        public int Celular { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaReserva { get; set; }
    }
}
