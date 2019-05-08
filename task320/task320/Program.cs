using System;

namespace task320
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TallGuy tallGuy = new TallGuy() { Height = 74, Name = "Jimmy" };
            tallGuy.TalkAboutYourself();
        }
    }
    class TallGuy : IClown
    {
        public void Honk()
        {
            Console.WriteLine("Choo Choo");
        }
        public string FunnyThingIHave { get { return "big boots"; } }
        public string Name;
        public int Height;
        public void TalkAboutYourself()
        {
            Console.WriteLine("My name is " + Name + " and I'm "
            + Height + " inches tall.");
        }
    }
}
