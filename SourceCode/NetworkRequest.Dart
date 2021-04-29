import 'dart:convert';
import 'package:flutter/material.dart';
import 'package:http/http.dart' as http;
[...]
  loadData() async 
  {
    String dataURL = "www.jsonplaceholder.typicode.com/posts";
    http.Response response = await http.get(dataURL);
    setState(() 
    {
      widgets = jsonDecode(response.body);
    });
  }
}