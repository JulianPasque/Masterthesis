void main() async {
  var result = await myFunction();
}

Future<String> myFunction() {
  // Similar to Task.FromResult
  return Future.value('Hello');
}