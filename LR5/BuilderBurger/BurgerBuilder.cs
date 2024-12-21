using LR5.DBContent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5.BuilderBurger
{
    public class BurgerBuilder : IBurgerBuilder
    {
        private Burgers _burgers;
        public BurgerBuilder()
        {
            _burgers = new Burgers();
        }
        public IBurgerBuilder AddBacon()
        {
            _burgers.Bacon = true; return this;
        }

        public IBurgerBuilder AddCheese()
        {
            _burgers.Cheese = true; return this;
        }

        public IBurgerBuilder AddLetuce()
        {
            _burgers.Letuce = true; return this;
        }

        public IBurgerBuilder AddTomato()
        {
            _burgers.Tomato = true; return this;
        }

        public Burgers GetBurgers()
        {
            Burgers burger = _burgers;
            _burgers = new Burgers();
            return burger;
        }

        public IBurgerBuilder AddPickles()
        {
            _burgers.Pickles = true; return this;
        }
    }
}
