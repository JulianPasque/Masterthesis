class BaseClass 
{
  void myFunction() 
  {
    // Quelltext
  }
}

class MyClass extends BaseClass 
{
  void myOtherFunction() 
  {
    // Quelltext
  }
  // Jede Methode kann ueberschrieben werden
  @override
  void myFunction() 
  {
    // Quelltext
  }
}