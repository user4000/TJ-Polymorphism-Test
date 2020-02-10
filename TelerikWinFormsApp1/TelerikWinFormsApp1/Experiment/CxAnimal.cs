using System;
using JsonSubTypes;
using Newtonsoft.Json;

namespace PolymorphismTest1
{
  public class CxAnimal
  {
    public string _type => GetType().Name;

    public static JsonConverter StandardJsonConverter
    {
      get => JsonSubtypesConverterBuilder.Of(typeof(CxAnimal), "_type").Build();
    }

    public virtual void SayHello()
    {
      Console.WriteLine("Hello! I am an ANIMAL.");
    }

  }

  public class CxDog : CxAnimal
  {
    public string Address { get; set; } = "Test 12345";

    public override void SayHello()
    {
      Console.WriteLine(" <<< DOG >>> ");
    }
  }

  public class CxCat : CxAnimal
  {
    public int FriendsCount { get; set; } = 567;
    public override void SayHello()
    {
      Console.WriteLine(" *** CAT *** ");
    }
  }
}

