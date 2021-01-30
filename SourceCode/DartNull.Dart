// no need for ? sign to signal nullable.
int myVariable = null;

// Null checking
if (myVariable != null)

// These work the same way as C#.
myVariable = myVariable ?? 0; // Assigns 0 if null

// Short circuits also work.
myVariable?.toString();
