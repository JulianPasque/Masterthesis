var ClickedEvent = GetValueForAttribute(_Node, "Clicked");
if (!String.IsNullOrEmpty(ClickedEvent))
    SourceCode = SourceCode.Replace("%CLICK%", ClickedEvent + "(context);");