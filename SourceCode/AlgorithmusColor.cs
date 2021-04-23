public static string GetColor(string _Color)
{
    var color = Color.FromName(_Color);
    if(color.IsKnownColor)
    {
        return string.Format("{0:x6}", color.ToArgb());
    }
    
    if (_Color[0] == '#')
    {
        _Color = _Color.Remove(0, 1);
    }

    int res = 0;
    if (int.TryParse(_Color,
                NumberStyles.HexNumber,
                CultureInfo.InvariantCulture, out res))
    {
        if(_Color.Length == 3)
        {
            return "ff" + _Color[0] + _Color[0] + 
                _Color[1] + _Color[1] + 
                _Color[2] + _Color[2];
        }
        else if(_Color.Length == 4)
        {
            return "" + _Color[0] + _Color[0] +
                _Color[1] + _Color[1] + 
                _Color[2] + _Color[2] + 
                _Color[3] + _Color[3];
        }
        else if(_Color.Length == 6)
        {
            return "ff" + _Color;
        }
        else if(_Color.Length == 8)
        {
            return _Color;
        }
    }
    throw new ArgumentException("Could not identify a Color", _Color);
}