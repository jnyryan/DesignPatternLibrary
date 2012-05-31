using System;

namespace BridgePatternApp
{
    public interface IFormatter
    {
        String Format(String label, string value);
    }
}