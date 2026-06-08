namespace RestaurantePedidos
{
    public class Postre : Producto
    {
        public bool ContieneAzucar { get; set; }
        public string Porcion { get; set; }

        public Postre()
        {
        }

        public Postre(string codigo, string nombre, double precioBase, bool contieneAzucar, string porcion)
            : base(codigo, nombre, precioBase)
        {
            ContieneAzucar = contieneAzucar;
            Porcion = porcion;
        }
    }
}