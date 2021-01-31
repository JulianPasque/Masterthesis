GestureDetector(
    onTap: () async {
        TimeOfDay picked = await showTimePicker(
        context: context,
        initialTime: TimeOfDay.now(),
        builder: (BuildContext context, Widget child) {
           return MediaQuery(
           data: MediaQuery.of(context)
           .copyWith(alwaysUse24HourFormat: true),
           child: child,
           );
        },);
     },
     child: Text("SetTime",textAlign: TextAlign.center,)
);