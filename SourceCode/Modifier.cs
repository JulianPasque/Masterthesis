private void WriteModifiers(SyntaxTokenList modifiers)
{
    Indent();

    if (modifiers.Contains("private"))
    {
        Write("_");
    }
    if (modifiers.Contains("abstract"))
    {
        Write("abstract ");
    }
}