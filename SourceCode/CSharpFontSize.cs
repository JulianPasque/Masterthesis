private static double GetFontSize(object _SizeValue)
{
    if(_SizeValue is double)
    {
        return Convert.ToDouble(_SizeValue);
    }
    string NamedSize = (String)_SizeValue;

    if (NamedSize.Equals("Caption", StringComparison.OrdinalIgnoreCase))
        return 12;
    if (NamedSize.Equals("Micro", StringComparison.OrdinalIgnoreCase))
        return 10;
    if (NamedSize.Equals("Header", StringComparison.OrdinalIgnoreCase))
        return 34;
    if (NamedSize.Equals("Large", StringComparison.OrdinalIgnoreCase))
        return 34;
    if (NamedSize.Equals("Medium", StringComparison.OrdinalIgnoreCase))
        return 14;
    if (NamedSize.Equals("Small", StringComparison.OrdinalIgnoreCase))
        return 10;
    if (NamedSize.Equals("Subtitle", StringComparison.OrdinalIgnoreCase))
        return 16;
    if (NamedSize.Equals("Title", StringComparison.OrdinalIgnoreCase))
        return 24;
    return 12;
}