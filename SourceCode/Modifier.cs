private void WriteModifiers(SyntaxTokenList modifiers)
{
    if (modifiers.Contains("private"))
    {
        Write("_");
    }
    if (modifiers.Contains("abstract"))
    {
        Write("abstract ");
    }
}