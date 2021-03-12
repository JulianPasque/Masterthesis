final pickedFile = await picker.getImage(source: ImageSource.camera);

setState(() {
    if (pickedFile != null) {
           _image = File(pickedFile.path);
    } else {
           print('No image selected.');
    }
});

