namespace RestaurantePedidos
{
    public class Producto
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public double PrecioBase { get; set; }

        public Producto()
        {
        }

        public Producto(string codigo, string nombre, double precioBase)
        {
            Codigo = codigo;
            Nombre = nombre;
            PrecioBase = precioBase;
        }
    }
}