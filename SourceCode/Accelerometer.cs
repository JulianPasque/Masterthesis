int startIndex = expectedResult.IndexOf("Accelerometer.ReadingChanged +=");
if (startIndex != -1)
{
    EndIndex = Code.IndexOf("\n", startIndex);
    
    Code = expectedResult.Substring(
        startIndex + "Accelerometer.ReadingChanged += ".Length  ,
        EndIndex - startIndex - "Accelerometer.ReadingChanged +=".Length-1);
    Code = Code.Replace("Accelerometer.start(speed)", "");
    Code = Code.Replace("SensorSpeed     speed  = SensorSpeed.UI;", "");
    Code = Code.Replace("Accelerometer.ReadingChanged += " + EventName ,
        DartFileManager.ReadResource("Sensors.Accelerometer.txt"));

    Code = Code.Replace("%METHOD%", EventName);

    Code = Code.Replace("Reading.Acceleration.X", "x;");
    Code = Code.Replace("Reading.Acceleration.Y", "y;");
    Code = Code.Replace("Reading.Acceleration.Z", "z;");

    DepencyManager.AddDependencie("sensors");
    await DepencyManager.ImportStatement(File,
        "import 'package:sensors/sensors.dart';");
}
