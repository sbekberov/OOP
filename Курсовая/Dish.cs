using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.IO;
namespace ConsoleApp10
{
    class Dish
    {
        public delegate void AccountHandler(string message);
        public event AccountHandler Notify;
        private string name;
        private List <Ingredient> ingredients = new List<Ingredient>();
        private int[] price = new int[2];
        private int[] weithg = new int[2];
        private int code;
        public Dish(string n, List<Ingredient> i )
        {
            name = n;
            ingredients = i;
        }
        public Dish(string n)
        {
            name = n;
            ingredients = new List<Ingredient>();
        }
        
        public Dish(string n, string[] ind,List<int> p, List<int> w,int c)
        {
            name = n;
            price[0] = p[0];
            price[1] = p[1];
            weithg[0] = w[0];
            weithg[1] = w[1];
            foreach (string i in ind)
            {
                ingredients.Add(new Ingredient(i));
            }
            code = c;
        }
       
        public void AddIngredient(string i)
        {
            ingredients.Add(new Ingredient(i));
        }
        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }
        public void ShowDish()
        {
            Console.Write("Название : {0}, вес : {1}/{2} , цена : {3}/{4} , код : ",name,weithg[0],weithg[1],price[0],price[1]);
            Console.WriteLine(code);
            foreach ( Ingredient i in ingredients)
            {
                Console.WriteLine(i.Name);
            }
        }
        public string getInfo(int ind )
        {
            Notify?.Invoke("Было добавлено блюдо");
            string s = "Название : " + name + ", вес : " + weithg[ind] + " , цена : " + price[ind];
            return s;
        }
        public int getPrice(int ind)
        {
            return price[ind];
        }
        public int getWeight(int ind)
        {
            return weithg[ind];
        }
    }
}
