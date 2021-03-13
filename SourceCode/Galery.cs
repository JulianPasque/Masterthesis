var photo = await MediaPicker.PickPhotoAsync();

if(photo == null)
{
	Console.WriteLine("No image selected.");
}

