public static string GetKnownName(string name)
{
    switch (name)
    {
        case "void"         : return "Void";
        case "int"          : return "int";
        case "byte"         : return "int";
        case "short"        : return "int";
        case "long"         : return "BigInt";
        case "double"       : return "double";
        case "float"        : return "double";
        case "char"         : return "String";
        case "string"       : return "String";
        case "List"         : return "List";
        case "Dictionary"  : return "Map";
        case "bool"         : return "bool";
        default: return name;
    }
}