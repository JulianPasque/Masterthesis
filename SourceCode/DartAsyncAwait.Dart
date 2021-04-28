void main() async 
{
  var result = await myFunction();
}

Future<String> myFunction() 
{
  return Future.value('Hello');
}