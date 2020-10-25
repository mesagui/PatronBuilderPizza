using BuilderPatron.Models.Builder;

namespace BuilderPatron.Models.BuilderConcreto
{
    public class PizzaNapolitana : BuilderPizza
    {
        public PizzaNapolitana(string tam)
        {
            this._pizza.tamanio = tam;
        }

        public override void PasoPrepararMasa()
        {
            _pizza.masa = "Crocante";
        }
        public override void PasoAgregarSalsa()
        {
            _pizza.salsa = "Roquefort";
        }

        public override void PasoPrepararRelleno()
        {
            _pizza.relleno = "Aceitunas verdes + Perejil + Tomate ";
        }
    }
}