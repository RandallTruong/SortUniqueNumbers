using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unique_Numbers
{
    public class Numbers
    {
        // Fields
        private readonly List<int> _numbers = new List<int>();
        private int _userEntry;
        private String _sortedNumbers;
        private int _count;
        private String _ascendingOrDescending;

        
        // Methods
        public List<int> SetNumbers()
        {
            while (_count == 0)
            {
                Console.Write("How many numbers would you like to Sort: ");
                try
                {
                    _count = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Entry was not a valid number. Please try again.");
                    continue;
                }
            }

            for (var i = 0; i < _count;)
            {
                Console.Write("Please enter a number: ");
                try
                {
                    _userEntry = Convert.ToInt32(Console.ReadLine());
                    if (!_numbers.Contains(_userEntry))
                    {
                        _numbers.Add(_userEntry);
                        i++;
                    }
                    else
                    Console.WriteLine("Number has already been entered. Please Try again");
                    continue;
                }
                catch (Exception)
                {
                    Console.WriteLine("Entry was not a valid number. Please try again");
                    continue;
                }

            }
            return this._numbers;
        }

        public String SortNumbers(List<int> numbers)
        {
            while (true)
            {
                Console.Write("Would you like to sort the numbers in ascending or descending order: ");
                _ascendingOrDescending = Console.ReadLine();
                try
                {
                    if (_ascendingOrDescending.ToLower() == "ascending")
                    {
                        numbers.Sort();
                        break;
                    }
                    else if (_ascendingOrDescending.ToLower() == "descending")
                    {
                        numbers.Reverse();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Entry was invalid. Please enter ascending or descending");
                        continue;
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Entry was invalid. 'Pleas enter ascending or descending");
                    continue;
                }

            }
            this._sortedNumbers = String.Join(",", numbers);
            return _sortedNumbers;
        }

    }



}
