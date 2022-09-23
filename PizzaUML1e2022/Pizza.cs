using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaUML1e2022
{
    public class Pizza
    {

		private int _pno;
        private string _pizzaName;
        private double _price;
		private string _ingredients;

		public string Ingredients
		{
			get { return _ingredients; }
			set { _ingredients = value; }
		}

		public int PNO
		{
			get { return _pno; }
			set { _pno = value; }
		}



		public string PizzaName
		{
			get { return _pizzaName; }
			set { _pizzaName = value; }
		}


		

		public double Price
		{
			get { return _price; }
			set { _price = value; }
		}

		public Pizza(int pno, double price, string name, string  ingredients)
		{
			_pno = pno;
			_pizzaName = name;
			_price = price;
			_ingredients = ingredients;
		}

		public override string ToString()
		{
			return $"Pizza nummer { _pno} navn { _pizzaName} ingredienser {_ingredients} pris {_price}";
		}

	}
}
