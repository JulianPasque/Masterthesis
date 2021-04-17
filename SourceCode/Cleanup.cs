public static async Task RemoveUnusedPlaceholders(string _Codefile)
{
    string text = await File.ReadAllTextAsync(_Codefile);

    var l = text.Split(new string[]{"\n"}, StringSplitOptions.None).ToList();

    var LinesToDelete = new List<string>();

    foreach (string Line in l)
    {
        var first = Line.IndexOf('%');

        var Placeholder = first != Line.LastIndexOf('%') && first != -1;

        if (Placeholder)  
            LinesToDelete.Add(Line);
        
    }

    foreach (string S in LinesToDelete)
        l.Remove(S);

    await File.WriteAllTextAsync(_Codefile, string.Join("\n", lines));
}