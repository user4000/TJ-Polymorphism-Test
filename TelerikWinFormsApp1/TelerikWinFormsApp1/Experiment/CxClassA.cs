using System;

namespace PolymorphismTest1
{
  internal class CxClassA
  {
    internal virtual void ProcessWork() => Console.WriteLine("I am a base Class A !");
  }

  internal class CxClassA1 : CxClassA
  {
    override internal void ProcessWork() => Console.WriteLine(" > > > > > > Class A1");
  }

  internal class CxClassA2 : CxClassA
  {
    override internal void ProcessWork() => Console.WriteLine(" > > > > > > Class A2");
  }
}

