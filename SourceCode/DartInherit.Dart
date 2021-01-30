class BaseClass {
  void myFunction() {}
}

class MyClass extends BaseClass {
  void myOtherFunction() {
    // do something
  }

  // every function is overridable in Dart.
  @override
  void myFunction() {
    // do something
  }
}