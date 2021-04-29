StreamController streamController = new StreamController.broadcast();

void main() 
{
  streamController.stream.listen((args) => 
  {
        // Quelltext
  });

  streamController.add("hello");

  streamController.close();
}