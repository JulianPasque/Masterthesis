var root = await d.GetSyntaxRootAsync();

var model = await d.GetSemanticModelAsync();

var visitor = new FlutterTranspilerVisitor(model);
var res = visitor.Run(root);
