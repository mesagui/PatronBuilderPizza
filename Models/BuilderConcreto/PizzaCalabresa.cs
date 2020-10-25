using BuilderPatron.Models.Builder;

namespace BuilderPatron.Models.BuilderConcreto
{
    public class PizzaCalabresa: BuilderPizza
    {
        public PizzaCalabresa(string tam)
        {
            this._pizza.tamanio = tam;
        }

        public override void PasoPrepararMasa()
        {
            _pizza.masa = "Suave";
        }
        public override void PasoAgregarSalsa()
        {
            _pizza.salsa = "Dulce";
        }
        public override void PasoPrepararRelleno()
        {
            _pizza.relleno= "Longaniza calabesa + Aceituna + Queso ";
        }
    }
}