using System;
namespace Park.Models {
  public class Animal
  {
    private string _type;
    private string _name;
    private int _age;
    private string _native;
    private string _food;

    public Animal(string type, string name, int age, string native, string food)
    {
      _type = type;
      _name = name;
      _age = age;
      _native = native;
      _food = food;
    }
    
    public string GetName()
  {
      return _name;
  }
      public string GetType()
  {
      return _type;
  }
      public int GetAge()
  {
      return _age;
  }
      public string GetNative()
  {
      return _native;
  }
      public string GetFood()
  {
      return _food;
  }
    public bool SearchAnimal(string nameInput)
   {
     return (_name == nameInput);
   }
   
  }
}