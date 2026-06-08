namespace RestaurantePedidos
{
    public class PlatoFuerte : Producto
    {
        public string TipoCarne { get; set; }
        public string Acompanamiento { get; set; }

        public PlatoFuerte()
        {
        }

        public PlatoFuerte(string codigo, string nombre, double precioBase, string tipoCarne, string acompanamiento)
            : base(codigo, nombre, precioBase)
        {
            TipoCarne = tipoCarne;
            Acompanamiento = acompanamiento;
        }
    }
}
