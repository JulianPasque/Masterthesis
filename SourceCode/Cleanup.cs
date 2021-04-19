public static List<string> RemovePlaceholder(List<String> _LinesOfCode){
    var LinesToDelete = new List<string>();
    foreach (string L in _LinesOfCode)
    {
        if (L.IndexOf('%') != L.LastIndexOf('%') && L.IndexOf('%') != -1)
            LinesToDelete.Add(L);
    }
    foreach (string S in LinesToDelete)
        _LinesOfCode.Remove(S);
    return _LinesOfCode;
}