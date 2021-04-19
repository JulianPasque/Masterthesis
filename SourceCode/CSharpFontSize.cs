private static double GetFontSize(object _SizeValue)
{
    if(_SizeValue is double)
        return Convert.ToDouble(_SizeValue);
    
    string NamedSize = (String)_SizeValue;

    switch (NamedSize)
    {
        case "Caption"  : return 12;
        case "Micro"    : return 10;
        case "Header"   : return 34;
        case "Large"    : return 34;
        case "Medium"   : return 14;
        case "Small"    : return 10;
        case "Subtitle" : return 16;
        case "Title"    : return 24;
        default: return 12;
    }
}