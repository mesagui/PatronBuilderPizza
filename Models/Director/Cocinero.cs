using BuilderPatron.Models.Builder;
using BuilderPatron.Models.Producto;

namespace BuilderPatron.Models.Director
{
    public class Cocinero
    {
        private BuilderPizza _pizzaBuilder;


        public void RecepcionarOrden(BuilderPizza bp){
            _pizzaBuilder = bp;
        }

        public void CocinarPizza(){
            _pizzaBuilder.PasoPrepararMasa();
            _pizzaBuilder.PasoAgregarSalsa();
            _pizzaBuilder.PasoPrepararRelleno();
        }

        public Pizza PizzaPreparada{
            get { return _pizzaBuilder.ObtenerPizza();}
        }
    }
}