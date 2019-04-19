using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task201
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            MenuMaker menu = new MenuMaker()
            { randomizer = new Random() };

            label1.Text = menu.GetMenuItem();
            label2.Text = menu.GetMenuItem();
            label3.Text = menu.GetMenuItem();
            label4.Text = menu.GetMenuItem();
            label5.Text = menu.GetMenuItem();
            label6.Text = menu.GetMenuItem();
        }
    }
    public class MenuMaker
    {
        public Random randomizer;

        string[] Meats = { "Roast beef", "Salami", "Turkey", "Ham", "Pastrami" };
        string[] Condiments = { "yellow mustard", "brown mustard", "honey mustard", "mayo", "relish", "french dressing" };
        string[] Breads = { "rye", "white", "wheat", "pumpernickel","italian bread", "a roll" };

        public string GetMenuItem()
        {
            string randomMeat = Meats[randomizer.Next(Meats.Length)];
            string randomCondiment = Condiments[randomizer.Next(Condiments.Length)];
            string randomBread = Breads[randomizer.Next(Breads.Length)];
            return randomMeat + " with " + randomCondiment + " on " + randomBread;
        }
    }
}
