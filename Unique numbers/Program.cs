

namespace Unique_Numbers
{

    public class Program
    {
        static void Main(string[] args)
        {
            var test = new Numbers();
            var listOfNumbers = test.SetNumbers();
            var sortedNumbers = test.SortNumbers(listOfNumbers);
            Console.WriteLine("Your sorted Numbers are: " + sortedNumbers);
            
        }

    }

}