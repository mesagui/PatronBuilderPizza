using BuilderPatron.Models.Producto;

namespace BuilderPatron.Models.Builder
{
    public abstract class BuilderPizza
    {
        protected Pizza _pizza = new Pizza();

        public string tamanio { get; set; }


        public Pizza ObtenerPizza(){
            return _pizza;
        }

        public virtual void PasoPrepararMasa(){

        }

        public virtual void PasoAgregarSalsa(){

        }

        public virtual void PasoPrepararRelleno(){

        }         
    }
}