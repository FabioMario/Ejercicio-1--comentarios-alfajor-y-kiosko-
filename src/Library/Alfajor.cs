using System;

namespace Expert_SRP
{
    public class Alfajor 
    // No cumple con SRP porque tiene dos responsabilidades, la de decir si hay suficiente dinero para comprar un alfajor y la de convertir ese dinero a pesos.
    {
        public Alfajor(double precioMasa, double precioDulce)
        {
            this.PrecioDulce = precioDulce;
            this.PrecioMasa = precioMasa;
        }
        public Double PrecioDulce {get;set;}
        public Double PrecioMasa {get; set;}
    }
}