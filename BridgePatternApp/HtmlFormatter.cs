using System;

namespace BridgePatternApp
{
    public class HtmlFormatter : IFormatter {
        public String Format(String label, string value)
        {
            return String.Format("<h1>{0}</h1><p>{1}</p>", label, value);
        }
    }
}