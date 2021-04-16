await Cmd.ExcecuteCMDCommand(TargetPath, 
            "/C \"flutter pub pub add image_picker\"");
await DepencyManager.ImportStatement(File, 
            "import 'package:image_picker/image_picker.dart';");

expectedResult = expectedResult.Replace("MediaPicker.capturePhotoAsync()", 
                    "await picker.getImage(source: ImageSource.camera);");
expectedResult = expectedResult.Replace("MediaPicker.pickPhotoAsync()", 
                    "await picker.getImage(source: ImageSource.gallery);");
await DartFileManager.UpdatePlaceholder(File, "%PROPERTIES%", 
    "final picker = ImagePicker();");
