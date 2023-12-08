namespace ANDyNA_v2.Models
{
    public class Usuarios
    {
        public int Id { get; set; }
        public required string Cuenta { get; set; }
        public required string Nombre { get; set; }
        public required int CI { get; set; }
        public required int Celular { get; set; }
        public required string Password { get; set; }
    }
}
