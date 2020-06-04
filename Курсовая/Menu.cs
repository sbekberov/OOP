using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace ConsoleApp10
{
    class Menu
    {
        private List<Dish> dishes = new List<Dish>();
        public Menu()
        {
            string line;
            int position = 0;
            int start = 0;
            string path = Environment.CurrentDirectory + @"\dishes.txt";
            var sentences = new List<String>();
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    do
                    {
                        position = line.IndexOf('|', start);
                        if (position >= 0)
                        {
                            sentences.Add(line.Substring(start, position - start).Trim());
                            start = position + 1;
                        }
                    } while (position > 0);
                    position = 0;
                    start = 0;
                }
                List<int> p= new List<int>();
                List<int> w= new List<int>();
                for (int i = 0,j=1; i <= sentences.ToArray().Length - 4; i += 4,j++)
                {
                    p.Add(Convert.ToInt32(sentences[i + 2].Split(new char[] { ',' })[0]));
                    p.Add(Convert.ToInt32(sentences[i + 2].Split(new char[] { ',' })[1]));
                    w.Add(Convert.ToInt32(sentences[i + 3].Split(new char[] { ',' })[0]));
                    w.Add(Convert.ToInt32(sentences[i + 3].Split(new char[] { ',' })[1]));
                    dishes.Add(new Dish(sentences[i], sentences[i + 1].Split(new char[] { ',' }),p,w,j));
                    dishes[j-1].Notify += DisplayMessage;
                }
            }
        }
        private static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
        public void ShowAll()
        {
            int i = 0;
            foreach (Dish d in dishes)
            {
                i =+ 1;
                d.ShowDish();
            }
        }

        public int Size
        {
            get { return dishes.ToArray().Length; }
        }
        public Dish this[int index]
        {
            get
            {
                return dishes[index];
            }
            
        }
    }
}
