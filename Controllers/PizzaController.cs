using System.Collections.Generic;
using System.Linq;
using BuilderPatron.Models.BuilderConcreto;
using BuilderPatron.Models.DataBase;
using BuilderPatron.Models.Director;
using BuilderPatron.Models.Producto;
using Microsoft.AspNetCore.Mvc;

namespace BuilderPatron.Controllers
{
    public class PizzaController:Controller
    {
        PizzaContext cnx;
        public PizzaController(PizzaContext cnx)
        {
            this.cnx = cnx;
        }

        public ActionResult Ordenes(){
            return View(cnx.Pizzas.ToList());
        }

        [HttpGet]
        public ActionResult Menu(){
            return View();
        }
        

        [HttpPost]
        public ActionResult Menu(int tipo,string tamanio){

            var cocinero = new Cocinero();
            Pizza pizza = new Pizza();
            // Clietne pide una pizza
            switch(tipo){
                case 1:
                    cocinero.RecepcionarOrden(new PizzaAmericana(tamanio));
                    cocinero.CocinarPizza();
                    pizza = cocinero.PizzaPreparada;
                    TempData["Success"] = "Pizza Lista...";
                    cnx.Pizzas.Add(pizza);
                    cnx.SaveChanges();
                    break;
                case 2:
                    cocinero.RecepcionarOrden(new PizzaCalabresa(tamanio));
                    cocinero.CocinarPizza();
                    pizza = cocinero.PizzaPreparada;
                    TempData["Success"] = "Pizza Lista...";
                    cnx.Pizzas.Add(pizza);
                    cnx.SaveChanges();
                    break;
                case 3:
                    cocinero.RecepcionarOrden(new PizzaNapolitana(tamanio));
                    cocinero.CocinarPizza();
                    pizza = cocinero.PizzaPreparada;
                    TempData["Success"] = "Pizza Lista...";
                    cnx.Pizzas.Add(pizza);
                    cnx.SaveChanges();
                    break;
                default:
                    TempData["Error"] = "Ocurrio un error...";
                    break;
            }

            return RedirectToAction("Ordenes","Pizza");
        }
    }
}