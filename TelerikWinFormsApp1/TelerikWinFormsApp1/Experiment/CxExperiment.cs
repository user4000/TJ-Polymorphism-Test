using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PolymorphismTest1
{
  internal class CxExperiment
  {
    internal void Test1()
    {
      List<CxClassA> list = new List<CxClassA>();

      list.Add(new CxClassA());
      list.Add(new CxClassA1());
      list.Add(new CxClassA2());

      foreach (CxClassA item in list) item.ProcessWork();
    }

    internal void Test2()
    {
      List<ICanDoWork> list = new List<ICanDoWork>();

      list.Add(new CxClassB());
      list.Add(new CxClassB1());
      list.Add(new CxClassB2());

      foreach (ICanDoWork item in list) item.DoWork();
    }

    internal void Test3() /* Serialization and Deserialization */
    {
      List<CxAnimal> list1 = new List<CxAnimal>();
      list1.Add(new CxCat());
      list1.Add(new CxDog());
      list1.Add(new CxAnimal());
      string json = JsonConvert.SerializeObject(list1, CxAnimal.StandardJsonConverter);
      Console.WriteLine("Serialized list = ");
      Console.WriteLine(json);
      Console.WriteLine("Trying to deserialize ... ");
      List<CxAnimal> list2 = JsonConvert.DeserializeObject<List<CxAnimal>>(json, CxAnimal.StandardJsonConverter);
      foreach (CxAnimal item in list2) item.SayHello();    
    }
  }
}

