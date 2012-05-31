using System;

namespace BridgePatternApp
{
    public class Paper : Manuscript {
        public String Title { get; set; }
        public String Publisher { get; set; }
        public String Description { get; set; }

        public Paper(IFormatter formatter) : base(formatter){}

        public override void Print()
        {
            Console.WriteLine(formatter.Format(Title, Description));
        }
    }
}