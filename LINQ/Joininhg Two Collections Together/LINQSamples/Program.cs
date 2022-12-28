using System;

namespace LINQSamples
{
  class Program
  {
    static void Main(string[] args)
    {
      // Instantiate the ViewModel
      SamplesViewModel vm = new SamplesViewModel
      {
        // Use Query or Method Syntax?
        UseQuerySyntax = false
      };

      // Call a sample method
      vm.LeftOuterJoin();

      // Display Result Text
      Console.WriteLine(vm.ResultText);
    }
  }
}
