using System;

namespace PolymorphismTest1
{
  internal class CxClassB : ICanDoWork
  {
    public void DoWork() => Console.WriteLine("I am a base class B !");
  }

  internal class CxClassB1 : ICanDoWork
  {
    public void DoWork() => Console.WriteLine(" } } } } } } Class B1");
  }


  internal class CxClassB2 : ICanDoWork
  {
    public void DoWork() => Console.WriteLine(" } } } } } } Class B2");
  }
}

