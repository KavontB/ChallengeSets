using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if (Char.IsLetter(c))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {

            if (num % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null|| numbers.Count() == 0) {
                return 0.00; 
            } else {
                double max = numbers.Max();
                double min = numbers.Min();
                return min + max;

        } }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            int length1 = str1.Length;
            int length2 = str2.Length;
            if(length1 < length2)
            {
                return length1;
            }
            else { return length2; }

        }

        public int Sum(int[] numbers)
        {
            int sum = 0;
            if (numbers == null)
            {
                return 0;
            }
            else
            {
                foreach (var item in numbers)
                {
                    sum += item;
                }
                return sum;
            }
        }

        public int SumEvens(int[] numbers)
        {
            int sum = 0;
            if (numbers == null ||numbers.Length == 0)
            {
                return 0;
            }
            else { 
            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    sum = num + sum;
                }
                else
                {

                }

            } }
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int sum = 0;
            if (numbers == null)
            {
                return false;
            }
            else
            {
                foreach (var item in numbers)
                {
                    sum += item;
                }
                if (sum % 2 == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long count = 0;
            if (number > 0)
            {
                for (int i = 0; i < number; i++)
                {
                    if (i % 2 != 0)
                    {
                        count++;
                    }

                }
            }
            else
            {
                return 0;
            }
            return count;
        }
    }
}
