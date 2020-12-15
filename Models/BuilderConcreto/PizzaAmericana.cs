using BuilderPatron.Models.Builder;
using BuilderPatron.Models.Producto;

namespace BuilderPatron.Models.BuilderConcreto
{
    public class PizzaAmericana : BuilderPizza
    {
        public PizzaAmericana(string tam)
        {
            this._pizza.tamanio = tam;
        }

        public override void PasoPrepararMasa()
        {
            _pizza.masa = "Suave";
        }
        
        public override void PasoAgregarSalsa()
        {
            _pizza.salsa="Dulce";
        }
        
        public override void PasoPrepararRelleno()
        {
            _pizza.relleno = "Jamon + Queso";
        }
    }
}