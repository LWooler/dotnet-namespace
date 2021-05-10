using System;
using FluentAssertions;

namespace dotnet_namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            var myExample = new exampleClass();
            myExample.additionMethod();
            Console.WriteLine("Hello FluentAssertions!");
        }
        public class exampleClass {
        public void additionMethod() {
            var first = 3;
            var second = 7;
            var result = first + second;

            result.Should().Be(10);
        }
    }


}
}
