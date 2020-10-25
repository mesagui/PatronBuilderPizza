namespace BuilderPatron.Models.Producto
{
    public class Pizza
    {

        public int idPizza { get; set; }

        public string masa {get;set;}
        public string salsa { get; set; }
        public string relleno { get; set; }
        public string tamanio { get; set; }

        public Pizza()
        {
            
        }

        public Pizza(string masa,string salsa,string relleno,string tamanio)
        {
            this.masa = masa;
            this.salsa = salsa;
            this.relleno = relleno;
            this.tamanio = tamanio;

        }
    }
}

