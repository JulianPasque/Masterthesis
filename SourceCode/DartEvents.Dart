StreamController streamController = new StreamController.broadcast();

void main() {
  streamController.stream.listen((args) => {
        // do something
      });

  streamController.add("hello");

  streamController.close();