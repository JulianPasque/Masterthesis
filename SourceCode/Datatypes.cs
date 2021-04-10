public static string GetKnownName(string name)
{
    switch (name)
    {
        case "Void"         : return "Void";
        case "Int"          : return "Int";
        case "byte"         : return "Int";
        case "short"        : return "Int";
        case "long"         : return "BigInt";
        case "double"       : return "Double";
        case "float"        : return "Double";
        case "char"         : return "String";
        case "string"       : return "String";
        case "List"         : return "List";
        case "Dictionairy"  : return "Map";
        case "bool"         : return "Boolean";
        default: return name;
    }
}