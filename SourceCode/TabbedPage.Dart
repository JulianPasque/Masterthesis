appBar: AppBar(
    bottom: TabBar(
        tabs: [ Tab(icon: Icon(Icons.directions_transit)),
                Tab(icon: Icon(Icons.directions_bike)),],
    ),
    title: Text('Tabs Demo'),
    ),
    body: TabBarView(
    children: [ Icon(Icons.directions_transit),
                Icon(Icons.directions_bike), ],
),