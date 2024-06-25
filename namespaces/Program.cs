namespace SampleNamespace
{
  class SampleClass
  {
    public static void SampleMethod()
    {
      System.Console.WriteLine("SampleMethod inside SampleNamespace");
    }
  }
}

namespace AnotherSampleNamespace;

class AnotherSampleClass
{
  public static void AnotherSampleMethod()
  {
    System.Console.WriteLine("SampleMethod inside SampleNamespace");
  }
}