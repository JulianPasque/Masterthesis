class State<Type>
{
  Type getValue() => null;
} 
void processState(State state) 
{ 
  dynamic value = state.getValue(); 
} 
void processStateWithType(State<String> state) 
{ 
  String value = state.getValue(); 
}