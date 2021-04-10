public override void VisitPropertyDeclaration(PropertyDeclarationSyntax node)
{
    var name = ToCamelCase(node.Identifier.Text);
    var t = TranslateType(node.Type);

    Write(t);
    WriteModifiers(node.Modifiers);
    Write(name);

    if (node.Initializer != null)
    {
        Write(" = ");
        Visit(node.Initializer.Value);
    }

    Write($";");

    NewLine();
}