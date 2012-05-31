using System;
using System.Linq;

namespace BridgePatternApp
{
    public class ReverseFormatter : IFormatter {
        public String Format(String label, string value)
        {
            return String.Format("{0}{1}{2}", label, Environment.NewLine, new String(value.Reverse().ToArray()));
        }
    }
}