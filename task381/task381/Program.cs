using System;
using System.Collections.Generic;

namespace task381
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shoe> shoeCloset = new List<Shoe>();
            shoeCloset.Add(new Shoe()
            { Style = Style.Sneakers, Color = "Черный" });
            shoeCloset.Add(new Shoe()
            { Style = Style.Clogs, Color = "Коричневый" });
            shoeCloset.Add(new Shoe()
            { Style = Style.Wingtips, Color = "Черный" });
            shoeCloset.Add(new Shoe()
            { Style = Style.Loafers, Color = "Белый" });
            shoeCloset.Add(new Shoe()
            { Style = Style.Loafers, Color = "Красный" });
            shoeCloset.Add(new Shoe()
            { Style = Style.Sneakers, Color = "Зеленый" });

            /*
                List<Shoe> shoeCloset = new List<Shoe>() {
                new Shoe() { Style = Style.Sneakers, Color = "Черный" },
                new Shoe() { Style = Style.Clogs, Color = "Коричневый" },
                new Shoe() { Style = Style.Wingtips, Color = "Черный" },
                new Shoe() { Style = Style.Loafers, Color = "Белый" },
                new Shoe() { Style = Style.Loafers, Color = "Красный" },
                new Shoe() { Style = Style.Sneakers, Color = "Зеленый" },
                };
             */

            int numberOfShoes = shoeCloset.Count;
            foreach (Shoe shoe in shoeCloset)
            {
                shoe.Style = Style.Flipflops;
                shoe.Color = "Оранжевый";
            }
            shoeCloset.RemoveAt(4);
            Shoe thirdShoe = shoeCloset[2];
            Shoe secondShoe = shoeCloset[1];
            shoeCloset.Clear();
            //if (shoeCloset.Contains(secondShoe))
                Console.WriteLine(shoeCloset.Capacity);

        }
    }
    class Shoe
    {
        public Style Style;
        public string Color;
    }
    enum Style
    {
        Sneakers,
        Loafers,
        Sandals,
        Flipflops,
        Wingtips,
        Clogs
    }
}
