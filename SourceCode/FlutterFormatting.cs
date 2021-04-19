public static async Task FormatDocument(string _Path, string _DartDocument)
{
    await Cmd.ExcecuteCMDCommand(
        _Path,
         "/C \"flutter format " + _DartDocument + "\"");
}