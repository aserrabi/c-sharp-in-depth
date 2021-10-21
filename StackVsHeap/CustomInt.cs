namespace StackVsHeap
{
  // internal class CustomInt // This goes to the heap, note the difference if you comment this line and uncomment next
  internal struct CustomInt // This goes to the stack, but big structs might overflow it.
  {
    internal int Value { get; set; } 
  }
}