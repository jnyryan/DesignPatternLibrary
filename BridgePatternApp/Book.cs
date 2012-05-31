using System;

namespace BridgePatternApp
{
    public class Book : Manuscript
    {
        public String Title { get; set; }
        public String Author { get; set; }
        public String Description { get; set; }

        public Book(IFormatter formatter) : base(formatter){}

        public override void Print()
        {
            Console.WriteLine(formatter.Format(Title, Description));
        }
    }
}