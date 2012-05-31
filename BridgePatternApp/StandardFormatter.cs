using System;

namespace BridgePatternApp
{
    public class StandardFormatter:IFormatter {
        public String Format(String label, string value)
        {
            return String.Format("{0}:{1}", label, value);
        }
    }
}